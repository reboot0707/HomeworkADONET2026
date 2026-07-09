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
        DateTime? minStart = null;

        public FrmHW03()
        {
            InitializeComponent();
            try
            {
                prodPhotoDateTableAdapter1.Fill(this.dataSetAW1.ProdPhotoDate);
                dvPPD = new DataView(this.dataSetAW1.ProdPhotoDate);

                foreach (DataRowView rowView in dvPPD)
                {
                    if (rowView["SellStartDate"] == DBNull.Value)
                    { 
                        continue;
                    }

                    DateTime sdate = Convert.ToDateTime(rowView["SellStartDate"]);

                    if (minStart == null || sdate < minStart)
                        minStart = sdate;
                }

                dateTimePickerStart.Value = (DateTime)minStart;
                dateTimePickerEnd.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}");
            }
        }

        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            try
            {

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
                dataGridViewResult.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SellEndDate",
                    HeaderText = "結束銷售日期"
                });
                dataGridViewResult.RowTemplate.Height = 200;
                // 產品有開始銷售
                // 而且開賣時間不晚於查詢結束日
                // 而且產品尚未停售，或停售時間不早於查詢開始日
                dvPPD.RowFilter = $"SellStartDate IS NOT NULL AND " 
                                + $"SellStartDate <= #{enddate:MM/dd/yyyy}# AND "
                                + $"(SellEndDate IS NULL OR SellEndDate >= #{startdate:MM/dd/yyyy}#)";
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
                    sortStat = !sortStat;
                }
                else
                {
                    dvPPD.Sort = "SellStartDate DESC";
                    dataGridViewResult.DataSource = dvPPD;
                    sortStat = !sortStat;
                }
            }
        }

        private void comboBoxYear_DropDown(object sender, EventArgs e)
        {
            comboBoxYear.Items.Clear();
            for (int i = minStart.Value.Year; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(comboBoxYear.Text);
                DateTime yearstart = new DateTime(year, 1, 1);
                DateTime nextyearstart = new DateTime(year+1, 1, 1);

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
                dataGridViewResult.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SellEndDate",
                    HeaderText = "結束銷售日期"
                });
                dataGridViewResult.RowTemplate.Height = 200;
                // 產品有開始銷售
                // 而且開賣時間不晚於查詢結束日
                // 而且產品尚未停售，或停售時間不早於查詢開始日
                dvPPD.RowFilter = $"SellStartDate IS NOT NULL AND "
                                + $"SellStartDate <= #{nextyearstart:MM/dd/yyyy}# AND "
                                + $"(SellEndDate IS NULL OR SellEndDate >= #{yearstart:MM/dd/yyyy}#)";
                dataGridViewResult.DataSource = dvPPD;

                lblResult.Text = $"結果 ( {dvPPD.Count} 筆)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}");
            }
        }
    }
}
