using System;
using System.Windows.Forms;
using LuckDog.Controls;
using LuckDog.Spiders;

namespace LuckDog.Forms
{
    public partial class StartUpForm : Form
    {
        IPVPGameSpider gameSpider = new QQPVPGameSpider();

        public StartUpForm()
        {
            this.InitializeComponent();

            this.Icon = AppResource.DrawIcon;
        }

        private async void StartUpForm_Shown(object sender, System.EventArgs e)
        {
            Application.DoEvents();

            var heros = await this.gameSpider.GetHeroList();
            if (heros?.Count == 0)
            {
                Console.WriteLine($"获取英雄列表失败。");
                return;
            }

            this.HerosPanel.Show();
            heros.ForEach(async hero =>
            {
                try
                {
                    var heroCard = new HeroCard();
                    heroCard.Text = hero.Name;
                    heroCard.Image = await this.gameSpider.GetSmallSkin(hero.ID, hero.DefaultSkin.ID);

                    this.HerosPanel.Controls.Add(heroCard);
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"显示英雄列表遇到异常：{ex.Message}");
                }
            });
        }
    }
}
