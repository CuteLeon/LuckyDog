using System;
using System.Threading;
using System.Windows.Forms;
using LuckDog.Forms;
using LuckDog.Utils;

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
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            _ = ConfigHelper.ResourceDirectory;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartUpForm());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
            => MessageBox.Show($"当前域未捕捉异常：{(e.ExceptionObject as Exception).Message}", "人家不擅长战斗呢", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
            => MessageBox.Show($"应用程序未捕捉异常：{e.Exception.Message}", "人生，乏味啊", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
