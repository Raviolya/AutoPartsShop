namespace AutoPartsShop
{
    partial class WarehouseForm
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
            this.EditDetail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddDefect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataWafehouse = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveDetail = new System.Windows.Forms.Button();
            this.RemoveDetail = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWafehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // EditDetail
            // 
            this.EditDetail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditDetail.Location = new System.Drawing.Point(395, 101);
            this.EditDetail.Name = "EditDetail";
            this.EditDetail.Size = new System.Drawing.Size(224, 50);
            this.EditDetail.TabIndex = 7;
            this.EditDetail.Text = "Изменить";
            this.EditDetail.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.SaveDetail);
            this.panel2.Controls.Add(this.RemoveDetail);
            this.panel2.Controls.Add(this.AddDefect);
            this.panel2.Controls.Add(this.EditDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1539, 163);
            this.panel2.TabIndex = 7;
            // 
            // AddDefect
            // 
            this.AddDefect.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddDefect.Location = new System.Drawing.Point(12, 101);
            this.AddDefect.Name = "AddDefect";
            this.AddDefect.Size = new System.Drawing.Size(224, 50);
            this.AddDefect.TabIndex = 6;
            this.AddDefect.Text = "Зарегистрировать брак";
            this.AddDefect.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dataWafehouse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 457);
            this.panel1.TabIndex = 6;
            // 
            // dataWafehouse
            // 
            this.dataWafehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWafehouse.Location = new System.Drawing.Point(0, 35);
            this.dataWafehouse.Name = "dataWafehouse";
            this.dataWafehouse.Size = new System.Drawing.Size(1544, 422);
            this.dataWafehouse.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(695, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Склад";
            // 
            // SaveDetail
            // 
            this.SaveDetail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SaveDetail.Location = new System.Drawing.Point(1268, 101);
            this.SaveDetail.Name = "SaveDetail";
            this.SaveDetail.Size = new System.Drawing.Size(224, 50);
            this.SaveDetail.TabIndex = 11;
            this.SaveDetail.Text = "Сохранить";
            this.SaveDetail.UseVisualStyleBackColor = false;
            // 
            // RemoveDetail
            // 
            this.RemoveDetail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RemoveDetail.Location = new System.Drawing.Point(807, 101);
            this.RemoveDetail.Name = "RemoveDetail";
            this.RemoveDetail.Size = new System.Drawing.Size(224, 50);
            this.RemoveDetail.TabIndex = 10;
            this.RemoveDetail.Text = "Удалить";
            this.RemoveDetail.UseVisualStyleBackColor = false;
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWafehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EditDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddDefect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataWafehouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveDetail;
        private System.Windows.Forms.Button RemoveDetail;
    }
}