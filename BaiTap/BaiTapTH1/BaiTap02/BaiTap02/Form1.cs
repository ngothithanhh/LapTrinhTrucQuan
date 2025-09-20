using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            double x1 = double.Parse(txtX1.Text);
            double y1 = double.Parse(txtY1.Text);
            double x2 = double.Parse(txtX2.Text);
            double y2 = double.Parse(txtY2.Text);

            // Tính hệ số góc
            string heSoGoc;
            if (x2 == x1)
            {
                heSoGoc = "Không xác định (đường thẳng đứng)";
            }
            else
            {
                double k = (y2 - y1) / (x2 - x1);
                heSoGoc = k.ToString("0.##");
            }

            // Tính khoảng cách
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            // Xuất ra TextBox kết quả
            txtHeSoGoc.Text = heSoGoc;
            txtKhoangCach.Text = d.ToString("0.##");
        }
    catch
    {
        MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    }
}
