using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Invader
{
    public partial class CutomShellCodeForm : Form
    {
        public CutomShellCodeForm()
        {
            InitializeComponent();
        }

        private void btnlblAgent_Click(object sender, EventArgs e)
        {

        }

        private void CutomShellCodeForm_Load(object sender, EventArgs e)
        {
            lblHeading.Text = SharedProps.GetInstance.FormCaption;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            Cursor oCurrent = Cursor.Current;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (txtshellcode.Text.Trim() != string.Empty && txtagentname.Text.Trim() != string.Empty && txtenckey.Text.Trim() != string.Empty)
                {
                    SharedProps.GetInstance.UpdateCustomShellCodeTemplate(txtenckey.Text, txtshellcode.Text, txtagentname.Text, "customshell.go");
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = oCurrent;
                btnShowfile.Enabled = true;
                btnBuild.Enabled = false;

            }

        }

        private bool ValidateTextBox(TextBox oTextBox)
        {
            bool bStatus = true;
            if (oTextBox.Text.Trim() == string.Empty)
            {
                errorProvider.SetError(oTextBox, "Missing required value");
                bStatus = false;
            }
            else
                errorProvider.SetError(oTextBox, "");
            return bStatus;
        }

        private void textbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox((sender as TextBox));
        }

       
        private void txtenckey_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblenckey_Click(object sender, EventArgs e)
        {

        }

       

        private void btnShowfile_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = Directory.GetParent(SharedProps.GetInstance.OutFilePath).FullName,
                UseShellExecute = true,
                Verb = "open"
            });

            btnShowfile.Enabled = false;
            btnBuild.Enabled = true;
        }
    }
}
