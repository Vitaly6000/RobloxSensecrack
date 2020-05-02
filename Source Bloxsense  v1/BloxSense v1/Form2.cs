using System;
using System.Drawing;
using System.Windows.Forms;

namespace BloxSense_v1
{
    // Token: 0x02000003 RID: 3
    public partial class Form2 : Form
    {
        // Token: 0x06000030 RID: 48 RVA: 0x0000505C File Offset: 0x0000505C
        public Form2()
        {
            InitializeComponent();
        }

        // Token: 0x06000031 RID: 49 RVA: 0x0000507B File Offset: 0x0000507B
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(string.Format("BloxSense got cracked <3"));
                passed = true;
                base.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error - {0}", ex.Message));
            }
        }

        // Token: 0x06000032 RID: 50 RVA: 0x00005080 File Offset: 0x00005080
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = e.Button != MouseButtons.Left;
            if (flag)
            {
                MouseHook = e.Location;
            }
            base.Location = new Point((Size)base.Location - (Size)MouseHook + (Size)e.Location);
        }

        // Token: 0x06000033 RID: 51 RVA: 0x000050E8 File Offset: 0x000050E8
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Token: 0x06000034 RID: 52 RVA: 0x000051E4 File Offset: 0x000051E4
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool flag = !passed;
            if (flag)
            {
                Application.Exit();
            }
        }

        // Token: 0x04000037 RID: 55
        private bool passed = true;

        // Token: 0x04000038 RID: 56
        private Point MouseHook;
    }
}
