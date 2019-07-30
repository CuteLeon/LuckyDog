using System;
using System.Linq;
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
            var hero = heros.First();
            var bigSkin = await gameSpider.GetBigSkin(hero.ID, hero.DefaultSkin.ID);
            var smallSkin = await gameSpider.GetSmallSkin(hero.ID, hero.Skins.Last().ID);
        }
    }
}
