using System.Collections.Generic;
using System.Threading.Tasks;
using LuckDog.Models;

namespace LuckDog.Spiders
{
    /// <summary>
    /// 王者荣耀爬虫接口
    /// </summary>
    public interface IPVPGameSpider
    {
        /// <summary>
        /// 获取英雄列表
        /// </summary>
        /// <returns></returns>
        Task<List<Hero>> GetHeroList();
    }
}
