using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkADONET2026.HW
{
    public partial class FrmHW02 : Form
    {
        public FrmHW02()
        {
            InitializeComponent();
        }

        private void FrmHW02_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.dataSetNW1.Products);
            this.dataGridViewNW.DataSource = this.dataSetNW1.Products;
        }
    }
}
