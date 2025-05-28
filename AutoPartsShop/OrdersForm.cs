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
                        LoadOrders1();
                        LoadOrders2();
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
            if (cell.Visible == false)
            {
                label5.Visible = true;
                cell.Visible = true;
                MessageBox.Show("Выберите ячейку и снова кликните на кнопку");
            }
            else
            {
                label5.Visible = false;
                cell.Visible = false;

                if (orderDataGrid.CurrentRow == null)
                {
                    MessageBox.Show("Выберите строку в таблице.");
                    return;
                }

                string partId = Convert.ToString(orderDataGrid.CurrentRow.Cells["Status"].Value);
                int id = Convert.ToInt32(orderDataGrid.CurrentRow.Cells["OrderId"].Value);

                if (partId == "Выполнен")
                {
                    MessageBox.Show("Заказ уже выполнен.");
                    return;
                }

                try
                {
                    if (MainForm.sqlConnection.State != System.Data.ConnectionState.Open)
                        MainForm.sqlConnection.Open();

                    string updateQuery = "UPDATE Orders SET Status = @Status WHERE OrderId = @OrderId";
                    using (SqlCommand command = new SqlCommand(updateQuery, MainForm.sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Status", "Выполнен");
                        command.Parameters.AddWithValue("@OrderId", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                            MessageBox.Show("Заказ не найден или не обновлён.");
                    }

                    LoadOrders1();



                    string getPartId = "SELECT PartId, Count FROM OrderParts WHERE OrderId = @OrderId";
                    List<OrderPartsItem> items = new List<OrderPartsItem>();
                    using (SqlCommand cmd = new SqlCommand(getPartId, MainForm.sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@OrderId", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int PartId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                                int Count = reader.IsDBNull (1) ? 0 : reader.GetInt32(1);
                                items.Add(new OrderPartsItem(PartId, Count));
                            }
                        }
                    }

                    if (items.Count == 0)
                    {
                        MessageBox.Show($"Нет записей в OrderParts для OrderId {id}.");
                        return;
                    }

                  
                    if (cell.Value == null || !int.TryParse(cell.Value.ToString(), out int currentCell))
                    {
                        MessageBox.Show("Некорректное значение ячейки.");
                        return;
                    }


                    string addParts = "INSERT INTO Warehouse (PartId, Cell, IsSold) VALUES (@PartId, @Cell, 0)";
                    int insertedCount = 0;
                    foreach (OrderPartsItem value in items)
                    {
                        for (int i = 0; i < value.Count; i++)
                        {
                            using (SqlCommand cmd1 = new SqlCommand(addParts, MainForm.sqlConnection))
                            {
                                cmd1.Parameters.AddWithValue("@PartId", value.PartId);
                                cmd1.Parameters.AddWithValue("@Cell", currentCell);
                                int rowsAffected = cmd1.ExecuteNonQuery();
                                insertedCount += rowsAffected;
                            }
                        }
                    }

                    if (insertedCount > 0)
                        MessageBox.Show($"Успешно добавлено {insertedCount} записей в Warehouse.");
                    else
                        MessageBox.Show("Не удалось добавить записи в Warehouse.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }
    }
    public class OrderPartsItem
    {
        public int PartId { get; set; }
        public int Count { get; set; }

        public OrderPartsItem(int partId, int count)
        {
            PartId = partId;
            Count = count;
        }

        public override string ToString()
        {
            return $"PartId: {PartId}, Count: {Count}";
        }
    }
}
