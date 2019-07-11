using EvilLimiter.Windows.Common;
using EvilLimiter.Windows.Forms;
using System;
using System.Windows.Forms;

namespace EvilLimiter.Windows
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Config.Read();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInterface());
        }
    }
}
