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
    public partial class DefectsForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm
        public DefectsForm()
        {
            InitializeComponent();
        }
        private void DefectsForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string insertDefect = "INSERT INTO Defect (SaleID, OrderID, DetailID, Description, Date) VALUES (@SaleID, @OrderID, @DetailID, @Description, @Date)";
            using (SqlCommand sqlinsert = new SqlCommand(insertDefect, MainForm.sqlConnection))
            {
                sqlinsert.Parameters.AddWithValue("@Description", Description.Text);
                sqlinsert.Parameters.AddWithValue("@Date", DateTime.Now.Date); // Только дата без времени

                string selectData = @"SELECT Request.SaleID, Request.OrderID, Request.DetailID 
                         FROM Sale 
                         JOIN Request ON Sale.SaleID = Request.SaleID 
                         JOIN Detail ON Request.DetailID = Detail.DetailID 
                         WHERE Sale.CustomerName LIKE N'%' + @CustomerName + N'%' 
                         AND Sale.CustomerPhone LIKE '%' + @CustomerPhone + '%' 
                         AND Request.DetailID = @DetailID 
                         AND Sale.Date = @SaleDate";

                using (SqlCommand sqlData = new SqlCommand(selectData, MainForm.sqlConnection))
                {
                    sqlData.Parameters.AddWithValue("@CustomerName", NameTextBox.Text);
                    sqlData.Parameters.AddWithValue("@CustomerPhone", PhoneTextBox.Text);
                    sqlData.Parameters.AddWithValue("@DetailID", DetailsComboBox.SelectedValue ?? 0);
                    sqlData.Parameters.AddWithValue("@SaleDate", dateSale.Value.Date); // Корректный формат даты

                    try
                    {
                        if (MainForm.sqlConnection.State != System.Data.ConnectionState.Open)
                            MainForm.sqlConnection.Open();

                        using (SqlDataReader reader = sqlData.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int saleID = reader.GetInt32(0); // SaleID
                                int orderID = reader.GetInt32(1); // OrderID
                                int detailID = reader.GetInt32(2); // DetailID

                                sqlinsert.Parameters.AddWithValue("@SaleID", saleID);
                                sqlinsert.Parameters.AddWithValue("@OrderID", orderID);
                                sqlinsert.Parameters.AddWithValue("@DetailID", detailID); // Исправлено: только один DetailID

                                reader.Close(); // Явное закрытие reader

                                sqlinsert.ExecuteNonQuery();
                                MessageBox.Show("Брак зарегистрирован", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DetailsComboBox.Visible = false;
                                LoadDefects();
                                button1.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Данные не найдены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Ошибка SQL: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void searchDetail_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || PhoneTextBox.Text == "")
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            string selectDetails = @"SELECT Detail.DetailID, Detail.Name 
                        FROM Sale 
                        JOIN Request ON Sale.SaleID = Request.SaleID 
                        JOIN Detail ON Request.DetailID = Detail.DetailID 
                        WHERE Sale.CustomerName LIKE N'%' + @CustomerName + N'%' 
                        AND Sale.CustomerPhone LIKE '%' + @CustomerPhone + '%' 
                        AND Detail.Name LIKE N'%' + @DetailName + N'%' 
                        AND Sale.Date = @SaleDate";

            using (SqlCommand command1 = new SqlCommand(selectDetails, MainForm.sqlConnection))
            {
                command1.Parameters.AddWithValue("@CustomerName", NameTextBox.Text);
                command1.Parameters.AddWithValue("@CustomerPhone", PhoneTextBox.Text);
                command1.Parameters.AddWithValue("@DetailName", Details.Text);
                command1.Parameters.AddWithValue("@SaleDate", dateSale.Value.Date); // Используем .Date для исключения времени

                try
                {
                    if (MainForm.sqlConnection.State != System.Data.ConnectionState.Open)
                        MainForm.sqlConnection.Open();

                    DataTable table = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command1))
                    {
                        adapter.Fill(table);
                    }

                    DetailsComboBox.DataSource = table;
                    DetailsComboBox.DisplayMember = "Name";
                    DetailsComboBox.ValueMember = "DetailID";
                    DetailsComboBox.Visible = true;
                    button1.Visible = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка SQL: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDefects()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Detail.Name AS Деталь, Supplier.Name AS Поставщик, [Order].[Date] AS Дата_покупки, Sale.[Date] AS Дата_продажи, Sale.CustomerName AS Имя_покупателя, Sale.CustomerPhone AS Номер_телефона_покупателя, Defect.Description AS Описание_поломки " +
                "FROM Defect " +
                "JOIN Request ON Defect.SaleID = Request.SaleID AND Defect.OrderID = Request.OrderID AND Defect.DetailID = Request.DetailID " +
                "JOIN Sale ON Request.SaleID = Sale.SaleID " +
                "JOIN OrderPart ON Request.DetailID = OrderPart.DetailID AND Request.OrderID = OrderPart.OrderID " +
                "JOIN [Order] ON OrderPart.OrderID = [Order].OrderID " +
                "JOIN Detail ON Request.DetailID = Detail.DetailID " +
                "JOIN Supplier ON OrderPart.SupplierID = Supplier.SupplierID", MainForm.sqlConnection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            DefectDataGrid.DataSource = ds.Tables[0];
        }

        private void DefectsForm_Load(object sender, EventArgs e)
        {
            LoadDefects();
        }
    }
}
