using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace AutoPartsShop
{
    public partial class SuppliersForm : Form
    {
        private string[] detailNames = null;
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void SuppliersForm_FormClosed(object sender, FormClosedEventArgs e)
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


        public void LoadCountriesToComboBox()
        {
            try
            {
                // Создаем SQL-запрос для извлечения стран
                string query = "SELECT CountryID, Name FROM Country";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, MainForm.sqlConnection);

                // Создаем DataTable для хранения данных
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Устанавливаем источник данных для ComboBox
                country.DataSource = dt;
                country.DisplayMember = "Name"; // Поле, которое будет отображаться
                country.ValueMember = "CountryID"; // Поле, которое будет использовано как значение
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке стран: " + ex.Message);
            }
        }

        public void LoadTypesToComboBox()
        {
            try
            {
                // Создаем SQL-запрос для извлечения стран
                string query = "SELECT TypeID, Name FROM Type";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, MainForm.sqlConnection);

                // Создаем DataTable для хранения данных
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Устанавливаем источник данных для ComboBox
                SupplierCategories.DataSource = dt;
                SupplierCategories.DisplayMember = "Name"; // Поле, которое будет отображаться
                SupplierCategories.ValueMember = "TypeID"; // Поле, которое будет использовано как значение
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке типов: " + ex.Message);
            }
        }

        public void LoadSupplier()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Supplier.Name AS Наименование, Country.Name AS Страна, Type.Name AS Тип, Supplier.NumberPhone AS 'Номер телефона', Supplier.WebSite AS WEBsite " +
                "FROM Supplier " +
                "JOIN Country ON Supplier.CountryID = Country.CountryID " +
                "JOIN Type ON Supplier.TypeID = Type.TypeID", MainForm.sqlConnection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            dataSuppliers.DataSource = ds.Tables[0];
        }



        private void AddSupplier_Click(object sender, EventArgs e)
        {
            string category = Convert.ToString(SupplierCategories.SelectedItem);
            string insertinto = "INSERT INTO Supplier (Name, TypeID, CountryID, NumberPhone, WebSite) OUTPUT INSERTED.SupplierID VALUES (@Name, @TypeID, @CountryID, @NumberPhone, @WebSite)";
            string sName = SupplierName.Text, sPhone = SupplierContacts.Text, sWeb = webSite.Text;
            int sCountry = (int)country.SelectedValue, sType = (int)SupplierCategories.SelectedValue;
            if (this.detailNames != null && sName != "" && sPhone != "" && sWeb != "")
            {
                using (SqlCommand command = new SqlCommand(insertinto, MainForm.sqlConnection))
                {
                    command.Parameters.AddWithValue("@Name", sName);
                    command.Parameters.AddWithValue("@CountryID", sCountry);
                    command.Parameters.AddWithValue("@NumberPhone", sPhone);
                    command.Parameters.AddWithValue("@TypeID", sType);
                    command.Parameters.AddWithValue("@WebSite", sWeb);
                    int supplierID = (int)command.ExecuteScalar();
                    

                    foreach (string detailName in this.detailNames)
                    {
                        if (string.IsNullOrWhiteSpace(detailName))
                            continue;

                        // Разделяем строку на название и цену
                        string[] parts = detailName.Split(',');

                        // Проверяем, существует ли деталь
                        string checkQuery = "SELECT DetailID FROM Detail WHERE Name = @Name";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, MainForm.sqlConnection);
                        checkCommand.Parameters.AddWithValue("@Name", parts[0]);
                        object result = checkCommand.ExecuteScalar();

                        int detailID;

                        if (result == null)
                        {
                            // Добавляем новую деталь
                            string insertDetailQuery = "INSERT INTO Detail (Name) OUTPUT INSERTED.DetailID VALUES (@Name)";
                            SqlCommand insertCommand = new SqlCommand(insertDetailQuery, MainForm.sqlConnection);
                            insertCommand.Parameters.AddWithValue("@Name", parts[0]);
                            detailID = (int)insertCommand.ExecuteScalar();
                        }
                        else
                        {
                            detailID = (int)result;
                        }

                        decimal price = Convert.ToDecimal(parts[1]);

                        string insertSupplierDetailQuery = "INSERT INTO [SupplierDetails] (SupplierID, DetailID, Price) VALUES (@SupplierID, @DetailID, @Price)";
                        SqlCommand supplierDetailCommand = new SqlCommand(insertSupplierDetailQuery, MainForm.sqlConnection);
                        supplierDetailCommand.Parameters.AddWithValue("@SupplierID", supplierID);
                        supplierDetailCommand.Parameters.AddWithValue("@DetailID", detailID);
                        supplierDetailCommand.Parameters.AddWithValue("@Price", price);
                        supplierDetailCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Добавлено");
                }
            }
            else
            {
                MessageBox.Show("Загрузите список деталей и заполните поля");
            }
           
            LoadSupplier();
        }

       

        private void EditSupplier_Click(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            LoadCountriesToComboBox();
            LoadTypesToComboBox();
            LoadSupplier();
        }

        private void btnImportDetails_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                Title = "Выберите файл с деталями"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                // Читаем файл
                this.detailNames = File.ReadAllLines(openFileDialog.FileName);

                if (detailNames.Length == 0)
                {
                    MessageBox.Show("Файл пуст!");
                    return;
                }
                MessageBox.Show("Детали успешно импортированы!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при импорте деталей: " + ex.Message);
            }
        }
    }
}
