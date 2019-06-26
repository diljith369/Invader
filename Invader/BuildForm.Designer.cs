namespace Invader
{
    partial class BuildForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildForm));
            this.btnBuild = new System.Windows.Forms.Button();
            this.txtagentname = new System.Windows.Forms.TextBox();
            this.btnlblAgent = new System.Windows.Forms.Label();
            this.txtlport = new System.Windows.Forms.TextBox();
            this.btnlblLport = new System.Windows.Forms.Label();
            this.txtlhost = new System.Windows.Forms.TextBox();
            this.btnlblLhost = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnShowfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuild.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuild.Location = new System.Drawing.Point(29, 217);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(117, 30);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // txtagentname
            // 
            this.txtagentname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagentname.Location = new System.Drawing.Point(29, 178);
            this.txtagentname.Name = "txtagentname";
            this.txtagentname.Size = new System.Drawing.Size(247, 23);
            this.txtagentname.TabIndex = 2;
            // 
            // btnlblAgent
            // 
            this.btnlblAgent.BackColor = System.Drawing.Color.Transparent;
            this.btnlblAgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlblAgent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlblAgent.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlblAgent.Location = new System.Drawing.Point(25, 158);
            this.btnlblAgent.Name = "btnlblAgent";
            this.btnlblAgent.Size = new System.Drawing.Size(87, 21);
            this.btnlblAgent.TabIndex = 17;
            this.btnlblAgent.Text = "Agent Save As";
            this.btnlblAgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtlport
            // 
            this.txtlport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlport.Location = new System.Drawing.Point(29, 121);
            this.txtlport.Name = "txtlport";
            this.txtlport.Size = new System.Drawing.Size(247, 23);
            this.txtlport.TabIndex = 1;
            // 
            // btnlblLport
            // 
            this.btnlblLport.BackColor = System.Drawing.Color.Transparent;
            this.btnlblLport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlblLport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlblLport.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlblLport.Location = new System.Drawing.Point(21, 99);
            this.btnlblLport.Name = "btnlblLport";
            this.btnlblLport.Size = new System.Drawing.Size(73, 27);
            this.btnlblLport.TabIndex = 15;
            this.btnlblLport.Text = "SET LPORT";
            this.btnlblLport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtlhost
            // 
            this.txtlhost.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlhost.Location = new System.Drawing.Point(29, 74);
            this.txtlhost.Name = "txtlhost";
            this.txtlhost.Size = new System.Drawing.Size(247, 23);
            this.txtlhost.TabIndex = 0;
            // 
            // btnlblLhost
            // 
            this.btnlblLhost.BackColor = System.Drawing.Color.Transparent;
            this.btnlblLhost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlblLhost.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlblLhost.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlblLhost.Location = new System.Drawing.Point(20, 48);
            this.btnlblLhost.Name = "btnlblLhost";
            this.btnlblLhost.Size = new System.Drawing.Size(73, 34);
            this.btnlblLhost.TabIndex = 13;
            this.btnlblLhost.Text = "SET LHOST";
            this.btnlblLhost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnclose.Location = new System.Drawing.Point(272, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(29, 30);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 273);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeading.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHeading.Location = new System.Drawing.Point(29, 6);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(237, 30);
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
            this.btnShowfile.Location = new System.Drawing.Point(160, 217);
            this.btnShowfile.Name = "btnShowfile";
            this.btnShowfile.Size = new System.Drawing.Size(116, 30);
            this.btnShowfile.TabIndex = 4;
            this.btnShowfile.Text = "Show File";
            this.btnShowfile.UseVisualStyleBackColor = false;
            this.btnShowfile.Click += new System.EventHandler(this.btnShowFile_Click);
            // 
            // BuildForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 273);
            this.Controls.Add(this.btnShowfile);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.txtagentname);
            this.Controls.Add(this.btnlblAgent);
            this.Controls.Add(this.txtlport);
            this.Controls.Add(this.btnlblLport);
            this.Controls.Add(this.txtlhost);
            this.Controls.Add(this.btnlblLhost);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.BuildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TextBox txtagentname;
        private System.Windows.Forms.Label btnlblAgent;
        private System.Windows.Forms.TextBox txtlport;
        private System.Windows.Forms.Label btnlblLport;
        private System.Windows.Forms.TextBox txtlhost;
        private System.Windows.Forms.Label btnlblLhost;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnShowfile;
    }
}
