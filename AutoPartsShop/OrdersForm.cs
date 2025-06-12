using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AutoPartsShop
{

    
    public partial class OrdersForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm

        private List <string> sqlOrderPart = new List<string>();

        private List <object> ItemsRemove = new List<object>();
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
            string insertOrderQuery = "INSERT INTO [Order] (SupplierID, Date) OUTPUT INSERTED.OrderID VALUES (@SupplierID, @Date)";
            using (SqlCommand insertOrder = new SqlCommand(insertOrderQuery, MainForm.sqlConnection))
            {
                // Добавление параметров с правильным регистром и типом
                insertOrder.Parameters.AddWithValue("@SupplierID", SupplierComboBox.SelectedValue ?? DBNull.Value);
                insertOrder.Parameters.AddWithValue("@Date", DateTime.Now); // Передача DateTime напрямую

                // Получаем ID новой записи
                int orderId = Convert.ToInt32(insertOrder.ExecuteScalar());

                string insertWarehouse = "INSERT INTO Warehouse (OrderID, DetailID, Cell, Price) VALUES (@OrderID, @DetailID, @Cell, @Price)";
                // Выполняем команды из sqlOrderPart
                foreach (string sql in this.sqlOrderPart)
                {
                    using (SqlCommand orderPartsCommand = new SqlCommand(sql, MainForm.sqlConnection))
                    {
                        using (SqlCommand warehouseCommand = new SqlCommand(insertWarehouse, MainForm.sqlConnection))
                        {
                            orderPartsCommand.Parameters.AddWithValue("@OrderID", orderId);
                            using (SqlDataReader reader = orderPartsCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int DetailID = Convert.ToInt32(reader.GetInt32(0)); // Первый столбец
                                    int SupplierID = Convert.ToInt32(reader.GetInt32(1)); // Второй столбец
                                    reader.Close();
                                    warehouseCommand.Parameters.AddWithValue("@DetailID", DetailID);
                                    warehouseCommand.Parameters.AddWithValue("@OrderID", orderId);
                                    using (SqlCommand cellmax = new SqlCommand("SELECT MAX(Cell) AS MaxCell FROM Warehouse", MainForm.sqlConnection))
                                    {
                                        object cell = cellmax.ExecuteScalar();
                                        int cellValue = cell != DBNull.Value ? Convert.ToInt32(cell) : 0;
                                        warehouseCommand.Parameters.AddWithValue("@Cell", Convert.ToInt32(cellValue) + 1);
                                    }
                                    using (SqlCommand supPrice = new SqlCommand($"SELECT Price FROM SupplierDetails WHERE SupplierID = {SupplierID} AND DetailID = {DetailID}", MainForm.sqlConnection))
                                    {
                                        double price = Convert.ToDouble(supPrice.ExecuteScalar());
                                        warehouseCommand.Parameters.AddWithValue("@Price", price * 1.4);
                                    }
                                    warehouseCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                // Скрываем ComboBox после завершения всех операций
                SupplierComboBox.Visible = false;
                label1.Visible = false;
                DetailsComboBox.Visible = false;
                SupplierComboBox.Enabled = true;
                selectDetail.Visible = false;
                this.sqlOrderPart.Clear();
                MessageBox.Show("Заказ успешно создан");
                LoadOrders1();
            }
        }


        public void LoadSupplierComboBox ()
        {
            using (SqlCommand command = new SqlCommand("SELECT SupplierID, Name FROM Supplier", MainForm.sqlConnection))
            {
                command.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                SupplierComboBox.DisplayMember = "Name";
                SupplierComboBox.ValueMember = "SupplierID";
                SupplierComboBox.DataSource = table;
            }
            
        }

        public void LoadOrders1()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Detail.Name AS Деталь, Supplier.Name AS Поставщик, [OrderPart].Count AS Количество, [Order].Date AS Дата FROM [OrderPart] " +
                "JOIN [Order] ON [OrderPart].OrderID = [Order].OrderID " +
                "JOIN Detail ON [OrderPart].DetailID = Detail.DetailID " +
                "JOIN Supplier ON [OrderPart].SupplierID = Supplier.SupplierID", MainForm.sqlConnection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            orderDataGrid.DataSource = ds.Tables[0];
        }

        private void EditOrder_Click(object sender, EventArgs e)
        {
            LoadOrders1();
        }

        private void editStatus_Click(object sender, EventArgs e)
        {
            
        }

        private void searchDetail_Click(object sender, EventArgs e)
        {
            if (SupplierComboBox.Enabled == true)
            {
                string selectDetails = $"SELECT * FROM Detail WHERE Name LIKE N'%{Details.Text}%'";

                using (SqlCommand command1 = new SqlCommand(selectDetails, MainForm.sqlConnection))
                {
                    command1.CommandType = CommandType.Text;
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command1);
                    adapter.Fill(table);
                    DetailsComboBox.DisplayMember = "Name";
                    DetailsComboBox.ValueMember = "DetailID";
                    DetailsComboBox.DataSource = table;
                    DetailsComboBox.Visible = true;
                    selectDetail.Visible = true;
                }
            }
            else 
            {
                string selectDetails = $"SELECT Detail.DetailID, Detail.Name FROM Detail JOIN " +
                    $"SupplierDetails ON Detail.DetailID = SupplierDetails.DetailID " +
                    $"WHERE Name LIKE '%{Details.Text}%' AND SupplierDetails.SupplierID = {SupplierComboBox.SelectedValue}";

                using (SqlCommand command1 = new SqlCommand(selectDetails, MainForm.sqlConnection))
                {
                    command1.CommandType = CommandType.Text;
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command1);
                    adapter.Fill(table);
                    DetailsComboBox.DisplayMember = "Name";
                    DetailsComboBox.ValueMember = "DetailID";
                    DetailsComboBox.DataSource = table;
                    DetailsComboBox.Visible = true;
                    foreach (object item in ItemsRemove)
                    {
                        DetailsComboBox.Items.Remove(item);
                    }
                }
            }
        }

        private void selectDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (SupplierComboBox.Enabled == true)
                {
                    string selectSuppliers = "SELECT Supplier.SupplierID, Supplier.Name " +
                        "FROM Detail " +
                        "JOIN SupplierDetails ON Detail.DetailID = SupplierDetails.DetailID " +
                        "JOIN Supplier ON SupplierDetails.SupplierID = Supplier.SupplierID " +
                        "WHERE Detail.Name = @Name";

                    using (SqlCommand command = new SqlCommand(selectSuppliers, MainForm.sqlConnection))
                    {
                        // Извлекаем DataRowView из SelectedItem
                        DataRowView selectedRow = DetailsComboBox.SelectedItem as DataRowView;
                        if (selectedRow == null)
                        {
                            MessageBox.Show("Пожалуйста, выберите деталь.");
                            return;
                        }

                        // Извлекаем значение столбца Name
                        string nameValue = selectedRow["Name"]?.ToString();
                        if (string.IsNullOrEmpty(nameValue))
                        {
                            MessageBox.Show("Имя детали не может быть пустым.");
                            return;
                        }

                        // Передаём строку в параметр
                        command.Parameters.AddWithValue("@Name", nameValue);
                        command.CommandType = CommandType.Text;

                        DataTable table = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }

                        // Настройка SupplierComboBox
                        SupplierComboBox.DisplayMember = "Name";
                        SupplierComboBox.ValueMember = "SupplierID";
                        SupplierComboBox.DataSource = table;
                        SupplierComboBox.Visible = true;
                        label1.Visible = true;
                        DetailsComboBox.Enabled = true;
                    }
                }
                else 
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SupplierComboBox.Visible == false)
            {
                MessageBox.Show("Нажмите 'выбрать' и выберите поставщика");
                return;
            }
            string addOrder = $"INSERT INTO OrderPart (OrderID, DetailID, Count, SupplierID) OUTPUT INSERTED.DetailID, INSERTED.SupplierID VALUES (@OrderID, {DetailsComboBox.SelectedValue}, {Convert.ToInt32(DetailCount.Value)}, {SupplierComboBox.SelectedValue})";
            MessageBox.Show($"Добавлено к заказу");
            this.sqlOrderPart.Add(addOrder);
            var value = SupplierComboBox.SelectedValue;
            SupplierComboBox.Enabled = false;
            SupplierComboBox.SelectedValue = value;
            selectDetails_with_Supllier((int)SupplierComboBox.SelectedValue);
            ItemsRemove.Add(DetailsComboBox.SelectedValue);
            DetailsComboBox.Items.Remove(DetailsComboBox.SelectedValue);
        }

        private void selectDetails_with_Supllier(int supplier)
        {

            string selectDetails = $"SELECT Detail.DetailID, Detail.Name FROM Detail JOIN SupplierDetails ON Detail.DetailID = SupplierDetails.DetailID WHERE SupplierID = {supplier}";

            using (SqlCommand command1 = new SqlCommand(selectDetails, MainForm.sqlConnection))
            {
                command1.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command1);
                adapter.Fill(table);
                DetailsComboBox.DisplayMember = "Name";
                DetailsComboBox.ValueMember = "DetailID";
                DetailsComboBox.DataSource = table;
                DetailsComboBox.Visible = true;
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders1();
        }

    }
}
