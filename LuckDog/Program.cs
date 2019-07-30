using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;

namespace LuckDog
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var heroList = new WebClient().DownloadString(@"https://pvp.qq.com/web201605/js/herolist.json");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DrawForm());
        }
    }
}
