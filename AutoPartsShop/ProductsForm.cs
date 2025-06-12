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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoPartsShop
{
    public partial class ProductsForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm
        public ProductsForm()
        {
            InitializeComponent();
        }

        public void LoadDetails()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Detail.Name AS Название, Warehouse.Cell AS Ячейка, SupplierDetails.Price AS Цена, OrderPart.Count - COALESCE(Request.COUNT, 0) AS Количество " +
                "FROM Warehouse " +
                "JOIN OrderPart ON Warehouse.OrderID = OrderPart.OrderID AND Warehouse.DetailID = OrderPart.DetailID " +
                "JOIN[Order] ON OrderPart.OrderID = [Order].OrderID " +
                "JOIN SupplierDetails ON OrderPart.SupplierID = SupplierDetails.SupplierID AND OrderPart.DetailID = SupplierDetails.DetailID " +
                "JOIN Detail ON OrderPart.DetailID = Detail.DetailID " +
                "LEFT JOIN Request ON OrderPart.OrderID = Request.OrderID AND OrderPart.DetailID = Request.DetailID", MainForm.sqlConnection);

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
            LoadDetails();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadDetails();
        }
    }
}
