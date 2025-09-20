using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3_TinhToanTrenDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        int[] arr;
        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int n))
            {
                arr = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(100);
                }

                label2.Text = "Dãy số: ";
                for(int i = 0; i < n; i++)
                {
                    label2.Text += arr[i] + " ";
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (arr != null)
            {
                foreach (int i in arr) 
                {
                    sum += i;
                }

            }

            label3.Text = "Tổng dãy số là: " + sum;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            label4.Text = "Dãy số sắp xếp giảm dần là: ";
            foreach (int i in arr)
            {
                label4.Text += i + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
