using AutoPartsShop.Repository;
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
        private readonly PartRepository _partRepository; // паттерн репозиторий для управления таблицей Детали
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm
        public ProductsForm()
        {
            InitializeComponent();
            _partRepository = new PartRepository();
            LoadParts();
        }

        private void LoadParts()
        {
            var parts = _partRepository.GetAll();
            dataProducts.DataSource = parts;
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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            string Name = ProductName.Text;
            decimal SalePrice = salePrice.Value;
            SqlCommand command = new SqlCommand($"INSERT INTO [Parts] (Name, SalePrice) VALUES (N'{Name}', '{SalePrice}')", MainForm.sqlConnection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());  
        }
    }
}
