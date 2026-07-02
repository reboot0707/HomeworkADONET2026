using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkADONET2026.HW
{
    public partial class FrmHW01 : Form
    {
        public FrmHW01()
        {
            InitializeComponent();
        }

        private void comboQueryCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString; //"..........";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select ProductName, ProductID, Products.CategoryID, CategoryName from Products join Categories on Products.CategoryID = Categories.CategoryID  where CategoryName = @Name;";
                    cmd.Parameters.Add("@Name",SqlDbType.NVarChar,40).Value = comboQueryCategory.Text;
                    cmd.Connection = conn;
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<string> catList = new List<string>();

                    listBoxProductsCat.Items.Clear();

                    while (reader.Read())
                    {
                        string cat = $"{reader["ProductName"]}";
                        listBoxProductsCat.Items.Add(cat);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.GetType() + ":" + ex.Message); }
        }

        private void comboQueryCategory_DropDown(object sender, EventArgs e)
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString; //"..........";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select CategoryName from Categories;";
                    cmd.Connection = conn;
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<string> catList = new List<string>();

                    comboQueryCategory.Items.Clear();

                    while (reader.Read())
                    {
                        string cat = $"{reader["CategoryName"]}";
                        comboQueryCategory.Items.Add(cat);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.GetType() + ":" + ex.Message); }
        }
    }
}
