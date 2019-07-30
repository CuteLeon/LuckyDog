using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using LuckDog.Models;
using LuckDog.Spiders;
using LuckDog.Utils;

namespace LuckDog.Managers
{
    /// <summary>
    /// 皮肤管理器
    /// </summary>
    public class SkinManager
    {
        public static Skin CurrentSkin = null;

        IPVPGameSpider gameSpider;

        public SkinManager(IPVPGameSpider gameSpider)
        {
            this.gameSpider = gameSpider;
        }

        public string GetSmallSkinImagePath(string heroId, string skinId)
            => Path.Combine(ConfigHelper.ResourceDirectory, $"small_{heroId}_{skinId}.jpg");

        public string GetBigSkinImagePath(string heroId, string skinId)
            => Path.Combine(ConfigHelper.ResourceDirectory, $"big_{heroId}_{skinId}.jpg");

        public async Task<Image> ReadOrDownloadSmallSkin(string heroId, string skinId)
        {
            try
            {
                string path = this.GetSmallSkinImagePath(heroId, skinId);
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

        public async Task<Image> ReadOrDownloadBigSkin(string heroId, string skinId)
        {
            try
            {
                string path = this.GetBigSkinImagePath(heroId, skinId);
                if (File.Exists(path))
                {
                    return Image.FromFile(path);
                }
                else
                {
                    var image = await this.gameSpider.GetBigSkin(heroId, skinId);
                    image.Save(path);
                    return image;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"读取或下载皮肤大图异常：{ex.Message}");
                return AppResource.Background;
            }
        }
    }
}
