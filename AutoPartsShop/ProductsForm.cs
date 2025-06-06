using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsShop
{
    public partial class ProductsForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm
        public ProductsForm()
        {
            InitializeComponent();
        }

        public void LoadParts()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Detail.Name AS Название, Warehouse.Cell AS Ячейка, Warehouse.Price AS Цена " +
                "FROM Warehouse " +
                "JOIN Detail ON Warehouse.DetailID = Detail.DetailID", MainForm.sqlConnection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            dataProducts.DataSource = ds.Tables[0];
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                MainForm.Show();
                this.Hide(); 
            }
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            LoadParts();
        }
    }
}
