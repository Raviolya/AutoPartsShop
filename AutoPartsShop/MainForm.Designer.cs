namespace AutoPartsShop
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button_StatisticsForm = new System.Windows.Forms.Button();
            this.button_WarehouseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DefectsForm = new System.Windows.Forms.Button();
            this.button_SalesForm = new System.Windows.Forms.Button();
            this.button_CustomerRequestsForm = new System.Windows.Forms.Button();
            this.button_OrdersForm = new System.Windows.Forms.Button();
            this.button_SuppliersForm = new System.Windows.Forms.Button();
            this.button_ProductsForm = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MainPanel.Controls.Add(this.button_StatisticsForm);
            this.MainPanel.Controls.Add(this.button_WarehouseForm);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.button_DefectsForm);
            this.MainPanel.Controls.Add(this.button_SalesForm);
            this.MainPanel.Controls.Add(this.button_CustomerRequestsForm);
            this.MainPanel.Controls.Add(this.button_OrdersForm);
            this.MainPanel.Controls.Add(this.button_SuppliersForm);
            this.MainPanel.Controls.Add(this.button_ProductsForm);
            this.MainPanel.Location = new System.Drawing.Point(-1, -1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1544, 632);
            this.MainPanel.TabIndex = 0;
            // 
            // button_StatisticsForm
            // 
            this.button_StatisticsForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_StatisticsForm.Location = new System.Drawing.Point(1254, 490);
            this.button_StatisticsForm.Name = "button_StatisticsForm";
            this.button_StatisticsForm.Size = new System.Drawing.Size(192, 84);
            this.button_StatisticsForm.TabIndex = 9;
            this.button_StatisticsForm.Text = "Статистика";
            this.button_StatisticsForm.UseVisualStyleBackColor = false;
            this.button_StatisticsForm.Click += new System.EventHandler(this.button_StatisticsForm_Click);
            // 
            // button_WarehouseForm
            // 
            this.button_WarehouseForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WarehouseForm.Location = new System.Drawing.Point(704, 490);
            this.button_WarehouseForm.Name = "button_WarehouseForm";
            this.button_WarehouseForm.Size = new System.Drawing.Size(192, 84);
            this.button_WarehouseForm.TabIndex = 8;
            this.button_WarehouseForm.Text = "Склад";
            this.button_WarehouseForm.UseVisualStyleBackColor = false;
            this.button_WarehouseForm.Click += new System.EventHandler(this.button_WarehouseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Информационная система нашего магазина";
            // 
            // button_DefectsForm
            // 
            this.button_DefectsForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_DefectsForm.Location = new System.Drawing.Point(95, 490);
            this.button_DefectsForm.Name = "button_DefectsForm";
            this.button_DefectsForm.Size = new System.Drawing.Size(192, 84);
            this.button_DefectsForm.TabIndex = 5;
            this.button_DefectsForm.Text = "Браки";
            this.button_DefectsForm.UseVisualStyleBackColor = false;
            this.button_DefectsForm.Click += new System.EventHandler(this.button_DefectsForm_Click);
            // 
            // button_SalesForm
            // 
            this.button_SalesForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SalesForm.Location = new System.Drawing.Point(95, 320);
            this.button_SalesForm.Name = "button_SalesForm";
            this.button_SalesForm.Size = new System.Drawing.Size(192, 84);
            this.button_SalesForm.TabIndex = 4;
            this.button_SalesForm.Text = "Продажи";
            this.button_SalesForm.UseVisualStyleBackColor = false;
            this.button_SalesForm.Click += new System.EventHandler(this.button_SalesForm_Click);
            // 
            // button_CustomerRequestsForm
            // 
            this.button_CustomerRequestsForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_CustomerRequestsForm.Location = new System.Drawing.Point(1254, 320);
            this.button_CustomerRequestsForm.Name = "button_CustomerRequestsForm";
            this.button_CustomerRequestsForm.Size = new System.Drawing.Size(192, 84);
            this.button_CustomerRequestsForm.TabIndex = 3;
            this.button_CustomerRequestsForm.Text = "Заполнить заявку";
            this.button_CustomerRequestsForm.UseVisualStyleBackColor = false;
            this.button_CustomerRequestsForm.Click += new System.EventHandler(this.button_CustomerRequestsForm_Click);
            // 
            // button_OrdersForm
            // 
            this.button_OrdersForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_OrdersForm.Location = new System.Drawing.Point(1254, 155);
            this.button_OrdersForm.Name = "button_OrdersForm";
            this.button_OrdersForm.Size = new System.Drawing.Size(192, 84);
            this.button_OrdersForm.TabIndex = 2;
            this.button_OrdersForm.Text = "Заказы";
            this.button_OrdersForm.UseVisualStyleBackColor = false;
            this.button_OrdersForm.Click += new System.EventHandler(this.button_OrdersForm_Click);
            // 
            // button_SuppliersForm
            // 
            this.button_SuppliersForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SuppliersForm.Location = new System.Drawing.Point(704, 155);
            this.button_SuppliersForm.Name = "button_SuppliersForm";
            this.button_SuppliersForm.Size = new System.Drawing.Size(192, 84);
            this.button_SuppliersForm.TabIndex = 1;
            this.button_SuppliersForm.Text = "Управление списком поставщиков";
            this.button_SuppliersForm.UseVisualStyleBackColor = false;
            this.button_SuppliersForm.Click += new System.EventHandler(this.button_SuppliersForm_Click);
            // 
            // button_ProductsForm
            // 
            this.button_ProductsForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ProductsForm.Location = new System.Drawing.Point(95, 155);
            this.button_ProductsForm.Name = "button_ProductsForm";
            this.button_ProductsForm.Size = new System.Drawing.Size(192, 84);
            this.button_ProductsForm.TabIndex = 0;
            this.button_ProductsForm.Text = "Управление номенклатурой товаров";
            this.button_ProductsForm.UseVisualStyleBackColor = false;
            this.button_ProductsForm.Click += new System.EventHandler(this.button_ProductsForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 628);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button button_DefectsForm;
        private System.Windows.Forms.Button button_SalesForm;
        private System.Windows.Forms.Button button_CustomerRequestsForm;
        private System.Windows.Forms.Button button_OrdersForm;
        private System.Windows.Forms.Button button_SuppliersForm;
        private System.Windows.Forms.Button button_ProductsForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_StatisticsForm;
        private System.Windows.Forms.Button button_WarehouseForm;
    }
}

