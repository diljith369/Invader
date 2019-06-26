namespace Invader
{
    partial class FlashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashForm));
            this.lblInvader = new System.Windows.Forms.Label();
            this.splashtimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblInvader
            // 
            this.lblInvader.AutoSize = true;
            this.lblInvader.BackColor = System.Drawing.Color.Transparent;
            this.lblInvader.Font = new System.Drawing.Font("Goudy Stout", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblInvader.Location = new System.Drawing.Point(16, 100);
            this.lblInvader.Name = "lblInvader";
            this.lblInvader.Size = new System.Drawing.Size(190, 19);
            this.lblInvader.TabIndex = 2;
            this.lblInvader.Text = "The Invader";
            // 
            // splashtimer
            // 
            this.splashtimer.Enabled = true;
            this.splashtimer.Interval = 200;
            this.splashtimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(35, 152);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(142, 10);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // FlashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(218, 218);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblInvader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListenerForm";
            this.Load += new System.EventHandler(this.ListenerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ListenerForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvader;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer splashtimer;
    }
}