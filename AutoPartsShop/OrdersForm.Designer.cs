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
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SupplierOrder = new System.Windows.Forms.Button();
            this.RemoveOrder = new System.Windows.Forms.Button();
            this.EditOrder = new System.Windows.Forms.Button();
            this.DetailCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.AddOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(698, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Заказы";
            // 
            // dataOrders
            // 
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Location = new System.Drawing.Point(0, 36);
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.Size = new System.Drawing.Size(1553, 347);
            this.dataOrders.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dataOrders);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 386);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.SupplierOrder);
            this.panel4.Controls.Add(this.RemoveOrder);
            this.panel4.Controls.Add(this.EditOrder);
            this.panel4.Controls.Add(this.DetailCount);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ProductsComboBox);
            this.panel4.Controls.Add(this.SupplierComboBox);
            this.panel4.Controls.Add(this.AddOrder);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 383);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1553, 236);
            this.panel4.TabIndex = 8;
            // 
            // SupplierOrder
            // 
            this.SupplierOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SupplierOrder.Location = new System.Drawing.Point(1296, 160);
            this.SupplierOrder.Name = "SupplierOrder";
            this.SupplierOrder.Size = new System.Drawing.Size(224, 50);
            this.SupplierOrder.TabIndex = 26;
            this.SupplierOrder.Text = "Сохранить";
            this.SupplierOrder.UseVisualStyleBackColor = false;
            // 
            // RemoveOrder
            // 
            this.RemoveOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RemoveOrder.Location = new System.Drawing.Point(1022, 160);
            this.RemoveOrder.Name = "RemoveOrder";
            this.RemoveOrder.Size = new System.Drawing.Size(224, 50);
            this.RemoveOrder.TabIndex = 25;
            this.RemoveOrder.Text = "Удалить";
            this.RemoveOrder.UseVisualStyleBackColor = false;
            // 
            // EditOrder
            // 
            this.EditOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditOrder.Location = new System.Drawing.Point(750, 160);
            this.EditOrder.Name = "EditOrder";
            this.EditOrder.Size = new System.Drawing.Size(224, 50);
            this.EditOrder.TabIndex = 24;
            this.EditOrder.Text = "Изменить";
            this.EditOrder.UseVisualStyleBackColor = false;
            // 
            // DetailCount
            // 
            this.DetailCount.Location = new System.Drawing.Point(156, 124);
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
            this.DetailCount.Size = new System.Drawing.Size(227, 20);
            this.DetailCount.TabIndex = 23;
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
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Количество";
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Location = new System.Drawing.Point(156, 75);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(227, 21);
            this.ProductsComboBox.TabIndex = 21;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(156, 16);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(227, 21);
            this.SupplierComboBox.TabIndex = 20;
            // 
            // AddOrder
            // 
            this.AddOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddOrder.Location = new System.Drawing.Point(400, 160);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(224, 50);
            this.AddOrder.TabIndex = 19;
            this.AddOrder.Text = "Создать заказ";
            this.AddOrder.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Товар";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Поставщик";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 619);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SupplierOrder;
        private System.Windows.Forms.Button RemoveOrder;
        private System.Windows.Forms.Button EditOrder;
        private System.Windows.Forms.NumericUpDown DetailCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}