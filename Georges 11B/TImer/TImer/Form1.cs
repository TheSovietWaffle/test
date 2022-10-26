using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TImer
{
    public partial class Form1 : Form
    {
        private Stopwatch sw = new Stopwatch();
        bool isStarted = false;
        public Form1()
        {
            InitializeComponent();
            sw.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!sw.IsRunning)
            {
                sw.Start();
                button1.Text = "Stop";
                //isStarted = true;
            }
            else
            {
                sw.Stop();
                button1.Text = "Start";
            }

            label1.Text = sw.Elapsed.ToString("mm\\:ss\\.ff");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
