using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void listBox1_Click_1(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            if(!listBox2.Items.Contains(selectedItem))
            {
                listBox2.Items.Add(selectedItem);
            }
            else
            {
                MessageBox.Show("Mặt hàng này đã tồn tại!.");
            }

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                var result = MessageBox.Show("Bạn muốn xóa"+ listBox2.SelectedItem+"không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            else
            {
                string name = textBox1.Text;
                string numberphone = textBox2.Text;
                if(numberphone.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.");
                    return;
                }
                else
                {
                    string temp = "";
                    foreach(var item in listBox2.Items)
                    {
                        temp +="-"+ item.ToString() + "\n";
                    }
                    string r = "";
                    if (radioButton1.Checked) r = radioButton1.Text;
                    else if (radioButton2.Checked) r = radioButton2.Text;
                    else if (radioButton3.Checked) r = radioButton3.Text;
                    string c = "";
                    if(checkBox1.Checked) c += checkBox1.Text;
                    if (checkBox2.Checked) c += ", "+checkBox2.Text;
                    if (checkBox3.Checked) c +=", "+ checkBox3.Text;
                    MessageBox.Show("Họ tên: " + name + "\nĐiện thoại: " + numberphone + "\n" + "Danh sách các mặt hàng đã mua:\n" + temp + "Phương thức thanh toán: " + r + "\n" +"Hình thức liên lạc:" + c, "Thông báo");
                    
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
