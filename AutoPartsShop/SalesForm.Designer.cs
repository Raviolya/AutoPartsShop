namespace AutoPartsShop
{
    partial class SalesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.AddSale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SupplierSale = new System.Windows.Forms.Button();
            this.RemoveSale = new System.Windows.Forms.Button();
            this.EditSale = new System.Windows.Forms.Button();
            this.Statistica = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-7, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1556, 234);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.Statistica);
            this.panel4.Controls.Add(this.SupplierSale);
            this.panel4.Controls.Add(this.RemoveSale);
            this.panel4.Controls.Add(this.EditSale);
            this.panel4.Controls.Add(this.ProductCount);
            this.panel4.Controls.Add(this.ProductsComboBox);
            this.panel4.Controls.Add(this.AddSale);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(7, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1543, 212);
            this.panel4.TabIndex = 6;
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Location = new System.Drawing.Point(143, 69);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(227, 21);
            this.ProductsComboBox.TabIndex = 11;
            // 
            // AddSale
            // 
            this.AddSale.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddSale.Location = new System.Drawing.Point(494, 136);
            this.AddSale.Name = "AddSale";
            this.AddSale.Size = new System.Drawing.Size(224, 50);
            this.AddSale.TabIndex = 6;
            this.AddSale.Text = "Добавить";
            this.AddSale.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товар";
            // 
            // ProductCount
            // 
            this.ProductCount.Location = new System.Drawing.Point(143, 140);
            this.ProductCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProductCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Size = new System.Drawing.Size(227, 20);
            this.ProductCount.TabIndex = 14;
            this.ProductCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(698, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Продажи";
            // 
            // dataSales
            // 
            this.dataSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSales.Location = new System.Drawing.Point(-4, 36);
            this.dataSales.Name = "dataSales";
            this.dataSales.Size = new System.Drawing.Size(1544, 354);
            this.dataSales.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dataSales);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 393);
            this.panel1.TabIndex = 2;
            // 
            // SupplierSale
            // 
            this.SupplierSale.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SupplierSale.Location = new System.Drawing.Point(1307, 136);
            this.SupplierSale.Name = "SupplierSale";
            this.SupplierSale.Size = new System.Drawing.Size(224, 50);
            this.SupplierSale.TabIndex = 17;
            this.SupplierSale.Text = "Сохранить";
            this.SupplierSale.UseVisualStyleBackColor = false;
            // 
            // RemoveSale
            // 
            this.RemoveSale.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RemoveSale.Location = new System.Drawing.Point(1039, 136);
            this.RemoveSale.Name = "RemoveSale";
            this.RemoveSale.Size = new System.Drawing.Size(224, 50);
            this.RemoveSale.TabIndex = 16;
            this.RemoveSale.Text = "Удалить";
            this.RemoveSale.UseVisualStyleBackColor = false;
            // 
            // EditSale
            // 
            this.EditSale.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditSale.Location = new System.Drawing.Point(782, 136);
            this.EditSale.Name = "EditSale";
            this.EditSale.Size = new System.Drawing.Size(224, 50);
            this.EditSale.TabIndex = 15;
            this.EditSale.Text = "Изменить";
            this.EditSale.UseVisualStyleBackColor = false;
            // 
            // Statistica
            // 
            this.Statistica.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Statistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statistica.Location = new System.Drawing.Point(494, 40);
            this.Statistica.Name = "Statistica";
            this.Statistica.Size = new System.Drawing.Size(1037, 50);
            this.Statistica.TabIndex = 18;
            this.Statistica.Text = "Отобразить подробный отчёт о продажах";
            this.Statistica.UseVisualStyleBackColor = false;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.Button AddSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ProductCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SupplierSale;
        private System.Windows.Forms.Button RemoveSale;
        private System.Windows.Forms.Button EditSale;
        private System.Windows.Forms.Button Statistica;
    }
}