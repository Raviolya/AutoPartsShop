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
    public partial class StatisticsForm : Form
    {
        public MainForm MainForm { get; set; } // Свойство для хранения MainForm
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
