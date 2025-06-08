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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AutoPartsShop
{

    
    public partial class OrdersForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm

        private List <string> sqlOrderPart = new List<string>();
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


                    // Исправленный SQL-запрос с правильным регистром параметров
                    string insertOrderQuery = "INSERT INTO [Order] (SupplierID, Date) OUTPUT INSERTED.OrderID VALUES (@SupplierID, @Date)";
                    using (SqlCommand command = new SqlCommand(insertOrderQuery, MainForm.sqlConnection))
                    {
                        // Добавление параметров с правильным регистром и типом
                        command.Parameters.AddWithValue("@SupplierID", SupplierComboBox.SelectedValue ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Date", DateTime.Now); // Передача DateTime напрямую

                        // Получаем ID новой записи
                        int orderId = Convert.ToInt32(command.ExecuteScalar());

                        // Выполняем команды из sqlOrderPart
                        foreach (string sql in this.sqlOrderPart)
                        {
                            using (SqlCommand orderPartsCommand = new SqlCommand(sql, MainForm.sqlConnection))
                            {
                                // Добавляем параметр OrderID
                                orderPartsCommand.Parameters.AddWithValue("@OrderID", orderId);

                                // Выполняем вставку в OrderParts
                                orderPartsCommand.ExecuteNonQuery();
                            }
                        }

                        // Скрываем ComboBox после завершения всех операций
                        SupplierComboBox.Visible = false;
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
            string selectDetails = $"SELECT * FROM Detail WHERE Name LIKE '%{Details.Text}%'";

            using (SqlCommand command1 = new SqlCommand(selectDetails, MainForm.sqlConnection))
            {
                command1.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command1);
                adapter.Fill(table);
                DetailsComboBox.DisplayMember = "Name";
                DetailsComboBox.ValueMember = "DetailID";
                DetailsComboBox.DataSource = table;
            }
        }

        private void selectDetail_Click(object sender, EventArgs e)
        {
            try
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
                    DetailsComboBox.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addOrder = $"INSERT INTO OrderPart (OrderID, DetailID, Count, SupplierID) VALUES (@OrderID, {DetailsComboBox.SelectedValue}, {Convert.ToInt32(DetailCount.Value)}, {SupplierComboBox.SelectedValue})";
            this.sqlOrderPart.Add(addOrder);
            SupplierComboBox.Enabled = false;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders1();
        }
    }
}
