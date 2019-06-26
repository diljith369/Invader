using System;
using System.Windows.Forms;

namespace Invader
{
    public partial class InvaderForm : Form
    {
        public InvaderForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvaderForm_Load(object sender, EventArgs e)
        {
            try
            {
                SharedProps.GetInstance.CreateTemplates();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }

        private void btnNormalTCPShell_Click(object sender, EventArgs e)
        {
            SharedProps.GetInstance.FormCaption = "Normal Reverse Shell";
            SharedProps.GetInstance.SourceFile = "simpleshell.go";
            SharedProps.GetInstance.ManagerFile = "simpleshellmngr.go";
            SharedProps.GetInstance.CurrentSelection = SharedProps.SelectedShellType.SimpleReverseShell;
            new BuildForm().ShowDialog();

        }

        private void treeView1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void btnHttps_Click(object sender, EventArgs e)
        {
            SharedProps.GetInstance.FormCaption = "Https Reverse Shell";
            SharedProps.GetInstance.SourceFile = "httpsrev.go";
            SharedProps.GetInstance.ManagerFile = "httpsrevmngr.go";
            SharedProps.GetInstance.CurrentSelection = SharedProps.SelectedShellType.HttpsReverseShell;
            new BuildForm().ShowDialog();
        }

        private void btnHttpShell_Click(object sender, EventArgs e)
        {
            SharedProps.GetInstance.FormCaption = "Http Reverse Shell";
            SharedProps.GetInstance.SourceFile = "httprev.go";
            SharedProps.GetInstance.ManagerFile = "httprevmngr.go";
            SharedProps.GetInstance.CurrentSelection = SharedProps.SelectedShellType.HttpReverseShell;
            new BuildForm().ShowDialog();
        }

        private void btnShellCode_Click(object sender, EventArgs e)
        {
            SharedProps.GetInstance.FormCaption = "Reverse Shell using Encrypted Shell Code";
            SharedProps.GetInstance.SourceFile = "customshell.go";
            SharedProps.GetInstance.CurrentSelection = SharedProps.SelectedShellType.CustomShellCode;
            new CutomShellCodeForm().ShowDialog();
        }

        private void btnHybridShell_Click(object sender, EventArgs e)
        {
            SharedProps.GetInstance.FormCaption = "Hybrid Reverse Shell";
            SharedProps.GetInstance.SourceFile = "hybridclient.go";
            SharedProps.GetInstance.ManagerFile = "hybridmanager.go";
            SharedProps.GetInstance.CurrentSelection = SharedProps.SelectedShellType.HybridReverseShell;
            new HybridShellForm().ShowDialog();
        }

        private void btnMSBuild_Click(object sender, EventArgs e)
        {
            SharedProps.GetInstance.FormCaption = "MsBuild Reverse Shell";
            SharedProps.GetInstance.SourceFile = "msbuild.go";
            SharedProps.GetInstance.CurrentSelection = SharedProps.SelectedShellType.MsBuildReverseShell;
            new BuildForm().ShowDialog();

        }

        private void btnInstallShield_Click(object sender, EventArgs e)
        {
            SharedProps.GetInstance.FormCaption = "Install Shield Reverse Shell";
            SharedProps.GetInstance.SourceFile = "installshield.go";
            SharedProps.GetInstance.CurrentSelection = SharedProps.SelectedShellType.InstallShieldReverseShell;
            new BuildForm().ShowDialog();
        }

        private void btnPSRevShell_Click(object sender, EventArgs e)
        {
            SharedProps.GetInstance.FormCaption = "PowerShell Reverse Shell";
            SharedProps.GetInstance.SourceFile = "psrevshell.go";
            SharedProps.GetInstance.CurrentSelection = SharedProps.SelectedShellType.PSReverseShell;
            new BuildForm().ShowDialog();
        }
    }
}
