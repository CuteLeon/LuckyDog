using System;
using System.Windows.Forms;
using LuckDog.Controls;
using LuckDog.Managers;
using LuckDog.Models;
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

        private async void StartUpForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            this.DrawButton.Left = (this.Width - this.DrawButton.Width) / 2;
            this.DrawButton.Top = (int)(this.Height * 0.7);

            try
            {
                var heros = await this.gameSpider.GetHeroList();
                if (heros == null || heros.Count == 0)
                {
                    Console.WriteLine($"获取英雄列表失败。");
                    return;
                }

                this.HerosPanel.Show();
                this.SkinPanel.Show();

                heros.ForEach(async hero =>
                {
                    var heroCard = new HeroCard();
                    heroCard.Text = hero.Name;
                    heroCard.Image = await this.skinManager.ReadOrDownloadSmallSkin(hero.ID, hero.DefaultSkin.ID);
                    heroCard.Click += this.HeroCard_Click;
                    heroCard.Tag = hero;

                    this.HerosPanel.Controls.Add(heroCard);
                    Application.DoEvents();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"显示英雄列表遇到异常：{ex.Message}");
            }
        }

        private async void HeroCard_Click(object sender, EventArgs e)
        {
            this.SkinPanel.Controls.Clear();

            var hero = (sender as Control).Tag as Hero;

            hero.Skins.ForEach(async skin =>
            {
                var heroCard = new HeroCard();
                heroCard.Text = skin.Name;
                heroCard.Image = await this.skinManager.ReadOrDownloadSmallSkin(hero.ID, skin.ID);
                heroCard.Click += this.SkinCard_Click;
                heroCard.Tag = skin;

                this.SkinPanel.Controls.Add(heroCard);
                this.SkinPanel.Refresh();
                Application.DoEvents();
            });

            this.BackgroundImage = await this.skinManager.ReadOrDownloadBigSkin(hero.ID, hero.DefaultSkin.ID);
        }

        private async void SkinCard_Click(object sender, EventArgs e)
        {
            var skin = (sender as Control).Tag as Skin;

            SkinManager.CurrentSkin = skin;
            this.BackgroundImage = await this.skinManager.ReadOrDownloadBigSkin(skin.Hero.ID, skin.ID);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            using (var drawForm = new DrawForm()
            {
                BackgroundImage = this.BackgroundImage,
                BackgroundImageLayout = ImageLayout.Stretch,
            })
            {
                drawForm.ShowDialog(this);
            }
        }
    }
}
