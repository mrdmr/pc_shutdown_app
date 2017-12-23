using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Computer_shutdown_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://steemit.com/@sameddemir
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "C:\\Windows\\system32\\shutdown.exe";
            psi.Arguments = "-f -s -t 0";
            Process.Start(psi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hour, minute, second;
            hour = textBox1.Text;
            minute = textBox2.Text;
            second = textBox3.Text;


            if ((Convert.ToString(DateTime.Now.Hour)) == hour && (Convert.ToString(DateTime.Now.Minute) == minute) && (Convert.ToString(DateTime.Now.Second)) == second)
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "C:\\Windows\\system32\\shutdown.exe";
                psi.Arguments = "-f -s -t 0";
                Process.Start(psi);
            }
        }
    }
}
