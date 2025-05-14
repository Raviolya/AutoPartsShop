namespace AutoPartsShop
{
    partial class SuppliersForm
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
            this.AddSupplier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierContacts = new System.Windows.Forms.TextBox();
            this.SupplierCategories = new System.Windows.Forms.ComboBox();
            this.SupplierSave = new System.Windows.Forms.Button();
            this.RemoveSupplier = new System.Windows.Forms.Button();
            this.EditSupplier = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.SupplierSave);
            this.panel2.Controls.Add(this.RemoveSupplier);
            this.panel2.Controls.Add(this.EditSupplier);
            this.panel2.Controls.Add(this.SupplierCategories);
            this.panel2.Controls.Add(this.SupplierContacts);
            this.panel2.Controls.Add(this.AddSupplier);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SupplierName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1544, 173);
            this.panel2.TabIndex = 4;
            // 
            // AddSupplier
            // 
            this.AddSupplier.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddSupplier.Location = new System.Drawing.Point(420, 111);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(224, 50);
            this.AddSupplier.TabIndex = 6;
            this.AddSupplier.Text = "Добавить";
            this.AddSupplier.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Контакты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория";
            // 
            // SupplierName
            // 
            this.SupplierName.Location = new System.Drawing.Point(148, 23);
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(227, 20);
            this.SupplierName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dataSuppliers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1544, 457);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(654, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Список поставщиков";
            // 
            // dataSuppliers
            // 
            this.dataSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSuppliers.Location = new System.Drawing.Point(0, 35);
            this.dataSuppliers.Name = "dataSuppliers";
            this.dataSuppliers.Size = new System.Drawing.Size(1544, 422);
            this.dataSuppliers.TabIndex = 1;
            // 
            // SupplierContacts
            // 
            this.SupplierContacts.Location = new System.Drawing.Point(148, 121);
            this.SupplierContacts.Name = "SupplierContacts";
            this.SupplierContacts.Size = new System.Drawing.Size(227, 20);
            this.SupplierContacts.TabIndex = 8;
            // 
            // SupplierCategories
            // 
            this.SupplierCategories.FormattingEnabled = true;
            this.SupplierCategories.Items.AddRange(new object[] {
            "Фирма",
            "Производитель",
            "Дилер",
            "Небольшое производство",
            "Мелкий поставщик",
            "Магазин"});
            this.SupplierCategories.Location = new System.Drawing.Point(148, 70);
            this.SupplierCategories.Name = "SupplierCategories";
            this.SupplierCategories.Size = new System.Drawing.Size(227, 21);
            this.SupplierCategories.TabIndex = 9;
            // 
            // SupplierSave
            // 
            this.SupplierSave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SupplierSave.Location = new System.Drawing.Point(1250, 108);
            this.SupplierSave.Name = "SupplierSave";
            this.SupplierSave.Size = new System.Drawing.Size(224, 50);
            this.SupplierSave.TabIndex = 12;
            this.SupplierSave.Text = "Сохранить";
            this.SupplierSave.UseVisualStyleBackColor = false;
            // 
            // RemoveSupplier
            // 
            this.RemoveSupplier.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RemoveSupplier.Location = new System.Drawing.Point(993, 108);
            this.RemoveSupplier.Name = "RemoveSupplier";
            this.RemoveSupplier.Size = new System.Drawing.Size(224, 50);
            this.RemoveSupplier.TabIndex = 11;
            this.RemoveSupplier.Text = "Удалить";
            this.RemoveSupplier.UseVisualStyleBackColor = false;
            // 
            // EditSupplier
            // 
            this.EditSupplier.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditSupplier.Location = new System.Drawing.Point(743, 108);
            this.EditSupplier.Name = "EditSupplier";
            this.EditSupplier.Size = new System.Drawing.Size(224, 50);
            this.EditSupplier.TabIndex = 10;
            this.EditSupplier.Text = "Изменить";
            this.EditSupplier.UseVisualStyleBackColor = false;
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SuppliersForm";
            this.Text = "SuppliersForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataSuppliers;
        private System.Windows.Forms.TextBox SupplierContacts;
        private System.Windows.Forms.ComboBox SupplierCategories;
        private System.Windows.Forms.Button SupplierSave;
        private System.Windows.Forms.Button RemoveSupplier;
        private System.Windows.Forms.Button EditSupplier;
    }
}