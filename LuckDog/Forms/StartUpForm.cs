using System;
using System.Windows.Forms;
using LuckDog.Controls;
using LuckDog.Managers;
using LuckDog.Spiders;

namespace LuckDog.Forms
{
    public partial class StartUpForm : Form
    {
        IPVPGameSpider gameSpider;
        SkinManager skinManager;

        public StartUpForm()
        {
            this.InitializeComponent();

            this.Icon = AppResource.DrawIcon;
            this.gameSpider = new QQPVPGameSpider();
            this.skinManager = new SkinManager(this.gameSpider);
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
                    heroCard.Image = await this.skinManager.ReadOrDownloadSmallSkin(hero.ID, hero.DefaultSkin.ID);

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
