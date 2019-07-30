using System.Collections.Generic;
using System.Drawing;
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

        /// <summary>
        /// 获取皮肤背景大图
        /// </summary>
        /// <param name="heroId"></param>
        /// <param name="skinId"></param>
        /// <returns></returns>
        Task<Image> GetBigSkin(string heroId, string skinId);

        /// <summary>
        /// 获取皮肤背景小图
        /// </summary>
        /// <param name="heroId"></param>
        /// <param name="skinId"></param>
        /// <returns></returns>
        Task<Image> GetSmallSkin(string heroId, string skinId);
    }
}
