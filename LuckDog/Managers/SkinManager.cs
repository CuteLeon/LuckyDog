using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using LuckDog.Spiders;
using LuckDog.Utils;

namespace LuckDog.Managers
{
    /// <summary>
    /// 皮肤管理器
    /// </summary>
    public class SkinManager
    {
        IPVPGameSpider gameSpider;

        public SkinManager(IPVPGameSpider gameSpider)
        {
            this.gameSpider = gameSpider;
        }

        public string GetSkinImagePath(string heroId, string skinId)
            => Path.Combine(ConfigHelper.ResourceDirectory, $"{heroId}_{skinId}.jpg");

        public async Task<Image> ReadOrDownloadSmallSkin(string heroId, string skinId)
        {
            try
            {
                string path = this.GetSkinImagePath(heroId, skinId);
                if (File.Exists(path))
                {
                    return Image.FromFile(path);
                }
                else
                {
                    var image = await this.gameSpider.GetSmallSkin(heroId, skinId);
                    image.Save(path);
                    return image;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"读取或下载皮肤小图异常：{ex.Message}");
                return AppResource.Avatar;
            }
        }
    }
}
