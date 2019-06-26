namespace Invader
{
    partial class InvaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvaderForm));
            this.btnclose = new System.Windows.Forms.Button();
            this.btnNormalTCPShell = new System.Windows.Forms.Button();
            this.btnHybridShell = new System.Windows.Forms.Button();
            this.btnHttpShell = new System.Windows.Forms.Button();
            this.btnhttpsShell = new System.Windows.Forms.Button();
            this.btnPSRevShell = new System.Windows.Forms.Button();
            this.btnInstallShield = new System.Windows.Forms.Button();
            this.btnMSBuild = new System.Windows.Forms.Button();
            this.btnShellCode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInvader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnclose.Location = new System.Drawing.Point(812, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(33, 26);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnNormalTCPShell
            // 
            this.btnNormalTCPShell.BackColor = System.Drawing.Color.Transparent;
            this.btnNormalTCPShell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNormalTCPShell.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormalTCPShell.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNormalTCPShell.Location = new System.Drawing.Point(12, 115);
            this.btnNormalTCPShell.Name = "btnNormalTCPShell";
            this.btnNormalTCPShell.Size = new System.Drawing.Size(120, 32);
            this.btnNormalTCPShell.TabIndex = 3;
            this.btnNormalTCPShell.Text = "TCP Shell";
            this.btnNormalTCPShell.UseVisualStyleBackColor = false;
            this.btnNormalTCPShell.Click += new System.EventHandler(this.btnNormalTCPShell_Click);
            // 
            // btnHybridShell
            // 
            this.btnHybridShell.BackColor = System.Drawing.Color.Transparent;
            this.btnHybridShell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHybridShell.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHybridShell.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHybridShell.Location = new System.Drawing.Point(12, 153);
            this.btnHybridShell.Name = "btnHybridShell";
            this.btnHybridShell.Size = new System.Drawing.Size(120, 32);
            this.btnHybridShell.TabIndex = 4;
            this.btnHybridShell.Text = "Hybrid Shell";
            this.btnHybridShell.UseVisualStyleBackColor = false;
            this.btnHybridShell.Click += new System.EventHandler(this.btnHybridShell_Click);
            // 
            // btnHttpShell
            // 
            this.btnHttpShell.BackColor = System.Drawing.Color.Transparent;
            this.btnHttpShell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHttpShell.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHttpShell.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHttpShell.Location = new System.Drawing.Point(12, 229);
            this.btnHttpShell.Name = "btnHttpShell";
            this.btnHttpShell.Size = new System.Drawing.Size(120, 32);
            this.btnHttpShell.TabIndex = 5;
            this.btnHttpShell.Text = "Http Shell";
            this.btnHttpShell.UseVisualStyleBackColor = false;
            this.btnHttpShell.Click += new System.EventHandler(this.btnHttpShell_Click);
            // 
            // btnhttpsShell
            // 
            this.btnhttpsShell.BackColor = System.Drawing.Color.Transparent;
            this.btnhttpsShell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhttpsShell.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhttpsShell.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnhttpsShell.Location = new System.Drawing.Point(13, 191);
            this.btnhttpsShell.Name = "btnhttpsShell";
            this.btnhttpsShell.Size = new System.Drawing.Size(119, 32);
            this.btnhttpsShell.TabIndex = 6;
            this.btnhttpsShell.Text = "Https Shell";
            this.btnhttpsShell.UseVisualStyleBackColor = false;
            this.btnhttpsShell.Click += new System.EventHandler(this.btnHttps_Click);
            // 
            // btnPSRevShell
            // 
            this.btnPSRevShell.BackColor = System.Drawing.Color.Transparent;
            this.btnPSRevShell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPSRevShell.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSRevShell.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPSRevShell.Location = new System.Drawing.Point(13, 267);
            this.btnPSRevShell.Name = "btnPSRevShell";
            this.btnPSRevShell.Size = new System.Drawing.Size(119, 32);
            this.btnPSRevShell.TabIndex = 7;
            this.btnPSRevShell.Text = "PS Rev Shell ";
            this.btnPSRevShell.UseVisualStyleBackColor = false;
            this.btnPSRevShell.Click += new System.EventHandler(this.btnPSRevShell_Click);
            // 
            // btnInstallShield
            // 
            this.btnInstallShield.BackColor = System.Drawing.Color.Transparent;
            this.btnInstallShield.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstallShield.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallShield.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInstallShield.Location = new System.Drawing.Point(13, 381);
            this.btnInstallShield.Name = "btnInstallShield";
            this.btnInstallShield.Size = new System.Drawing.Size(119, 32);
            this.btnInstallShield.TabIndex = 10;
            this.btnInstallShield.Text = "Install Shield";
            this.btnInstallShield.UseVisualStyleBackColor = false;
            this.btnInstallShield.Click += new System.EventHandler(this.btnInstallShield_Click);
            // 
            // btnMSBuild
            // 
            this.btnMSBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnMSBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMSBuild.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSBuild.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMSBuild.Location = new System.Drawing.Point(13, 343);
            this.btnMSBuild.Name = "btnMSBuild";
            this.btnMSBuild.Size = new System.Drawing.Size(119, 32);
            this.btnMSBuild.TabIndex = 9;
            this.btnMSBuild.Text = "MS Build";
            this.btnMSBuild.UseVisualStyleBackColor = false;
            this.btnMSBuild.Click += new System.EventHandler(this.btnMSBuild_Click);
            // 
            // btnShellCode
            // 
            this.btnShellCode.BackColor = System.Drawing.Color.Transparent;
            this.btnShellCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShellCode.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShellCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShellCode.Location = new System.Drawing.Point(13, 305);
            this.btnShellCode.Name = "btnShellCode";
            this.btnShellCode.Size = new System.Drawing.Size(119, 32);
            this.btnShellCode.TabIndex = 8;
            this.btnShellCode.Text = "Shell Code";
            this.btnShellCode.UseVisualStyleBackColor = false;
            this.btnShellCode.Click += new System.EventHandler(this.btnShellCode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 539);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblInvader
            // 
            this.lblInvader.AutoSize = true;
            this.lblInvader.BackColor = System.Drawing.Color.Transparent;
            this.lblInvader.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblInvader.Location = new System.Drawing.Point(314, 9);
            this.lblInvader.Name = "lblInvader";
            this.lblInvader.Size = new System.Drawing.Size(213, 25);
            this.lblInvader.TabIndex = 1;
            this.lblInvader.Text = "THE INVADER";
            this.lblInvader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InvaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 539);
            this.Controls.Add(this.lblInvader);
            this.Controls.Add(this.btnInstallShield);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnShellCode);
            this.Controls.Add(this.btnMSBuild);
            this.Controls.Add(this.btnPSRevShell);
            this.Controls.Add(this.btnHttpShell);
            this.Controls.Add(this.btnhttpsShell);
            this.Controls.Add(this.btnHybridShell);
            this.Controls.Add(this.btnNormalTCPShell);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invader";
            this.Load += new System.EventHandler(this.InvaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnNormalTCPShell;
        private System.Windows.Forms.Button btnHybridShell;
        private System.Windows.Forms.Button btnHttpShell;
        private System.Windows.Forms.Button btnhttpsShell;
        private System.Windows.Forms.Button btnPSRevShell;
        private System.Windows.Forms.Button btnInstallShield;
        private System.Windows.Forms.Button btnMSBuild;
        private System.Windows.Forms.Button btnShellCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInvader;
    }
}

