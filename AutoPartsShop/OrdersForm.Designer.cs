namespace AutoPartsShop
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.DetailsComboBox = new System.Windows.Forms.ComboBox();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.selectDetail = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.TextBox();
            this.searchDetail = new System.Windows.Forms.Button();
            this.DetailCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(550, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Заявки";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 619);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 567);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.DetailsComboBox);
            this.tabPage1.Controls.Add(this.SupplierComboBox);
            this.tabPage1.Controls.Add(this.selectDetail);
            this.tabPage1.Controls.Add(this.Details);
            this.tabPage1.Controls.Add(this.searchDetail);
            this.tabPage1.Controls.Add(this.DetailCount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.AddOrder);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(51, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 50);
            this.button1.TabIndex = 38;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailsComboBox
            // 
            this.DetailsComboBox.FormattingEnabled = true;
            this.DetailsComboBox.Location = new System.Drawing.Point(184, 121);
            this.DetailsComboBox.Name = "DetailsComboBox";
            this.DetailsComboBox.Size = new System.Drawing.Size(413, 21);
            this.DetailsComboBox.TabIndex = 37;
            this.DetailsComboBox.Visible = false;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(184, 175);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(413, 21);
            this.SupplierComboBox.TabIndex = 36;
            this.SupplierComboBox.Visible = false;
            // 
            // selectDetail
            // 
            this.selectDetail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.selectDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDetail.Location = new System.Drawing.Point(605, 122);
            this.selectDetail.Name = "selectDetail";
            this.selectDetail.Size = new System.Drawing.Size(62, 20);
            this.selectDetail.TabIndex = 35;
            this.selectDetail.Text = "Выбрать";
            this.selectDetail.UseVisualStyleBackColor = false;
            this.selectDetail.Visible = false;
            this.selectDetail.Click += new System.EventHandler(this.selectDetail_Click);
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(184, 73);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(413, 20);
            this.Details.TabIndex = 34;
            // 
            // searchDetail
            // 
            this.searchDetail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchDetail.Location = new System.Drawing.Point(605, 73);
            this.searchDetail.Name = "searchDetail";
            this.searchDetail.Size = new System.Drawing.Size(52, 20);
            this.searchDetail.TabIndex = 33;
            this.searchDetail.Text = "Поиск";
            this.searchDetail.UseVisualStyleBackColor = false;
            this.searchDetail.Click += new System.EventHandler(this.searchDetail_Click);
            // 
            // DetailCount
            // 
            this.DetailCount.Location = new System.Drawing.Point(184, 234);
            this.DetailCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DetailCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DetailCount.Name = "DetailCount";
            this.DetailCount.Size = new System.Drawing.Size(413, 20);
            this.DetailCount.TabIndex = 30;
            this.DetailCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Количество";
            // 
            // AddOrder
            // 
            this.AddOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddOrder.Location = new System.Drawing.Point(373, 292);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(224, 50);
            this.AddOrder.TabIndex = 26;
            this.AddOrder.Text = "Создать заявку";
            this.AddOrder.UseVisualStyleBackColor = false;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Деталь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Поставщик";
            this.label1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(12, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(230, 40);
            this.back.TabIndex = 10;
            this.back.Text = "Главная";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.orderDataGrid, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.50467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.495327F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // orderDataGrid
            // 
            this.orderDataGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.orderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGrid.Location = new System.Drawing.Point(3, 3);
            this.orderDataGrid.Name = "orderDataGrid";
            this.orderDataGrid.Size = new System.Drawing.Size(1252, 520);
            this.orderDataGrid.TabIndex = 2;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 619);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersForm_FormClosed);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown DetailCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Button selectDetail;
        private System.Windows.Forms.TextBox Details;
        private System.Windows.Forms.Button searchDetail;
        private System.Windows.Forms.ComboBox DetailsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView orderDataGrid;
    }
}