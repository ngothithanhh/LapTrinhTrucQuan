using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Coca cola");
            comboBox1.Items.Add("Pepsi");
            comboBox1.Items.Add("Seven up");

            for(int i = 1; i <= 10; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            comboBox2.SelectedIndex = -1;


        }

       

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Text = "200";
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox2.Text = "100";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTien();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTien();
        }


        private void tinhTien()
        {
            string doUong = (string)comboBox1.SelectedItem;
            int soLuong = 0;
            if (comboBox2.SelectedIndex != -1)
            {
                soLuong = int.Parse(comboBox2.SelectedItem.ToString());
            }
            



                switch (doUong)
                {
                    case "Coca cola":
                        textBox3.Text = (soLuong * 0.5).ToString();
                        break;
                    case "Pepsi":
                        textBox3.Text = (soLuong * 0.8).ToString();
                        break;
                    case "Seven up":
                        textBox3.Text = (soLuong * 1.0).ToString();
                        break;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            if (item == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            else
            {
                if(radioButton1.Checked == true)
                {
                    item += " | " + radioButton1.Text;
                }
                else if(radioButton2.Checked == true)
                {
                    item += " | " + radioButton2.Text;
                }
                item = item + " | " + textBox2.Text + " | Đồ uống " + textBox3.Text + " | Tổng " +tinhTong().ToString() ;
                listBox1.Items.Add(item);
            }

        }

        private double tinhTong()
        {
            
            double tienDoUong = double.Parse(textBox3.Text);
            double tienThue = double.Parse(textBox2.Text);
            double tong = tienDoUong + tienThue;
            return tong;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                this.button3.PerformClick();
            }

            if(e.Alt && e.KeyCode == Keys.M)
            {
                this.button2.PerformClick();
            }
        }
    }
}
