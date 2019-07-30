using System;
using System.Linq;
using System.Windows.Forms;
using LuckDog.Spiders;

namespace LuckDog.Forms
{
    public partial class DrawForm : Form
    {
        Random unityRandom = new Random();

        public DrawForm()
        {
            this.Icon = AppResource.DrawIcon;
            this.InitializeComponent();
        }

        private void DrawForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            this.DrawButton.Left = (this.Width - this.DrawButton.Width) / 2;
            this.DrawButton.Top = (int)(this.Height * 0.7);

            this.NameLabel.Left = (this.Width - this.NameLabel.Width) / 2;
            this.NameLabel.Top = (int)(this.Height * 0.2);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (!this.UnityTimer.Enabled)
            {
                this.UnityTimer.Start();
                this.DrawButton.Text = "停止";
            }
            else
            {
                this.UnityTimer.Stop();
                this.DrawButton.Text = "开始";
            }
        }

        private void UnityTimer_Tick(object sender, EventArgs e)
        {
            this.NameLabel.Text = this.unityRandom.Next(0, 1000).ToString();
        }
    }
}
