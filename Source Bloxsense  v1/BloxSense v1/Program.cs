using System;
using System.Windows.Forms;

namespace BloxSense_v1
{
    // Token: 0x02000005 RID: 5
    internal static class Program
    {
        // Token: 0x06000041 RID: 65 RVA: 0x00005F80 File Offset: 0x00005F80
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
