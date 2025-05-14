namespace AutoPartsShop
{
    partial class CustomerRequestsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductSave = new System.Windows.Forms.Button();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.EditProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.DetailCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.ProductSave);
            this.panel3.Controls.Add(this.RemoveProduct);
            this.panel3.Controls.Add(this.EditProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(745, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 163);
            this.panel3.TabIndex = 5;
            // 
            // ProductSave
            // 
            this.ProductSave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ProductSave.Location = new System.Drawing.Point(559, 108);
            this.ProductSave.Name = "ProductSave";
            this.ProductSave.Size = new System.Drawing.Size(224, 50);
            this.ProductSave.TabIndex = 9;
            this.ProductSave.Text = "Сохранить";
            this.ProductSave.UseVisualStyleBackColor = false;
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RemoveProduct.Location = new System.Drawing.Point(298, 108);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(224, 50);
            this.RemoveProduct.TabIndex = 8;
            this.RemoveProduct.Text = "Удалить";
            this.RemoveProduct.UseVisualStyleBackColor = false;
            // 
            // EditProduct
            // 
            this.EditProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditProduct.Location = new System.Drawing.Point(33, 108);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(224, 50);
            this.EditProduct.TabIndex = 7;
            this.EditProduct.Text = "Изменить";
            this.EditProduct.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.DetailCount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ProductsComboBox);
            this.panel2.Controls.Add(this.AddProduct);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 163);
            this.panel2.TabIndex = 4;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddProduct.Location = new System.Drawing.Point(477, 108);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(224, 50);
            this.AddProduct.TabIndex = 6;
            this.AddProduct.Text = "Добавить";
            this.AddProduct.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товар";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dataProducts);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 457);
            this.panel1.TabIndex = 3;
            // 
            // dataProducts
            // 
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Location = new System.Drawing.Point(0, 41);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.Size = new System.Drawing.Size(1540, 416);
            this.dataProducts.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(641, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Заявки клиентов";
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Location = new System.Drawing.Point(148, 23);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(227, 21);
            this.ProductsComboBox.TabIndex = 12;
            // 
            // DetailCount
            // 
            this.DetailCount.Location = new System.Drawing.Point(148, 67);
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
            this.DetailCount.TabIndex = 15;
            this.DetailCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Количество";
            // 
            // CustomerRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerRequestsForm";
            this.Text = "CustomerRequestsForm";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ProductSave;
        private System.Windows.Forms.Button RemoveProduct;
        private System.Windows.Forms.Button EditProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.NumericUpDown DetailCount;
        private System.Windows.Forms.Label label2;
    }
}