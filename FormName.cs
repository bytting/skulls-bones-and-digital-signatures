/*
    Skulls, Bones and Digital Signatures
    Copyright (C) 2014  Dag Robole

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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nrpa_keys
{
    public partial class FormName : Form
    {
        public string NewName, NewPassword;

        public FormName()
        {
            InitializeComponent();
        }

        private void FormName_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            tbName.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            if (String.IsNullOrEmpty(tbName.Text))
            {
                lblStatus.Text = "You must provide a name";
                return;
            }

            if (tbPass1.Text.Length < 8)
            {
                lblStatus.Text = "Minimum 8 characters in password";
                return;
            }

            if (tbPass1.Text != tbPass2.Text)
            {
                lblStatus.Text = "Passwords does not match";
                return;
            }

            NewName = tbName.Text;
            NewPassword = tbPass1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                btnOk_Click(sender, e);
            }
        }        
    }
}
