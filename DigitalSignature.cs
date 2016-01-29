using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace nrpa_keys
{    
    class DigitalSignatureException : Exception
    {
        private string mMsg;

        public DigitalSignatureException(string msg)
        {
            mMsg = msg;
        }

        public override string Message
        {
            get { return mMsg; }            
        }
    }

    class DigitalSignature
    {
        private const int mSaltSize = 8;
        private const int mKeySize = 2048;

        private RSACryptoServiceProvider mRsa;
        private RSAParameters mPrivateKey;
        private RSAParameters mPublicKey;

        public DigitalSignature()
        {
            mRsa = new RSACryptoServiceProvider();
            mRsa.PersistKeyInCsp = false;
        }                

        public void CreateNewKey()
        {
            mRsa = new RSACryptoServiceProvider(mKeySize);            
            mRsa.PersistKeyInCsp = false;
            mPublicKey = mRsa.ExportParameters(false);
            mPrivateKey = mRsa.ExportParameters(true);                
        }

        public void SaveKeys(string privKeyFile, string pubKeyFile, string password)
        {
            FileInfo fiPriv = new FileInfo(privKeyFile);
            EncryptToFile(fiPriv, password, GetBytes(mRsa.ToXmlString(true)));

            FileInfo fiPub = new FileInfo(pubKeyFile);
            SaveToFile(fiPub, mRsa.ToXmlString(false));            
        }

        public void SavePublicKey(string pubKeyFile)
        {            
            FileInfo fiPub = new FileInfo(pubKeyFile);
            SaveToFile(fiPub, mRsa.ToXmlString(false));
        }

        public void LoadKeys(string privKeyFile, string password)
        {
            FileInfo fiPriv = new FileInfo(privKeyFile);            
            byte[] data = DecryptFromFile(fiPriv, password);

            string privXml = GetString(data);                    
            mRsa.FromXmlString(privXml);
            mPublicKey = mRsa.ExportParameters(false);
            mPrivateKey = mRsa.ExportParameters(true);        
        }        

        public void LoadPublicKey(string pubKeyFile)
        {            
            string pubXml = File.ReadAllText(pubKeyFile);            
            mRsa.FromXmlString(pubXml);
            mPublicKey = mRsa.ExportParameters(false);            
        }

        public byte[] SignData(byte[] hashOfDataToSign)
        {            
            var rsaFormatter = new RSAPKCS1SignatureFormatter(mRsa);
            rsaFormatter.SetHashAlgorithm("SHA256");

            return rsaFormatter.CreateSignature(hashOfDataToSign);            
        }

        public bool VerifySignature(byte[] hashOfDataToSign, byte[] signature)
        {            
            var rsaDeformatter = new RSAPKCS1SignatureDeformatter(mRsa);
            rsaDeformatter.SetHashAlgorithm("SHA256");

            return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);            
        }

        public void SaveSignature(string sigFile, byte[] signature)
        {
            StreamWriter sw = new StreamWriter(sigFile);
            sw.Write(Convert.ToBase64String(signature));
            sw.Close();
        }

        public byte[] LoadSignature(string sigFile)
        {
            StreamReader sr = null;
            byte[] signature = null;

            if (!File.Exists(sigFile))
                throw new DigitalSignatureException("Filen " + sigFile + " ble ikke funnet");

            try
            {
                sr = new StreamReader(sigFile);
                signature = Convert.FromBase64String(sr.ReadToEnd());
            }
            catch
            {
                throw new DigitalSignatureException("Filen " + sigFile + " har ugyldig format");
            }
            finally
            {
                if(sr != null)
                    sr.Close();
            }

            return signature;
        }

        private void EncryptToFile(FileInfo targetFile, string password, byte[] data)
        {
            var keyGenerator = new Rfc2898DeriveBytes(password, mSaltSize);
            var rijndael = Rijndael.Create();

            // BlockSize, KeySize in bit --> divide by 8
            rijndael.IV = keyGenerator.GetBytes(rijndael.BlockSize / 8);
            rijndael.Key = keyGenerator.GetBytes(rijndael.KeySize / 8);

            FileStream fileStream = null;
            try
            {
                fileStream = targetFile.Create();
                fileStream.Write(keyGenerator.Salt, 0, mSaltSize);

                CryptoStream cryptoStream = null;
                try
                {
                    cryptoStream = new CryptoStream(fileStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(data, 0, data.Length);
                }
                finally
                {
                    if (cryptoStream != null)
                        cryptoStream.Close();
                }
            }
            finally
            {
                if(fileStream != null)
                    fileStream.Close();
            }                       
        }

        private byte[] DecryptFromFile(FileInfo sourceFile, string password)
        {            
            int dataLen;
            Rijndael rijndael;
            byte[] salt = null;
            byte[] data = null;            

            FileStream fileStream = null;
            CryptoStream cryptoStream = null;
            try
            {
                // read salt                
                fileStream = sourceFile.OpenRead();
                salt = new byte[mSaltSize];
                fileStream.Read(salt, 0, mSaltSize);

                // initialize algorithm with salt
                var keyGenerator = new Rfc2898DeriveBytes(password, salt);
                rijndael = Rijndael.Create();
                rijndael.IV = keyGenerator.GetBytes(rijndael.BlockSize / 8);
                rijndael.Key = keyGenerator.GetBytes(rijndael.KeySize / 8);

                // decrypt
                dataLen = (int)sourceFile.Length - mSaltSize;
                data = new byte[dataLen];
                
                cryptoStream = new CryptoStream(fileStream, rijndael.CreateDecryptor(), CryptoStreamMode.Read);                                
                cryptoStream.Read(data, 0, dataLen);                
            }            
            finally
            {
                if (cryptoStream != null)
                    cryptoStream.Close();                
                if (fileStream != null)
                    fileStream.Close();
            }

            return data;
        }

        private void SaveToFile(FileInfo targetFile, string data)
        {
            var fileStream = targetFile.CreateText();
            fileStream.Write(data);
            fileStream.Close();
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}
