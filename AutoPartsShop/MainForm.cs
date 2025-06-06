using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace AutoPartsShop
{
    public partial class MainForm : Form
    {
        public SqlConnection sqlConnection = null;

        ProductsForm productForm = new ProductsForm();
        CustomerRequestsForm CustomerRForm = new CustomerRequestsForm();
        DefectsForm DefectsForm = new DefectsForm();
        OrdersForm OrdersForm = new OrdersForm();
        SalesForm SalesForm = new SalesForm();
        StatisticsForm StatisticsForm = new StatisticsForm();
        SuppliersForm SuppliersForm = new SuppliersForm();
        WarehouseForm WarehouseForm = new WarehouseForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Inventory"].ConnectionString); // подключение к БД

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено");
            }
        }

        private void button_ProductsForm_Click(object sender, EventArgs e)
        {
            productForm.MainForm = this; // Устанавливаем свойство
            productForm.LoadParts();
            productForm.Show();
            this.Hide();
        }

        private void button_SuppliersForm_Click(object sender, EventArgs e)
        {
            SuppliersForm.MainForm = this; // Устанавливаем свойство
            SuppliersForm.Show();
            this.Hide();
        }

        private void button_OrdersForm_Click(object sender, EventArgs e)
        {
            OrdersForm.MainForm = this; // Устанавливаем свойство
            OrdersForm.LoadOrders1();
            OrdersForm.LoadOrders2();
            OrdersForm.LoadProductsComboBox();
            OrdersForm.LoadSupplierComboBox();
            OrdersForm.Show();
            this.Hide();
        }

        private void button_SalesForm_Click(object sender, EventArgs e)
        {
            SalesForm.MainForm = this; // Устанавливаем свойство
            SalesForm.Show();
            this.Hide();
        }

        private void button_CustomerRequestsForm_Click(object sender, EventArgs e)
        {
            CustomerRForm.MainForm = this; // Устанавливаем свойство
            CustomerRForm.Show();
            this.Hide();
        }

        private void button_DefectsForm_Click(object sender, EventArgs e)
        {
            DefectsForm.MainForm = this; // Устанавливаем свойство
            DefectsForm.Show();
            this.Hide();
        }

        private void button_WarehouseForm_Click(object sender, EventArgs e)
        {
            WarehouseForm.MainForm = this; // Устанавливаем свойство
            WarehouseForm.Show();
            this.Hide();
        }

        private void button_StatisticsForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уважаемая Татьяна Викторовна, к сожалению мы не успели реализовать статистику, так как не успевали сдать другой проект, приносим свои извинения!");
        }

        
    }
}
