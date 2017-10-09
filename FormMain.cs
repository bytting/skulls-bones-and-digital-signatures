/*
    Skulls, Bones and Digital Signatures
    Copyright (C) 2017  Dag Robole

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace nrpa_keys
{
    public partial class FormMain : Form
    {
        AboutBox aboutBox = new AboutBox();
        Settings settings = new Settings();
        string settingsFilename;

        public FormMain()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width / 2;
            Height = Screen.PrimaryScreen.Bounds.Height / 2;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tabs.Appearance = TabAppearance.FlatButtons;
            tabs.ItemSize = new Size(0, 1);
            tabs.SizeMode = TabSizeMode.Fixed;
            tabs.SelectedTab = pageMenu;

            string exeFolder = (new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).Directory + "\\";
            string settingsFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
            settingsFilename = settingsFolder + "skulls-bones-and-digital-signatures-settings.xml";

            if (File.Exists(settingsFilename))
            {
                StreamReader sr = new StreamReader(settingsFilename);
                XmlSerializer x = new XmlSerializer(settings.GetType());
                settings = x.Deserialize(sr) as Settings;
                sr.Close();
                tbSettingsPrivateKeyFolder.Text = settings.PrivateKeyFolder;
                tbSettingsPublicKeyFolder.Text = settings.PublicKeyFolder;
            }
            else
            {
                settings.PrivateKeyFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                settings.PublicKeyFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                tbSettingsPrivateKeyFolder.Text = settings.PrivateKeyFolder;
                tbSettingsPublicKeyFolder.Text = settings.PublicKeyFolder;
            }

            tabs_SelectedIndexChanged(sender, e);            
        }

        private void LogLine(string line)
        {
            lbLog.Items.Insert(0, "[" + DateTime.Now.ToString() + "] " + line);
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void PopulatePrivateKeyList(ref ListView lw)
        {
            if (!Directory.Exists(tbSettingsPrivateKeyFolder.Text))
                return;

            lw.Items.Clear();
            string[] keys = Directory.GetFiles(tbSettingsPrivateKeyFolder.Text, "*.privkey", SearchOption.TopDirectoryOnly);
            foreach (string key in keys)
            {
                string k = Path.GetFileNameWithoutExtension(key);
                ListViewItem item = new ListViewItem(k, 0);
                lw.Items.Add(item);
            }
        }

        private void PopulatePublicKeyList(ref ListView lw)
        {
            if (!Directory.Exists(tbSettingsPublicKeyFolder.Text))
                return;

            lw.Items.Clear();
            string[] keys = Directory.GetFiles(tbSettingsPublicKeyFolder.Text, "*.pubkey", SearchOption.TopDirectoryOnly);
            foreach (string key in keys)
            {
                string k = Path.GetFileNameWithoutExtension(key);
                ListViewItem item = new ListViewItem(k, 0);
                lw.Items.Add(item);
            }
        }

        private void MenuItemNewKey_Click(object sender, EventArgs e)
        {            
            FormName form = new FormName();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string basePrivKeyName = tbSettingsPrivateKeyFolder.Text + Path.DirectorySeparatorChar + form.NewName + ".privkey";
                string basePubKeyName = tbSettingsPublicKeyFolder.Text + Path.DirectorySeparatorChar + form.NewName + ".pubkey";
                if (File.Exists(basePrivKeyName))
                {
                    LogLine("A private key named " + form.NewName + " already exists");
                    return;
                }

                if (File.Exists(basePubKeyName))
                {
                    LogLine("A public key named " + form.NewName + " already exists");
                    return;
                }

                Enabled = false;            
                LogLine("Generating new key. Please wait...");                
                Application.DoEvents();

                DigitalSignature sig = new DigitalSignature();
                sig.CreateNewKey();
                LogLine("Storing new key as files...");
                sig.SaveKeys(basePrivKeyName, basePubKeyName, form.NewPassword);

                PopulatePrivateKeyList(ref lwKeys);
                LogLine("New key created");                
                Enabled = true;            
            }
        }

        private void MenuItemSignFile_Click(object sender, EventArgs e)
        {            
            if (lwSign.SelectedItems.Count < 1)
            {
                LogLine("You must select a key");
                return;
            }

            string privKeyFilename = tbSettingsPrivateKeyFolder.Text + Path.DirectorySeparatorChar + lwSign.SelectedItems[0].Text + ".privkey";
            string pubKeyFilename = tbSettingsPublicKeyFolder.Text + Path.DirectorySeparatorChar + lwSign.SelectedItems[0].Text + ".pubkey";

            if (!File.Exists(privKeyFilename))
            {
                LogLine("Private key " + privKeyFilename + " does not exist");
                return;
            }

            if (!File.Exists(pubKeyFilename))
            {
                LogLine("Public key " + pubKeyFilename + " does not exist");
                return;
            }

            FormPass form = new FormPass();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            string password = form.Password;
            DigitalSignature sig = new DigitalSignature();
            try
            {
                sig.LoadKeys(privKeyFilename, password);
            }            
            catch(Exception ex)
            {                
                LogLine("Invalid password");                
                return;
            }            

            FileDialog.Multiselect = true;
            FileDialog.Title = "Select files for signing";
            if (FileDialog.ShowDialog() != DialogResult.OK)
                return;

            Enabled = false;            
            LogLine("Signing files. Please wait...");
            Application.DoEvents();

            foreach (string filename in FileDialog.FileNames)
            {                
                byte[] bytes = File.ReadAllBytes(filename);
                var sha256 = SHA256.Create();
                var hashedData = sha256.ComputeHash(bytes);

                var signature = sig.SignData(hashedData);
                string signatureFilename = filename + ".signature";
                sig.SaveSignature(signatureFilename, signature);                
            }
            
            string dirName = "";
            if(FileDialog.FileNames.Length > 0)
                dirName = Path.GetDirectoryName(FileDialog.FileNames[0]);
            LogLine("Signatures created in directory " + dirName);

            Enabled = true;            
        }

        private void MenuItemVerifyFile_Click(object sender, EventArgs e)
        {                        
            if (lwVerify.SelectedItems.Count < 1)
            {
                LogLine("You must select a key");
                return;
            }

            string pubKeyFilename = tbSettingsPublicKeyFolder.Text + Path.DirectorySeparatorChar + lwVerify.SelectedItems[0].Text + ".pubkey";
            if (!File.Exists(pubKeyFilename))
            {
                LogLine("Public key " + pubKeyFilename + " does not exist");
                return;
            }

            DigitalSignature sig = new DigitalSignature();
            sig.LoadPublicKey(pubKeyFilename);

            FileDialog.Multiselect = false;
            FileDialog.Title = "Select file for verification";
            if (FileDialog.ShowDialog() != DialogResult.OK)
                return;

            string dataFilename = FileDialog.FileName;
            string sigFilename = dataFilename + ".signature";
            if (!File.Exists(sigFilename))
            {
                LogLine("Signature file " + sigFilename  + " does not exist");
                return;
            }

            Enabled = false;
            LogLine("Verifying file " + dataFilename + ". Please wait...");
            Application.DoEvents();

            byte[] signature = null;
            bool verified = false;

            try
            {
                signature = sig.LoadSignature(sigFilename);

                byte[] bytes = File.ReadAllBytes(dataFilename);
                var sha256 = SHA256.Create();

                var hashedData = sha256.ComputeHash(bytes);
                verified = sig.VerifySignature(hashedData, signature);
            }
            catch (DigitalSignatureException ex)
            {
                LogLine(ex.Message);                
                return;
            }
            catch (Exception ex)
            {
                LogLine("Verify error: " + ex.Message);                
                return;
            }
            finally
            {
                Enabled = true;
            }                        

            if (verified)
                LogLine("Verify ok");
            else
                LogLine("Verify failed");                                    
        }

        private void btnMenuKeys_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageKeys;
        }

        private void btnMenuSign_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageSign;
        }

        private void btnMenuVerify_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageVerify;
        }

        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageSettings;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageMenu;
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {            
            lblView.Text = tabs.SelectedTab.Text;

            if (tabs.SelectedTab == pageMenu)
            {
                btnBack.Enabled = false;
                panelLog.Visible = false;
            }
            else
            {
                btnBack.Enabled = true;
                panelLog.Visible = true;
            }

            if (tabs.SelectedTab == pageKeys)
            {
                btnNewKey.Visible = true;
                PopulatePrivateKeyList(ref lwKeys);
            }
            else btnNewKey.Visible = false;

            if (tabs.SelectedTab == pageSign)
            {
                btnSignFile.Visible = true;
                PopulatePrivateKeyList(ref lwSign);
            }
            else btnSignFile.Visible = false;

            if (tabs.SelectedTab == pageVerify)
            {
                btnVerify.Visible = true;
                PopulatePublicKeyList(ref lwVerify);
            }
            else btnVerify.Visible = false;
        }

        private void btnSettingsChangePrivFolder_Click(object sender, EventArgs e)
        {
            FolderBrowser.Description = "Select directory for private keys";                        
            if (FolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                settings.PrivateKeyFolder = FolderBrowser.SelectedPath;
                tbSettingsPrivateKeyFolder.Text = settings.PrivateKeyFolder;
                PopulatePrivateKeyList(ref lwKeys);
                PopulatePrivateKeyList(ref lwSign);
                LogLine("Directory for private keys updated");
            }
        }

        private void btnSettingsChangePubFolder_Click(object sender, EventArgs e)
        {
            FolderBrowser.Description = "Select directory for public keys";                        
            if (FolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                settings.PublicKeyFolder = FolderBrowser.SelectedPath;
                tbSettingsPublicKeyFolder.Text = settings.PublicKeyFolder;                
                PopulatePublicKeyList(ref lwVerify);
                LogLine("Directory for public keys updated");
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter(settingsFilename);
            XmlSerializer x = new XmlSerializer(settings.GetType());
            x.Serialize(sw, settings);
            sw.Close();
        }

        private void lwKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwKeys.SelectedItems.Count > 0)
                btnExportPubKey.Enabled = true;
            else btnExportPubKey.Enabled = false;
        }

        private void btnExportPubKey_Click(object sender, EventArgs e)
        {
            if (lwKeys.SelectedItems.Count < 1)
                return;

            string privKeyFilename = tbSettingsPrivateKeyFolder.Text + Path.DirectorySeparatorChar + lwKeys.SelectedItems[0].Text + ".privkey";
            if (!File.Exists(privKeyFilename))
            {
                LogLine("Private key " + privKeyFilename + " does not exist");
                return;
            }            

            FormPass form = new FormPass();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            string password = form.Password;
            DigitalSignature sig = new DigitalSignature();
            try
            {
                sig.LoadKeys(privKeyFilename, password);
            }
            catch (DigitalSignatureException ex)
            {
                LogLine(ex.Message);
            }
            catch (Exception ex)
            {
                LogLine("LoadKeys: An error has occurred. " + ex.Message);
                return;
            }            

            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveFileDialog.Filter = "Public keys | *.pubkey";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)            
                sig.SavePublicKey(SaveFileDialog.FileName);            
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            aboutBox.ShowDialog();
        }                
    }
}
