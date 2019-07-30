namespace LuckDog.Models
{
    /// <summary>
    /// 皮肤
    /// </summary>
    public class Skin
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
        /// 英雄
        /// </summary>
        public Hero Hero { get; set; }

        public override string ToString()
            => $"{this.Hero?.Name} ({this.ID}) [{this.Name}]";
    }
}
