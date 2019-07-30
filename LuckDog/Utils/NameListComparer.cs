using System;
using System.Collections.Generic;

namespace LuckDog.Utils
{
    public class NameListComparer : IComparer<string>
    {
        private Random random = new Random();

        public int Compare(string x, string y)
            => this.random.Next(-1, 2);
    }
}
