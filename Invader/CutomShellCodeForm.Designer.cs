namespace Invader
{
    partial class CutomShellCodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutomShellCodeForm));
            this.btnBuild = new System.Windows.Forms.Button();
            this.txtagentname = new System.Windows.Forms.TextBox();
            this.btnlblAgent = new System.Windows.Forms.Label();
            this.txtshellcode = new System.Windows.Forms.TextBox();
            this.lblShellCode = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnShowfile = new System.Windows.Forms.Button();
            this.txtenckey = new System.Windows.Forms.TextBox();
            this.lblenckey = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuild.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuild.Location = new System.Drawing.Point(14, 427);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(267, 30);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // txtagentname
            // 
            this.txtagentname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagentname.Location = new System.Drawing.Point(15, 394);
            this.txtagentname.Name = "txtagentname";
            this.txtagentname.Size = new System.Drawing.Size(534, 23);
            this.txtagentname.TabIndex = 2;
            this.txtagentname.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // btnlblAgent
            // 
            this.btnlblAgent.BackColor = System.Drawing.Color.Transparent;
            this.btnlblAgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlblAgent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlblAgent.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlblAgent.Location = new System.Drawing.Point(12, 370);
            this.btnlblAgent.Name = "btnlblAgent";
            this.btnlblAgent.Size = new System.Drawing.Size(87, 21);
            this.btnlblAgent.TabIndex = 17;
            this.btnlblAgent.Text = "Agent Save As";
            this.btnlblAgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlblAgent.Click += new System.EventHandler(this.btnlblAgent_Click);
            // 
            // txtshellcode
            // 
            this.txtshellcode.BackColor = System.Drawing.Color.DimGray;
            this.txtshellcode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshellcode.Location = new System.Drawing.Point(12, 62);
            this.txtshellcode.Multiline = true;
            this.txtshellcode.Name = "txtshellcode";
            this.txtshellcode.Size = new System.Drawing.Size(537, 249);
            this.txtshellcode.TabIndex = 0;
            this.txtshellcode.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // lblShellCode
            // 
            this.lblShellCode.BackColor = System.Drawing.Color.Transparent;
            this.lblShellCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblShellCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShellCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblShellCode.Location = new System.Drawing.Point(12, 39);
            this.lblShellCode.Name = "lblShellCode";
            this.lblShellCode.Size = new System.Drawing.Size(77, 26);
            this.lblShellCode.TabIndex = 13;
            this.lblShellCode.Text = "Shell Code";
            this.lblShellCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnclose.Location = new System.Drawing.Point(526, 8);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 26);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 466);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeading.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHeading.Location = new System.Drawing.Point(15, 6);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(505, 30);
            this.lblHeading.TabIndex = 20;
            this.lblHeading.Text = "Reverse Shell";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowfile
            // 
            this.btnShowfile.BackColor = System.Drawing.Color.Transparent;
            this.btnShowfile.Enabled = false;
            this.btnShowfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowfile.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowfile.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShowfile.Location = new System.Drawing.Point(287, 427);
            this.btnShowfile.Name = "btnShowfile";
            this.btnShowfile.Size = new System.Drawing.Size(262, 30);
            this.btnShowfile.TabIndex = 4;
            this.btnShowfile.Text = "Show Files";
            this.btnShowfile.UseVisualStyleBackColor = false;
            this.btnShowfile.Click += new System.EventHandler(this.btnShowfile_Click);
            // 
            // txtenckey
            // 
            this.txtenckey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenckey.Location = new System.Drawing.Point(15, 341);
            this.txtenckey.Name = "txtenckey";
            this.txtenckey.Size = new System.Drawing.Size(534, 23);
            this.txtenckey.TabIndex = 1;
            this.txtenckey.TextChanged += new System.EventHandler(this.txtenckey_TextChanged);
            this.txtenckey.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // lblenckey
            // 
            this.lblenckey.BackColor = System.Drawing.Color.Transparent;
            this.lblenckey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblenckey.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenckey.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblenckey.Location = new System.Drawing.Point(12, 315);
            this.lblenckey.Name = "lblenckey";
            this.lblenckey.Size = new System.Drawing.Size(87, 21);
            this.lblenckey.TabIndex = 23;
            this.lblenckey.Text = "Key To Decrypt";
            this.lblenckey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblenckey.Click += new System.EventHandler(this.lblenckey_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CutomShellCodeForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 466);
            this.Controls.Add(this.txtshellcode);
            this.Controls.Add(this.txtenckey);
            this.Controls.Add(this.lblenckey);
            this.Controls.Add(this.btnShowfile);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.txtagentname);
            this.Controls.Add(this.btnlblAgent);
            this.Controls.Add(this.lblShellCode);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CutomShellCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CutomShellCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TextBox txtagentname;
        private System.Windows.Forms.Label btnlblAgent;
        private System.Windows.Forms.TextBox txtshellcode;
        private System.Windows.Forms.Label lblShellCode;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnShowfile;
        private System.Windows.Forms.TextBox txtenckey;
        private System.Windows.Forms.Label lblenckey;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
