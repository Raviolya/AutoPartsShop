namespace AutoPartsShop
{
    partial class DefectsForm
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
            this.RemoveDefect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSuppliers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.RemoveDefect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1534, 167);
            this.panel3.TabIndex = 8;
            // 
            // RemoveDefect
            // 
            this.RemoveDefect.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RemoveDefect.Location = new System.Drawing.Point(1279, 105);
            this.RemoveDefect.Name = "RemoveDefect";
            this.RemoveDefect.Size = new System.Drawing.Size(224, 50);
            this.RemoveDefect.TabIndex = 8;
            this.RemoveDefect.Text = "Удалить";
            this.RemoveDefect.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.dataSuppliers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 457);
            this.panel1.TabIndex = 6;
            // 
            // dataSuppliers
            // 
            this.dataSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSuppliers.Location = new System.Drawing.Point(0, 35);
            this.dataSuppliers.Name = "dataSuppliers";
            this.dataSuppliers.Size = new System.Drawing.Size(1544, 422);
            this.dataSuppliers.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(638, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Бракованные товары";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(12, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(224, 26);
            this.back.TabIndex = 9;
            this.back.Text = "Главная";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // DefectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 624);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "DefectsForm";
            this.Text = "DefectsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DefectsForm_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RemoveDefect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataSuppliers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
    }
}