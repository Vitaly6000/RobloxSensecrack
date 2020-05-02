using EasyExploits;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloxSense_v1
{
    // Token: 0x02000004 RID: 4
    public partial class Form3 : Form
    {
        // Token: 0x06000037 RID: 55 RVA: 0x0000547A File Offset: 0x0000547A
        public Form3()
        {
            InitializeComponent();
        }

        // Token: 0x06000038 RID: 56 RVA: 0x000054A0 File Offset: 0x000054A0
        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = e.Button != MouseButtons.Left;
            if (flag)
            {
                MouseHook = e.Location;
            }
            base.Location = new Point((Size)base.Location - (Size)MouseHook + (Size)e.Location);
        }

        // Token: 0x06000039 RID: 57 RVA: 0x00005508 File Offset: 0x00005508
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = richTextBox1.Text != "";
            if (flag)
            {
                api.ExecuteScript("print('Script Executed to game!')\n" + richTextBox1.Text);
            }
        }

        // Token: 0x0600003A RID: 58 RVA: 0x00005552 File Offset: 0x00005552
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        // Token: 0x0600003B RID: 59 RVA: 0x00005568 File Offset: 0x00005568
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
            };
            bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
            if (flag)
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                string fileName = openFileDialog.FileName;
                string text = File.ReadAllText(fileName);
                bool flag2 = Directory.Exists(fileName);
                bool flag3 = text.Contains("\t");
                if (flag3)
                {
                    char newChar = ' ';
                    text.Replace('\n', newChar);
                }
                richTextBox1.Text = "--File Openned at BloxSense\n\n" + text;
            }
        }

        // Token: 0x0600003C RID: 60 RVA: 0x000055F4 File Offset: 0x000055F4
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
            };
            bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
            if (flag)
            {
                saveFileDialog.InitialDirectory = Application.StartupPath;
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, richTextBox1.Text);
            }
        }

        // Token: 0x0600003D RID: 61 RVA: 0x00005648 File Offset: 0x00005648
        private void button5_Click(object sender, EventArgs e)
        {
            string pattern = "^https://pastebin.com/........$";
            string pattern2 = "^https://pastebin.com/raw/........$";
            string pattern3 = "^........$";
            string pattern4 = "^pastebin.com/raw/........$";
            string pattern5 = "^pastebin.com/........$";
            bool flag = Regex.IsMatch(richTextBox1.Text, pattern);
            if (flag)
            {
                string arg = richTextBox1.Text.Substring(21, 8);
                string address = string.Format("https://pastebin.com/raw/{0}", arg);
                WebClient webClient = new WebClient();
                StreamReader streamReader = new StreamReader(webClient.OpenRead(address));
                richTextBox1.Text = streamReader.ReadToEnd();
                streamReader.Dispose();
                webClient.Dispose();
            }
            bool flag2 = Regex.IsMatch(richTextBox1.Text, pattern2);
            if (flag2)
            {
                WebClient webClient2 = new WebClient();
                StreamReader streamReader2 = new StreamReader(webClient2.OpenRead(richTextBox1.Text));
                richTextBox1.Text = streamReader2.ReadToEnd();
                streamReader2.Dispose();
                webClient2.Dispose();
            }
            bool flag3 = Regex.IsMatch(richTextBox1.Text, pattern3);
            if (flag3)
            {
                WebClient webClient3 = new WebClient();
                StreamReader streamReader3 = new StreamReader(webClient3.OpenRead(string.Format("https://pastebin.com/raw/{0}", richTextBox1.Text)));
                richTextBox1.Text = streamReader3.ReadToEnd();
                streamReader3.Dispose();
                webClient3.Dispose();
            }
            bool flag4 = Regex.IsMatch(richTextBox1.Text, pattern4);
            if (flag4)
            {
                WebClient webClient4 = new WebClient();
                StreamReader streamReader4 = new StreamReader(webClient4.OpenRead(string.Format("https://{0}", richTextBox1.Text)));
                richTextBox1.Text = streamReader4.ReadToEnd();
                streamReader4.Dispose();
                webClient4.Dispose();
            }
            bool flag5 = Regex.IsMatch(richTextBox1.Text, pattern5);
            if (flag5)
            {
                WebClient webClient5 = new WebClient();
                string arg2 = richTextBox1.Text.Replace("pastebin.com/", "");
                StreamReader streamReader5 = new StreamReader(webClient5.OpenRead(string.Format("https://pastebin.com/raw/{0}", arg2)));
                richTextBox1.Text = streamReader5.ReadToEnd();
                streamReader5.Dispose();
                webClient5.Dispose();
            }
        }

        // Token: 0x0600003E RID: 62 RVA: 0x00005890 File Offset: 0x00005890
        private void timer1_Tick(object sender, EventArgs e)
        {
            string pattern = "^https://pastebin.com/........$";
            string pattern2 = "^https://pastebin.com/raw/........$";
            string pattern3 = "^........$";
            string pattern4 = "^pastebin.com/raw/........$";
            string pattern5 = "^pastebin.com/........$";
            bool flag = Regex.IsMatch(richTextBox1.Text, pattern) || Regex.IsMatch(richTextBox1.Text, pattern2) || Regex.IsMatch(richTextBox1.Text, pattern3) || Regex.IsMatch(richTextBox1.Text, pattern4) || Regex.IsMatch(richTextBox1.Text, pattern5);
            if (flag)
            {
                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        // Token: 0x0400003C RID: 60
        private Module api = new Module();

        // Token: 0x0400003D RID: 61
        private Point MouseHook;
    }
}
