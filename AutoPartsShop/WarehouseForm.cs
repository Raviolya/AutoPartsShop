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
    public partial class WarehouseForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void WarehouseForm_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
