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
    public partial class OrdersForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void AddOrder_Click(object sender, EventArgs e)
        {
            // Вставка в таблицу Orders и получение OrderId
            string insertOrderQuery = "INSERT INTO Orders (Date, SupplierId, Status) OUTPUT INSERTED.OrderId VALUES (@Date, @SupplierId, @Status)";
            using (SqlCommand command = new SqlCommand(insertOrderQuery, MainForm.sqlConnection))
            {
                command.Parameters.AddWithValue("@Date", DateTime.Now.ToString("dd-MM-yyyy"));
                command.Parameters.AddWithValue("@SupplierId", SupplierComboBox.SelectedValue);
                command.Parameters.AddWithValue("@Status", "В обработке");

                // Получаем ID новой записи
                int orderId = Convert.ToInt32(command.ExecuteScalar());

                
                int partId = Convert.ToInt32(ProductsComboBox.SelectedValue);
                int count = Convert.ToInt32(DetailCount.Value);

                // Получаем Price из таблицы Products
                string getPriceQuery = "SELECT SalePrice FROM Parts WHERE PartId = @PartId";
                using (SqlCommand priceCommand = new SqlCommand(getPriceQuery, MainForm.sqlConnection))
                {
                    priceCommand.Parameters.AddWithValue("@PartId", partId);
                    decimal price = Convert.ToDecimal(priceCommand.ExecuteScalar());

                    // Вставка в таблицу OrderParts
                    string insertOrderPartsQuery = "INSERT INTO OrderParts (OrderId, PartId, Count, Price) VALUES (@OrderId, @PartId, @Count, @Price)";
                    using (SqlCommand orderPartsCommand = new SqlCommand(insertOrderPartsQuery, MainForm.sqlConnection))
                    {
                        orderPartsCommand.Parameters.AddWithValue("@OrderId", orderId);
                        orderPartsCommand.Parameters.AddWithValue("@PartId", partId);
                        orderPartsCommand.Parameters.AddWithValue("@Count", count);
                        orderPartsCommand.Parameters.AddWithValue("@Price", price * count);

                        // Выполняем вставку в OrderParts
                        int rowsAffected = orderPartsCommand.ExecuteNonQuery();
                        MessageBox.Show($"Добавлено строк в OrderParts: {rowsAffected}");
                    }
                }
            }
        }

        public void LoadProductsComboBox ()
        {
            using (SqlCommand command = new SqlCommand("SELECT PartId, Name FROM Parts", MainForm.sqlConnection))
            {
                command.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                ProductsComboBox.DisplayMember = "Name";
                ProductsComboBox.ValueMember = "PartId";
                ProductsComboBox.DataSource = table;
            }
        }   

        public void LoadSupplierComboBox ()
        {
            using (SqlCommand command = new SqlCommand("SELECT SupplierId, Name FROM Suppliers", MainForm.sqlConnection))
            {
                command.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                SupplierComboBox.DisplayMember = "Name";
                SupplierComboBox.ValueMember = "SupplierId";
                SupplierComboBox.DataSource = table;
            }
        }

        public void LoadOrders1()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM Orders", MainForm.sqlConnection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            orderDataGrid.DataSource = ds.Tables[0];
        }

        public void LoadOrders2()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM OrderParts", MainForm.sqlConnection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            orderDataGrid2.DataSource = ds.Tables[0];
        }

        private void EditOrder_Click(object sender, EventArgs e)
        {
            LoadOrders1();
            LoadOrders2();
        }

        private void editStatus_Click(object sender, EventArgs e)
        {
            if (orderDataGrid.CurrentRow != null)
            {
                int id = Convert.ToInt32(orderDataGrid.CurrentRow.Cells["OrderId"].Value);
                string updateQuery = "UPDATE Orders SET Status = @Status WHERE OrderId = @OrderId";
                using (SqlCommand command = new SqlCommand(updateQuery, MainForm.sqlConnection))
                {
                    command.Parameters.AddWithValue("@Status", "Выполнен");
                    command.Parameters.AddWithValue("@OrderId", id);
                    command.ExecuteNonQuery();
                }
                LoadOrders1();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }
    }
}
