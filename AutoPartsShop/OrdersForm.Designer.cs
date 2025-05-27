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
            this.DetailCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.AddOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditOrder = new System.Windows.Forms.Button();
            this.editStatus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.orderDataGrid2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.orderDataGrid = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid2)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.label4.Text = "Заказы";
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
            this.tabPage1.Controls.Add(this.DetailCount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ProductsComboBox);
            this.tabPage1.Controls.Add(this.SupplierComboBox);
            this.tabPage1.Controls.Add(this.AddOrder);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DetailCount
            // 
            this.DetailCount.Location = new System.Drawing.Point(165, 178);
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
            this.label3.Location = new System.Drawing.Point(48, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Количество";
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Location = new System.Drawing.Point(165, 129);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(413, 21);
            this.ProductsComboBox.TabIndex = 28;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(165, 70);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(413, 21);
            this.SupplierComboBox.TabIndex = 27;
            // 
            // AddOrder
            // 
            this.AddOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddOrder.Location = new System.Drawing.Point(51, 253);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(224, 50);
            this.AddOrder.TabIndex = 26;
            this.AddOrder.Text = "Создать заказ";
            this.AddOrder.UseVisualStyleBackColor = false;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Товар";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Поставщик";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1263, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1257, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EditOrder);
            this.panel2.Controls.Add(this.editStatus);
            this.panel2.Location = new System.Drawing.Point(3, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 48);
            this.panel2.TabIndex = 0;
            // 
            // EditOrder
            // 
            this.EditOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditOrder.Location = new System.Drawing.Point(3, 3);
            this.EditOrder.Name = "EditOrder";
            this.EditOrder.Size = new System.Drawing.Size(206, 40);
            this.EditOrder.TabIndex = 24;
            this.EditOrder.Text = "Обновить";
            this.EditOrder.UseVisualStyleBackColor = false;
            this.EditOrder.Click += new System.EventHandler(this.EditOrder_Click);
            // 
            // editStatus
            // 
            this.editStatus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.editStatus.Location = new System.Drawing.Point(239, 3);
            this.editStatus.Name = "editStatus";
            this.editStatus.Size = new System.Drawing.Size(224, 40);
            this.editStatus.TabIndex = 25;
            this.editStatus.Text = "Изменить статус";
            this.editStatus.UseVisualStyleBackColor = false;
            this.editStatus.Click += new System.EventHandler(this.editStatus_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1251, 475);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.orderDataGrid2);
            this.panel5.Location = new System.Drawing.Point(580, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(671, 472);
            this.panel5.TabIndex = 1;
            // 
            // orderDataGrid2
            // 
            this.orderDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGrid2.Location = new System.Drawing.Point(0, 0);
            this.orderDataGrid2.Name = "orderDataGrid2";
            this.orderDataGrid2.Size = new System.Drawing.Size(671, 472);
            this.orderDataGrid2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.orderDataGrid);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(571, 469);
            this.panel4.TabIndex = 0;
            // 
            // orderDataGrid
            // 
            this.orderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGrid.Location = new System.Drawing.Point(0, 0);
            this.orderDataGrid.Name = "orderDataGrid";
            this.orderDataGrid.Size = new System.Drawing.Size(571, 469);
            this.orderDataGrid.TabIndex = 1;
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
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 619);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editStatus;
        private System.Windows.Forms.Button EditOrder;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown DetailCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView orderDataGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView orderDataGrid2;
        private System.Windows.Forms.Panel panel4;
    }
}