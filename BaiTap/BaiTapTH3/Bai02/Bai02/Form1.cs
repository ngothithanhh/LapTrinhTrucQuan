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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void baiDienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu();
            bt.Debai = "Voluntary work helps (1) ____ independence and imparts the ability to (2) ____ " +
                "with different situations,\r\noften simultaneously, thus teaching people how to (3) ____ their way through different systems." +
                "\r\nIt therefore (4) ____ people into touch with the real world and (5) ____ them for the future." +
                "\r\nInitially, young adults might not seem to have the (6) ____ to contribute to others," +
                "\r\nbut they do have many (7) ____ that can help others.\r\nTheir (8) ____ and enthusiasm " +
                "can be (9) ____ for the benefit of their fellow human beings,\r\nand ultimately (10) ____ themselves.\r\n";

            List<string> lists = new List<string>
            {
                "foster",
                "deal",
                "work",
                "brings",
                "equips",
                "expertise",
                "skills",
                "energy",
                "harnessed",
                "benefit"
            };
            bt.Dapantungcau = lists;
            formBTDienTu btdt = new formBTDienTu(bt);
            btdt.Show();


        }
    }
}
