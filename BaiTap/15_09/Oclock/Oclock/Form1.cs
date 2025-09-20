using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oclock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer timer; // biến toàn cục
        int minutes;
        int seconds;

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out minutes) &&
                int.TryParse(textBox2.Text, out seconds))
            {
                timer = new Timer();
                timer.Interval = 1000; // 1 second
                timer.Tick += dislayTime_Tick; // gắn event Tick
                timer.Start();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }


        }

        private void dislayTime_Tick(object sender, EventArgs e)
        {
            // Code to update the display with the current time
            int minutes = int.Parse(textBox1.Text);
            int seconds = int.Parse(textBox2.Text);
            
            if (seconds == 0)
            {
                if (minutes == 0)
                {
                    MessageBox.Show("Time's up!");
                }
                else
                {
                    minutes--;
                    seconds = 59;
                }
            }
            else
            {
                seconds--;
            }
            textBox1.Text = minutes.ToString();
            textBox2.Text = seconds.ToString();
        }
    }
}
