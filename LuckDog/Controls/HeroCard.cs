using System.Drawing;
using System.Windows.Forms;

namespace LuckDog.Controls
{
    public partial class HeroCard : Label
    {
        public HeroCard()
        {
            this.InitializeComponent();

            this.AutoEllipsis = true;
            this.BorderStyle = BorderStyle.None;
            this.Size = new Size(75, 95);
            this.Margin = new Padding(3, 3, 3, 3);

            this.BackColor = Color.FromArgb(22, 83, 125);

            this.Image = AppResource.Avatar;
            this.ImageAlign = ContentAlignment.TopCenter;

            this.Text = "英雄";
            this.Font = this.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.ForeColor = Color.DeepSkyBlue;
            this.TextAlign = ContentAlignment.BottomCenter;
        }

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }

        public new Image Image
        {
            get => base.Image;
            set
            {
                if (value == null)
                {
                    base.Image = AppResource.Avatar;
                }
                else
                {
                    base.Image = new Bitmap(value, AppResource.Avatar.Size);
                }
            }
        }
    }
}
