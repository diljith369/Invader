using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Invader
{
    public partial class HybridShellForm : Form
    {
        public HybridShellForm()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            Cursor oCurrent = Cursor.Current;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (txtPvtkey.Text.Trim() != string.Empty && txtPubKey.Text.Trim() != string.Empty && txtlhost.Text.Trim() != string.Empty && txtlport.Text.Trim() != string.Empty)
                {
                    SharedProps.GetInstance.UpdateHybridShellTemplate(txtlhost.Text + ":" + txtlport.Text, SharedProps.GetInstance.SourceFile, txtagentname.Text, txtPvtkey.Text.Trim(), "", false);
                    SharedProps.GetInstance.UpdateHybridShellTemplate(txtlport.Text, SharedProps.GetInstance.ManagerFile, txtagentname.Text, "", txtPubKey.Text.Trim(), true);

                    SharedProps.GetInstance.HybridRevShell = !SharedProps.GetInstance.HybridRevShell;
                    btnBuild.Enabled = false;
                    btnShowfile.Enabled = true;
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = oCurrent;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
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
