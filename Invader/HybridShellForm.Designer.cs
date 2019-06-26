namespace Invader
{
    partial class HybridShellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HybridShellForm));
            this.txtPvtkey = new System.Windows.Forms.TextBox();
            this.lblenckey = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtlport = new System.Windows.Forms.TextBox();
            this.btnlblLport = new System.Windows.Forms.Label();
            this.txtlhost = new System.Windows.Forms.TextBox();
            this.btnlblLhost = new System.Windows.Forms.Label();
            this.txtPubKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowfile = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.txtagentname = new System.Windows.Forms.TextBox();
            this.btnlblAgent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPvtkey
            // 
            this.txtPvtkey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPvtkey.Location = new System.Drawing.Point(30, 124);
            this.txtPvtkey.Multiline = true;
            this.txtPvtkey.Name = "txtPvtkey";
            this.txtPvtkey.Size = new System.Drawing.Size(256, 186);
            this.txtPvtkey.TabIndex = 2;
            // 
            // lblenckey
            // 
            this.lblenckey.BackColor = System.Drawing.Color.Transparent;
            this.lblenckey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblenckey.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenckey.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblenckey.Location = new System.Drawing.Point(19, 104);
            this.lblenckey.Name = "lblenckey";
            this.lblenckey.Size = new System.Drawing.Size(95, 21);
            this.lblenckey.TabIndex = 25;
            this.lblenckey.Text = "Client Pvt Key";
            this.lblenckey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeading.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHeading.Location = new System.Drawing.Point(97, 3);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(377, 30);
            this.lblHeading.TabIndex = 27;
            this.lblHeading.Text = "Hybrid Reverse Shell";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnclose.Location = new System.Drawing.Point(555, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 26);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtlport
            // 
            this.txtlport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlport.Location = new System.Drawing.Point(301, 68);
            this.txtlport.Name = "txtlport";
            this.txtlport.Size = new System.Drawing.Size(254, 23);
            this.txtlport.TabIndex = 1;
            // 
            // btnlblLport
            // 
            this.btnlblLport.BackColor = System.Drawing.Color.Transparent;
            this.btnlblLport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlblLport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlblLport.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlblLport.Location = new System.Drawing.Point(291, 46);
            this.btnlblLport.Name = "btnlblLport";
            this.btnlblLport.Size = new System.Drawing.Size(73, 27);
            this.btnlblLport.TabIndex = 31;
            this.btnlblLport.Text = "SET LPORT";
            this.btnlblLport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtlhost
            // 
            this.txtlhost.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlhost.Location = new System.Drawing.Point(30, 68);
            this.txtlhost.Name = "txtlhost";
            this.txtlhost.Size = new System.Drawing.Size(257, 23);
            this.txtlhost.TabIndex = 0;
            // 
            // btnlblLhost
            // 
            this.btnlblLhost.BackColor = System.Drawing.Color.Transparent;
            this.btnlblLhost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlblLhost.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlblLhost.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlblLhost.Location = new System.Drawing.Point(22, 42);
            this.btnlblLhost.Name = "btnlblLhost";
            this.btnlblLhost.Size = new System.Drawing.Size(73, 34);
            this.btnlblLhost.TabIndex = 29;
            this.btnlblLhost.Text = "SET LHOST";
            this.btnlblLhost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPubKey
            // 
            this.txtPubKey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPubKey.Location = new System.Drawing.Point(300, 124);
            this.txtPubKey.Multiline = true;
            this.txtPubKey.Name = "txtPubKey";
            this.txtPubKey.Size = new System.Drawing.Size(255, 186);
            this.txtPubKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(292, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Client Pub Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowfile
            // 
            this.btnShowfile.BackColor = System.Drawing.Color.Transparent;
            this.btnShowfile.Enabled = false;
            this.btnShowfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowfile.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowfile.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShowfile.Location = new System.Drawing.Point(301, 370);
            this.btnShowfile.Name = "btnShowfile";
            this.btnShowfile.Size = new System.Drawing.Size(256, 30);
            this.btnShowfile.TabIndex = 6;
            this.btnShowfile.Text = "Show Files";
            this.btnShowfile.UseVisualStyleBackColor = false;
            this.btnShowfile.Click += new System.EventHandler(this.btnShowfile_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuild.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuild.Location = new System.Drawing.Point(30, 370);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(256, 30);
            this.btnBuild.TabIndex = 5;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // txtagentname
            // 
            this.txtagentname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagentname.Location = new System.Drawing.Point(30, 337);
            this.txtagentname.Name = "txtagentname";
            this.txtagentname.Size = new System.Drawing.Size(526, 23);
            this.txtagentname.TabIndex = 4;
            // 
            // btnlblAgent
            // 
            this.btnlblAgent.BackColor = System.Drawing.Color.Transparent;
            this.btnlblAgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlblAgent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlblAgent.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlblAgent.Location = new System.Drawing.Point(27, 313);
            this.btnlblAgent.Name = "btnlblAgent";
            this.btnlblAgent.Size = new System.Drawing.Size(87, 21);
            this.btnlblAgent.TabIndex = 37;
            this.btnlblAgent.Text = "Agent Save As";
            this.btnlblAgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Invader.Properties.Resources.bg6;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 427);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // HybridShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 427);
            this.Controls.Add(this.btnShowfile);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.txtagentname);
            this.Controls.Add(this.btnlblAgent);
            this.Controls.Add(this.txtPubKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlport);
            this.Controls.Add(this.btnlblLport);
            this.Controls.Add(this.txtlhost);
            this.Controls.Add(this.btnlblLhost);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtPvtkey);
            this.Controls.Add(this.lblenckey);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HybridShellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HybridShellForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPvtkey;
        private System.Windows.Forms.Label lblenckey;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtlport;
        private System.Windows.Forms.Label btnlblLport;
        private System.Windows.Forms.TextBox txtlhost;
        private System.Windows.Forms.Label btnlblLhost;
        private System.Windows.Forms.TextBox txtPubKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowfile;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TextBox txtagentname;
        private System.Windows.Forms.Label btnlblAgent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}