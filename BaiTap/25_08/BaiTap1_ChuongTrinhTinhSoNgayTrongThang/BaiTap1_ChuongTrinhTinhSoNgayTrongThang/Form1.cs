using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1_ChuongTrinhTinhSoNgayTrongThang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

               
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int month))
            {
                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Vui long nhap tu thang 1 toi thang 12");
                    textBox1.Clear();

                    return;
                }
            }
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox2.Text.Length > 0 && textBox2.Text.Length != 4)
        //    {
        //        MessageBox.Show("Nam phai gom 4 chu so!");
        //        textBox2.Clear();
        //    }

        //}
        private void btnCaculator_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int month) && int.TryParse(textBox2.Text, out int year))
            {
                if(year < 1000) { 
                    MessageBox.Show("Nam phai gom 4 chu so!");
                    textBox2.Clear();
                    return;
                }
                int daysInMonth = DateTime.DaysInMonth(year, month);
                LabelResult.Text = $"Thang {month} nam {year} co {daysInMonth} ngay.";
            }
            else
            {
                MessageBox.Show("Vui long nhap thang va nam hop le!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LabelResult.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
