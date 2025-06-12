using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsShop
{
    public partial class SalesForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm

        private List<string> sqlRequest = new List<string>();

        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void AddSale_Click(object sender, EventArgs e)
        {
            string insertSaleQuery = "INSERT INTO Sale (Date, CustomerPhone, CustomerName) OUTPUT INSERTED.SaleID VALUES (@Date, @CustomerPhone, @CustomerName)";
            using (SqlCommand insertOrder = new SqlCommand(insertSaleQuery, MainForm.sqlConnection))
            {
                // Добавление параметров с правильным регистром и типом
                insertOrder.Parameters.AddWithValue("@CustomerPhone", PhoneTextBox.Text);
                insertOrder.Parameters.AddWithValue("@CustomerName", NameTextBox.Text);
                insertOrder.Parameters.AddWithValue("@Date", DateTime.Now);

                // Получаем ID новой записи
                int SaleId = Convert.ToInt32(insertOrder.ExecuteScalar());
                // Выполняем команды из sqlOrderPart
                foreach (string sql in sqlRequest)
                {
                    using (SqlCommand RequestCommand = new SqlCommand(sql, MainForm.sqlConnection))
                    {
                        RequestCommand.Parameters.AddWithValue("@SaleID", SaleId);
                        RequestCommand.ExecuteNonQuery();
                    }
                }
                // Скрываем ComboBox после завершения всех операций
                DetailsComboBox.Visible = false;
                sqlRequest.Clear();
                MessageBox.Show("Заказ успешно создан");
                LoadSales();
            }
        }

        private void searchDetail_Click(object sender, EventArgs e)
        {

            string selectDetails = $"SELECT Detail.DetailID, Detail.Name FROM Warehouse " +
                $"JOIN Detail ON Warehouse.DetailID = Detail.DetailID " +
                $"WHERE Name LIKE N'%{Details.Text}%'";

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

       

        private void button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(DetailCount.Value);
            string selectOrderId = $"SELECT TOP 1 Warehouse.OrderID FROM Warehouse " +
                $"JOIN OrderPart ON Warehouse.OrderID = OrderPart.OrderID AND Warehouse.DetailID = OrderPart.DetailID " +
                $"WHERE Warehouse.DetailID = {DetailsComboBox.SelectedValue} AND OrderPart.Count - {count} >=0 " +
                $"ORDER BY NEWID()";
            using (SqlCommand OrderIdCommand = new SqlCommand(selectOrderId, MainForm.sqlConnection))
            {
                object id = OrderIdCommand.ExecuteScalar();
                int orderId = id != DBNull.Value ? Convert.ToInt32(id) : -1;
                if (orderId == -1) { MessageBox.Show("Таких деталей на складе нет, необходимо заказать"); return; }
                string addOrder = "INSERT INTO Request (OrderID, DetailID, SaleID, COUNT) " +
                    $"VALUES ({orderId}, {DetailsComboBox.SelectedValue}, @SaleID, {count})";
                MessageBox.Show($"Добавлено");
                sqlRequest.Add(addOrder);
            }
        }

        private void LoadSales()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Detail.Name AS Название, Request.COUNT AS Количество, CustomerName AS Имя_Покупателя, CustomerPhone AS Телефон_Покупателя, Sale.Date AS Дата " +
                "FROM Sale " +
                "JOIN Request ON Sale.SaleID = Request.SaleID " +
                "JOIN Detail ON Request.DetailID = Detail.DetailID", MainForm.sqlConnection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            SaleDataGrid.DataSource = ds.Tables[0];
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadSales();
        }
    }
}
