using System;
using System.Windows.Forms;

namespace Invader
{
    public partial class FlashForm : Form
    {
        public FlashForm()
        {
            InitializeComponent();
        }

        private void ListenerForm_Load(object sender, EventArgs e)
        {
             
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value %2 == 0)
            {
                lblInvader.Visible = false;
            } else if (progressBar.Value % 2 == 1)
            {
                lblInvader.Visible = true;

            }
            if (progressBar.Value == 30)
            {
                splashtimer.Stop();
                this.Close();
            }
        }

        private void ListenerForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(0, 0, this.Height, this.Height);
            this.Region = new System.Drawing.Region(shape);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
