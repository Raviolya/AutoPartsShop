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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImportDetails = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.webSite = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SupplierCategories = new System.Windows.Forms.ComboBox();
            this.SupplierContacts = new System.Windows.Forms.TextBox();
            this.AddSupplier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditSupplier = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataSuppliers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 612);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 542);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Controls.Add(this.btnImportDetails);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.country);
            this.tabPage1.Controls.Add(this.webSite);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.SupplierCategories);
            this.tabPage1.Controls.Add(this.SupplierContacts);
            this.tabPage1.Controls.Add(this.AddSupplier);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SupplierName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1262, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            // 
            // btnImportDetails
            // 
            this.btnImportDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnImportDetails.Location = new System.Drawing.Point(886, 129);
            this.btnImportDetails.Name = "btnImportDetails";
            this.btnImportDetails.Size = new System.Drawing.Size(167, 27);
            this.btnImportDetails.TabIndex = 35;
            this.btnImportDetails.Text = "Загрузить";
            this.btnImportDetails.UseVisualStyleBackColor = false;
            this.btnImportDetails.Click += new System.EventHandler(this.btnImportDetails_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(530, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Загрузите список деталей поставщика:";
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Производитель",
            "Дилер",
            "Небольшое производство",
            "Мелкий поставщик",
            "Магазин"});
            this.country.Location = new System.Drawing.Point(164, 227);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(314, 21);
            this.country.TabIndex = 33;
            // 
            // webSite
            // 
            this.webSite.Location = new System.Drawing.Point(164, 277);
            this.webSite.Name = "webSite";
            this.webSite.Size = new System.Drawing.Size(314, 20);
            this.webSite.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(29, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Web-Site";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Страна";
            // 
            // SupplierCategories
            // 
            this.SupplierCategories.FormattingEnabled = true;
            this.SupplierCategories.Location = new System.Drawing.Point(164, 126);
            this.SupplierCategories.Name = "SupplierCategories";
            this.SupplierCategories.Size = new System.Drawing.Size(314, 21);
            this.SupplierCategories.TabIndex = 16;
            // 
            // SupplierContacts
            // 
            this.SupplierContacts.Location = new System.Drawing.Point(164, 176);
            this.SupplierContacts.Name = "SupplierContacts";
            this.SupplierContacts.Size = new System.Drawing.Size(314, 20);
            this.SupplierContacts.TabIndex = 15;
            // 
            // AddSupplier
            // 
            this.AddSupplier.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddSupplier.Location = new System.Drawing.Point(32, 344);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(224, 50);
            this.AddSupplier.TabIndex = 14;
            this.AddSupplier.Text = "Добавить";
            this.AddSupplier.UseVisualStyleBackColor = false;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Категория";
            // 
            // SupplierName
            // 
            this.SupplierName.Location = new System.Drawing.Point(164, 78);
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(314, 20);
            this.SupplierName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1262, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотреть";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EditSupplier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 45);
            this.panel2.TabIndex = 1;
            // 
            // EditSupplier
            // 
            this.EditSupplier.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditSupplier.Location = new System.Drawing.Point(3, 3);
            this.EditSupplier.Name = "EditSupplier";
            this.EditSupplier.Size = new System.Drawing.Size(212, 36);
            this.EditSupplier.TabIndex = 10;
            this.EditSupplier.Text = "Обновить";
            this.EditSupplier.UseVisualStyleBackColor = false;
            this.EditSupplier.Click += new System.EventHandler(this.EditSupplier_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataSuppliers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 453);
            this.panel3.TabIndex = 2;
            // 
            // dataSuppliers
            // 
            this.dataSuppliers.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSuppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataSuppliers.Location = new System.Drawing.Point(0, 0);
            this.dataSuppliers.Name = "dataSuppliers";
            this.dataSuppliers.Size = new System.Drawing.Size(1271, 453);
            this.dataSuppliers.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(490, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Список поставщиков";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(12, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(224, 31);
            this.back.TabIndex = 10;
            this.back.Text = "Главная";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 612);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel1);
            this.Name = "SuppliersForm";
            this.Text = "SuppliersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SuppliersForm_FormClosed);
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button EditSupplier;
        private System.Windows.Forms.ComboBox SupplierCategories;
        private System.Windows.Forms.TextBox SupplierContacts;
        private System.Windows.Forms.Button AddSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataSuppliers;
        private System.Windows.Forms.TextBox webSite;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Button btnImportDetails;
        private System.Windows.Forms.Label label6;
    }
}