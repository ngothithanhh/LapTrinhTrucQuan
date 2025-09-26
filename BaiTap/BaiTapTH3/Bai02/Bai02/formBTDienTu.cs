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
    public partial class formBTDienTu : Form
    {
        private BaiTapDienTu bt;

        public formBTDienTu(BaiTapDienTu baitap)
        {
            InitializeComponent();
            bt = baitap;
            richTextBox1.Text = bt.Debai;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = 0;
            if (textBox1.Text == bt.Dapantungcau[0]) 
            {
                diem++;
                textBox1.BackColor = Color.Green;

            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text == bt.Dapantungcau[1])
            {
                diem++;
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == bt.Dapantungcau[2])
            {
                diem++;
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text == bt.Dapantungcau[3])
            {
                diem++;
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            if (textBox5.Text == bt.Dapantungcau[4])
            {
                diem++;
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }
            if (textBox6.Text == bt.Dapantungcau[5])
            {
                diem++;
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
            if (textBox7.Text == bt.Dapantungcau[6])
            {
                diem++;
                textBox7.BackColor = Color.Green;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }
            if (textBox8.Text == bt.Dapantungcau[7])
            {
                diem++;
                textBox8.BackColor = Color.Green;
            }
            else
            {
                textBox8.BackColor = Color.Red;
            }
            if (textBox9.Text == bt.Dapantungcau[8])
            {
                diem++;
                textBox9.BackColor = Color.Green;
            }
            else
            {
                textBox9.BackColor = Color.Red;
            }
            if (textBox10.Text == bt.Dapantungcau[9])
            {
                diem++;
                textBox10.BackColor = Color.Green;
            }
            else
            {
                textBox10.BackColor = Color.Red;
            }



            MessageBox.Show("Bạn đã trả lời đúng " + diem + " câu trong tổng số 10 câu.");
            
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bt.Dapantungcau.Count; i++)
            {
                richTextBox1.AppendText($"{i + 1}: {bt.Dapantungcau[i]}\n");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = bt.Debai;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox10.BackColor = Color.White;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
