using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap25_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void btn_Font_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            dlgFont.ShowColor = true;
            if(dlgFont.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dlgFont.Font;
                richTextBox1.SelectionColor = dlgFont.Color;
            }

        }
    }
}
