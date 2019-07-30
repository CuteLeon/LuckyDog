using System.IO;

namespace LuckDog.Utils
{
    /// <summary>
    /// 配置助手
    /// </summary>
    public static class ConfigHelper
    {
        public static readonly string ResourceDirectory = "Resources";

        static ConfigHelper()
        {
            if (!Directory.Exists(ResourceDirectory))
            {
                try
                {
                    Directory.CreateDirectory(ResourceDirectory);
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
