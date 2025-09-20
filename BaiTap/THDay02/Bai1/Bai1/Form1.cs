using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Tin học đại cương")
            {
                textBox1.Text = "2";
            }
            else if(comboBox1.Text =="Giải tích F1")
            {
                textBox1.Text = "3";
            }
            else if(comboBox1.Text == "Tiếng Anh A0")
            {
                textBox1.Text = "3";
            }
            else if(comboBox1.Text == "Vật lý F1")
            {
                textBox1.Text = "3";
            }
            else if(comboBox1.Text == "Triết học Mác - Lênin")
            {
                textBox1.Text = "2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm!", "Thông báo");
            }
            else
            {
                double diem = double.Parse(textBox2.Text);
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    listBox1.Items.Add(comboBox1.Text + " - " + textBox1.Text + " - " + textBox2.Text);
                }

            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng, nhập thêm môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double tongSoDiem = 0;
                int tongSoTinChi = 0;
                for(int i = 0; i < listBox1.Items.Count; i++)
                {
                    string[] parts = listBox1.Items[i].ToString().Split(new string[] { " - " }, StringSplitOptions.None);
                    int soTinChi = int.Parse(parts[1]);
                    double diem = double.Parse(parts[2]);
                    tongSoDiem += (double)soTinChi * diem;
                    tongSoTinChi += soTinChi;
                }
                textBox3.Text = tongSoTinChi.ToString("0");
                textBox4.Text = tongSoDiem.ToString("0.0");
                double diemTrungBinh = tongSoDiem / tongSoTinChi;
                textBox5.Text = diemTrungBinh.ToString("0.0");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                button3.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.D)
            {
                button1.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.T)
            {
                button2.PerformClick();
            }
        }
    }
}
