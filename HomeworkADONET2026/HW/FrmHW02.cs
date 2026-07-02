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

        private void buttonUnitPriceFilt_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dvUnitPrice = new DataView(this.dataSetNW1.Products);

                decimal min, max;
                min = decimal.Parse(textBoxPriceMin.Text);
                max = decimal.Parse(textBoxPriceMax.Text);

                dvUnitPrice.RowFilter = $"UnitPrice >= {min} and UnitPrice <= {max}";
                this.dataGridViewNW.DataSource = dvUnitPrice;
                this.lblResult.Text = $"結果 ( {dvUnitPrice.Count} 筆)";
            }
            catch (FormatException ex) { MessageBox.Show($"請檢查是否已輸入或輸入格式正確!"); }
            catch (Exception ex) { MessageBox.Show($"{ex.GetType()}: {ex.Message}"); }
        }

        private void buttonProdNameFilt_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dvProdName = new DataView(this.dataSetNW1.Products);

                string SearchString;
                //避免其他不必要的「客製化」查詢, 例如: `%' and CategoryID=4 and ProductName Like '%`
                SearchString = this.EscapeRowFilterValue(this.textBoxProdName.Text);
                //SearchString = this.textBoxProdName.Text;
                dvProdName.RowFilter = $"ProductName like '%{SearchString}%'";
                this.dataGridViewNW.DataSource = dvProdName;
                this.lblResult.Text = $"結果 ( {dvProdName.Count} 筆)";
            }
            catch (FormatException ex) { MessageBox.Show($"請檢查是否已輸入或輸入格式正確!"); }
            catch (Exception ex) { MessageBox.Show($"{ex.GetType()}: {ex.Message}"); }
        }

        private string EscapeRowFilterValue(string value)
        {
            if (value == null) return "";

            return value
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");
        }
    }
}
