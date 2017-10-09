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
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace nrpa_keys
{
    public partial class FormPass : Form
    {
        public string Password;

        public FormPass()
        {
            InitializeComponent();
        }

        private void FormPass_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            tbPass.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            if (tbPass.Text.Length < 8)
            {
                lblStatus.Text = "Invalid password";
                return;
            }

            Password = tbPass.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {         
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                btnOk_Click(sender, e);
            }        
        }
    }
}
