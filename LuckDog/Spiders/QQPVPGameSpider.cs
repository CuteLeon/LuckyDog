using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LuckDog.Models;

namespace LuckDog.Spiders
{
    /// <summary>
    /// 王者荣耀爬虫
    /// </summary>
    public class QQPVPGameSpider : IPVPGameSpider
    {
        protected HttpClient httpClient = new HttpClient();

        protected Regex HeroRegex = new Regex(
            "\\{\\\"ename\\\"\\:(?<ID>\\d*),\\\"cname\\\"\\:\\\"(?<Name>.*?)\\\",\\\"title\\\"\\:\\\"(?<Title>.*?)\\\",.*?,\\\"skin_name\\\"\\:\\\"(?<Skins>.*?)\\\"\\}",
             RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

        public QQPVPGameSpider()
        {
        }

        /// <summary>
        /// 获取英雄列表
        /// </summary>
        /// <returns></returns>
        public async Task<List<Hero>> GetHeroList()
        {
            try
            {
                string response = await this.httpClient.GetStringAsync(@"https://pvp.qq.com/web201605/js/herolist.json");
                var matchs = this.HeroRegex.Matches(response);
                var heros = matchs.Cast<Match>()
                    .Where(match => match.Success)
                    .Select(match => this.MatchToHero(match))
                    .ToList();
                return heros;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取英雄列表失败：{ex.Message}");
                return default;
            }
        }

        protected virtual Hero MatchToHero(Match match)
        {
            var hero = new Hero();
            hero.ID = match.Groups["ID"].Value;
            hero.Name = match.Groups["Name"].Value;
            hero.DefaultSkin = new Skin()
            {
                ID = "1",
                Name = match.Groups["Title"].Value,
                Hero = hero,
            };
            hero.Skins = match.Groups["Skins"].Value
                .Split(new[] { '|' })
                .Select((skin, index) => new Skin() { Hero = hero, ID = (index + 1).ToString(), Name = skin })
                .ToList();

            return hero;
        }
    }
}
