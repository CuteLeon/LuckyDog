using System.Collections.Generic;
using System.IO;
using System.Linq;
using LuckDog.Utils;

namespace LuckDog.Managers
{
    public class PlayerManager
    {
        public List<string> NameList { get; } = new List<string>();

        public void LoadFromTextFile(string path)
        {
            if (File.Exists(path))
            {
                this.NameList.AddRange(
                    File.ReadAllLines(path)
                    .Distinct()
                    .OrderBy(name => name, new NameListComparer()));
            }
        }
    }
}
