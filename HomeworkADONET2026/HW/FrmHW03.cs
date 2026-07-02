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
    public partial class FrmHW03 : Form
    {
        DataView dvPPD = null;
        bool sortStat = false;

        public FrmHW03()
        {
            InitializeComponent();
        }

        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            try
            {
                prodPhotoDateTableAdapter1.Fill(this.dataSetAW1.ProdPhotoDate);
                dvPPD = new DataView(this.dataSetAW1.ProdPhotoDate);
                DateTime startdate = dateTimePickerStart.Value;
                DateTime enddate = dateTimePickerEnd.Value;

                dataGridViewResult.AutoGenerateColumns = false;
                dataGridViewResult.Columns.Clear();
                dataGridViewResult.Columns.Add(new DataGridViewImageColumn
                {
                    DataPropertyName = "LargePhoto",
                    HeaderText = "照片",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                });
                dataGridViewResult.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SellStartDate",
                    HeaderText = "開始銷售日期"
                });
                dataGridViewResult.RowTemplate.Height = 200;
                dvPPD.RowFilter = $"SellStartDate >= #{startdate:MM/dd/yyyy}# AND "
                                + $"SellEndDate <= #{enddate:MM/dd/yyyy}#";
                dataGridViewResult.DataSource = dvPPD;

                lblResult.Text = $"結果 ( {dvPPD.Count} 筆)";
            } 
            catch (Exception ex)
            { 
                MessageBox.Show($"{ex.GetType()}: {ex.Message}"); 
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if( dvPPD != null )
            {
                if (sortStat)
                {
                    dvPPD.Sort = "SellStartDate ASC";
                    dataGridViewResult.DataSource = dvPPD;
                }
                else
                {
                    dvPPD.Sort = "SellStartDate DESC";
                    dataGridViewResult.DataSource = dvPPD;
                }
            }
        }
    }
}
