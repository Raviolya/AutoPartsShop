using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoPartsShop
{
    public partial class MainForm : Form
    {
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

        private void button_ProductsForm_Click(object sender, EventArgs e)
        {
            productForm.MainForm = this; // Устанавливаем свойство
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
            StatisticsForm.MainForm = this; // Устанавливаем свойство
            StatisticsForm.Show();
            this.Hide();
        }
    }
}
