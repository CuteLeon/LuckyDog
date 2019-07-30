using System.Collections.Generic;

namespace LuckDog.Models
{
    /// <summary>
    /// 英雄
    /// </summary>
    public class Hero
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 默认皮肤
        /// </summary>
        public Skin DefaultSkin { get; set; }

        /// <summary>
        /// 皮肤列表
        /// </summary>
        public List<Skin> Skins { get; set; } = new List<Skin>();
    }
}
