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
    public partial class SuppliersForm : Form
    {
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

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            string category = Convert.ToString(SupplierCategories.SelectedItem);
            string insertinto = "INSERT INTO Suppliers (Name, Country, ContactInfo, SupplierType) VALUES (@Name, @Country, @ContactInfo, @Type)";
            switch (category)
                {
                    case "Производитель":
                        if (contractDetails.Text == null || contractDetails.Text == "")
                        {
                            MessageBox.Show("Заполните поля");
                            return;
                        }
                        
                        using (SqlCommand command = new SqlCommand(insertinto, MainForm.sqlConnection))
                        {
                            command.Parameters.AddWithValue("@Name", SupplierName.Text);
                            command.Parameters.AddWithValue("@Country", country.Text);
                            command.Parameters.AddWithValue("@ContactInfo", SupplierContacts.Text);
                            command.Parameters.AddWithValue("@Type", category);

                            int supplierId = Convert.ToInt32(command.ExecuteScalar());

                            string insert = "INSERT INTO Manufacturers (SupplierId, WarrantyPeriod, ContractDetails) VALUES (@a, @b, N'@c')";
                            using (SqlCommand com = new SqlCommand(insert, MainForm.sqlConnection))
                            {
                                com.Parameters.AddWithValue("@a", supplierId);
                                com.Parameters.AddWithValue("@b", warrantyPeriod.Value);
                                com.Parameters.AddWithValue("@c", contractDetails.Text);

                                com.ExecuteNonQuery();
                            }
                        }

                        break;


                    case "Дилер":

                        if (contractDetails.Text == null || contractDetails.Text == "")
                        {
                            MessageBox.Show("Заполните поля");
                            return;
                        }
                        using (SqlCommand command = new SqlCommand(insertinto, MainForm.sqlConnection))
                        {
                            command.Parameters.AddWithValue("@Name", SupplierName.Text);
                            command.Parameters.AddWithValue("@Country", country.Text);
                            command.Parameters.AddWithValue("@ContactInfo", SupplierContacts.Text);
                            command.Parameters.AddWithValue("@Type", category);

                            int supplierId = Convert.ToInt32(command.ExecuteScalar());

                            string insert = "INSERT INTO Dealers (SupplierId, WarrantyPeriod, ContractDetails, DiscountRate) VALUES (@a, @b, N'@c', d)";
                            using (SqlCommand com = new SqlCommand(insert, MainForm.sqlConnection))
                            {
                                com.Parameters.AddWithValue("@a", supplierId);
                                com.Parameters.AddWithValue("@b", warrantyPeriod.Value);
                                com.Parameters.AddWithValue("@c", contractDetails.Text);
                                com.Parameters.AddWithValue("@d", discountRate.Value);

                                com.ExecuteNonQuery();
                            }
                        }
                        break;

                case "Мелкий поставщик":
                    if (specialization.Text == null || specialization.Text == "")
                    {
                        MessageBox.Show("Заполните поля");
                        return;
                    }
                   
                    using (SqlCommand command = new SqlCommand(insertinto, MainForm.sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Name", SupplierName.Text);
                        command.Parameters.AddWithValue("@Country", country.Text);
                        command.Parameters.AddWithValue("@ContactInfo", SupplierContacts.Text);
                        command.Parameters.AddWithValue("@Type", category);

                        int supplierId = Convert.ToInt32(command.ExecuteScalar());

                        string insert = "INSERT INTO SmallSuppliers (SupplierId, Specialization) VALUES (@a, @b)";
                        using (SqlCommand com = new SqlCommand(insert, MainForm.sqlConnection))
                        {
                            com.Parameters.AddWithValue("@a", supplierId);
                            com.Parameters.AddWithValue("@b", specialization.Text);

                            com.ExecuteNonQuery();
                        }
                    }
                    break;

                case "Магазин":
                    if (location.Text == null || location.Text == "")
                    {
                        MessageBox.Show("Заполните поля");
                        return;
                    }
                    using (SqlCommand command = new SqlCommand(insertinto, MainForm.sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Name", SupplierName.Text);
                        command.Parameters.AddWithValue("@Country", country.Text);
                        command.Parameters.AddWithValue("@ContactInfo", SupplierContacts.Text);
                        command.Parameters.AddWithValue("@Type", category);

                        int supplierId = Convert.ToInt32(command.ExecuteScalar());

                        string insert = "INSERT INTO Shops (SupplierId, Location) VALUES (@a, @b)";
                        using (SqlCommand com = new SqlCommand(insert, MainForm.sqlConnection))
                        {
                            com.Parameters.AddWithValue("@a", supplierId);
                            com.Parameters.AddWithValue("@b", location.Text);

                            com.ExecuteNonQuery();
                        }
                    }
                    break;

                case "Небольшое производство":
                    using (SqlCommand command = new SqlCommand(insertinto, MainForm.sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Name", SupplierName.Text);
                        command.Parameters.AddWithValue("@Country", country.Text);
                        command.Parameters.AddWithValue("@ContactInfo", SupplierContacts.Text);
                        command.Parameters.AddWithValue("@Type", category);

                        int supplierId = Convert.ToInt32(command.ExecuteScalar());

                        string insert = "INSERT INTO SmallProductions (SupplierId, ProductionCapacity) VALUES (@a, @b)";
                        using (SqlCommand com = new SqlCommand(insert, MainForm.sqlConnection))
                        {
                            com.Parameters.AddWithValue("@a", supplierId);
                            com.Parameters.AddWithValue("@b", productionCapacity.Value);

                            com.ExecuteNonQuery();
                        }
                    }
                    break;

            }
        }

        private void SupplierCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = Convert.ToString(SupplierCategories.SelectedItem);

            switch (category)
            {
                case "Производитель":
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    warrantyPeriod.Visible = true;
                    contractDetails.Visible = true;
                    discountRate.Visible = false;
                    specialization.Visible = false;
                    location.Visible = false;
                    productionCapacity.Visible = false;
                    break;
                case "Дилер":
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    warrantyPeriod.Visible = true;
                    contractDetails.Visible = true;
                    discountRate.Visible = true;
                    specialization.Visible = false;
                    location.Visible = false;
                    productionCapacity.Visible = false;
                    break;
                case "Мелкий поставщик":
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;
                    warrantyPeriod.Visible = false;
                    contractDetails.Visible = false;
                    discountRate.Visible = false;
                    specialization.Visible = true;
                    location.Visible = false;
                    productionCapacity.Visible = false;
                    break;
                case "Магазин":
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = true;
                    label11.Visible = false;
                    warrantyPeriod.Visible = false;
                    contractDetails.Visible = false;
                    discountRate.Visible = false;
                    specialization.Visible = false;
                    location.Visible = true;
                    productionCapacity.Visible = false;
                    break;
                case "Небольшое производство":
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = true;
                    warrantyPeriod.Visible = false;
                    contractDetails.Visible = false;
                    discountRate.Visible = false;
                    specialization.Visible = false;
                    location.Visible = false;
                    productionCapacity.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
