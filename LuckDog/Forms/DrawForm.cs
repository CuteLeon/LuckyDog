using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LuckDog.Forms
{
    public partial class DrawForm : Form
    {
        Random unityRandom = new Random();

        public List<string> NameList;

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
            this.NameLabel.Top = (int)(this.Height * 0.4);

            if (this.NameList.Count == 0)
            {
                MessageBox.Show("抽奖名单长度为零！", "无法抽奖", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
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
            int index = this.unityRandom.Next(0, this.NameList.Count);
            this.NameLabel.Text = this.NameList[index];
        }
    }
}
