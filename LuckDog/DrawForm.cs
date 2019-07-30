using System;
using System.Windows.Forms;
using LuckDog.Spiders;

namespace LuckDog
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            this.InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            IPVPGameSpider gameSpider = new QQPVPGameSpider();
            var heros = await gameSpider.GetHeroList();
        }
    }
}
