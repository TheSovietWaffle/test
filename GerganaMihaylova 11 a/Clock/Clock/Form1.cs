using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {

            labeltime.Text = DateTime.Now.ToString("HH:mm");
            labelsec.Text = DateTime.Now.ToString("ss");
            labeldate.Text = DateTime.Now.ToString("MMMM dd yyyy");
            labelday.Text = DateTime.Now.ToString("dddd");
            labelsec.Location = new Point(labeltime.Location.X + labeltime.Width, labelsec.Location.Y);
        }
        
    }
}
