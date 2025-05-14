namespace AutoPartsShop
{
    partial class ProductsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProductSave = new System.Windows.Forms.Button();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.EditProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dataProducts);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 457);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.ProductSave);
            this.panel2.Controls.Add(this.RemoveProduct);
            this.panel2.Controls.Add(this.EditProduct);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AddProduct);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1540, 172);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(175, 28);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(227, 20);
            this.ProductName.TabIndex = 1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(641, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номенклатура деталей";
            // 
            // dataProducts
            // 
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Location = new System.Drawing.Point(0, 41);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.Size = new System.Drawing.Size(1540, 416);
            this.dataProducts.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Производитель";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 8;
            // 
            // ProductSave
            // 
            this.ProductSave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ProductSave.Location = new System.Drawing.Point(1287, 108);
            this.ProductSave.Name = "ProductSave";
            this.ProductSave.Size = new System.Drawing.Size(224, 50);
            this.ProductSave.TabIndex = 12;
            this.ProductSave.Text = "Сохранить";
            this.ProductSave.UseVisualStyleBackColor = false;
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RemoveProduct.Location = new System.Drawing.Point(1020, 108);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(224, 50);
            this.RemoveProduct.TabIndex = 11;
            this.RemoveProduct.Text = "Удалить";
            this.RemoveProduct.UseVisualStyleBackColor = false;
            // 
            // EditProduct
            // 
            this.EditProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditProduct.Location = new System.Drawing.Point(756, 108);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(224, 50);
            this.EditProduct.TabIndex = 10;
            this.EditProduct.Text = "Изменить";
            this.EditProduct.UseVisualStyleBackColor = false;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProductSave;
        private System.Windows.Forms.Button RemoveProduct;
        private System.Windows.Forms.Button EditProduct;
    }
}