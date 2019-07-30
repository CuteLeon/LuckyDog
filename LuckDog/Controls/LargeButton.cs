using System.Drawing;
using System.Windows.Forms;

namespace LuckDog.Controls
{
    public partial class LargeButton : Label
    {
        public LargeButton()
        {
            this.InitializeComponent();

            this.AutoEllipsis = true;
            this.BorderStyle = BorderStyle.None;
            this.Size = new Size(236, 128);
            this.BackColor = Color.DimGray;

            this.Image = AppResource.Button_0;
            this.ImageAlign = ContentAlignment.MiddleCenter;

            this.Font = this.Font = new Font("微软雅黑", 25, FontStyle.Bold, GraphicsUnit.Point, 134);
            this.ForeColor = Color.White;
            this.TextAlign = ContentAlignment.MiddleCenter;
        }

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }

        private void LargeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.Image = AppResource.Button_2;
        }

        private void LargeButton_MouseLeave(object sender, System.EventArgs e)
        {
            this.Image = AppResource.Button_0;
        }

        private void LargeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Image = AppResource.Button_1;
        }

        private void LargeButton_MouseEnter(object sender, System.EventArgs e)
        {
            this.Image = AppResource.Button_1;
        }
    }
}
