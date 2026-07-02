using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeworkADONET2026.HW;

namespace HomeworkADONET2026
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonOpenHW01_Click(object sender, EventArgs e)
        {
            (new FrmHW01()).Show();
        }

        private void buttonOpenHW02_Click(object sender, EventArgs e)
        {
            (new FrmHW02()).Show();
        }

        private void buttonOpenHW03_Click(object sender, EventArgs e)
        {
            (new FrmHW03()).Show();
        }

        private void buttonHW04_Click(object sender, EventArgs e)
        {
            (new FrmHW04_Login()).Show();
        }

        private void buttonHW05_Click(object sender, EventArgs e)
        {
            (new FrmHW05_Album()).Show();
        }
    }
}
