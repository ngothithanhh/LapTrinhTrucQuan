using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo d in drives){
                comboBox1.Items.Add(d.Name);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   
            listBox1.Items.Clear();
            richTextBox1.Text = "";

            //string[] files = Directory.GetFiles(comboBox2.SelectedItem.ToString(), "*.mp3", SearchOption.TopDirectoryOnly); // chỉ lấy file mp3 trong thư mục hiện tại
            string[] files = Directory.GetFiles(comboBox2.SelectedItem.ToString(), "*.mp3", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                //listBox1.Items.Add(Path.GetFileName(file));
                listBox1.Items.Add(file);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string selectedDrive = comboBox1.SelectedItem.ToString();
            try
            {
                string[] folders = Directory.GetDirectories(selectedDrive);
                foreach (string folder in folders)
                {
                    comboBox2.Items.Add(folder);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể truy cập ổ đĩa!" + ex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            string fullPath = Path.Combine(comboBox2.Text, listBox1.SelectedItem.ToString());
            axWindowsMediaPlayer1.URL = fullPath;

            string fileName = Path.GetFileNameWithoutExtension(fullPath); //Lay ten file khong co duoi
            string directory = Path.GetDirectoryName(fullPath); //Lay thu muc chua file

            string lyricTxt = Path.Combine(directory, fileName + ".txt");
            string lyricRtf = Path.Combine(directory, fileName + ".rtf");

            Console.WriteLine(fullPath);
            Console.WriteLine(lyricTxt);

            if (File.Exists(lyricTxt))
            {
               
                //richTextBox1.LoadFile(lyricTxt, RichTextBoxStreamType.PlainText);
                richTextBox1.Text = File.ReadAllText(lyricTxt);
            }
            else if (File.Exists(lyricRtf))
            {
               
                richTextBox1.LoadFile(lyricRtf, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.Text = "Không tìm thấy lời bài hát!";
            }

        }
    }
}
