﻿namespace baitaplonquanlycuahangbanquanao
{
    partial class f_doanhthu_chi
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
            this.dataGridView_chitietDNH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chitietDNH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_chitietDNH
            // 
            this.dataGridView_chitietDNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chitietDNH.Location = new System.Drawing.Point(12, 11);
            this.dataGridView_chitietDNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_chitietDNH.Name = "dataGridView_chitietDNH";
            this.dataGridView_chitietDNH.RowHeadersWidth = 51;
            this.dataGridView_chitietDNH.RowTemplate.Height = 24;
            this.dataGridView_chitietDNH.Size = new System.Drawing.Size(1123, 428);
            this.dataGridView_chitietDNH.TabIndex = 2;
            // 
            // f_doanhthu_chi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.dataGridView_chitietDNH);
            this.Name = "f_doanhthu_chi";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.f_doanhthu_chi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chitietDNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_chitietDNH;
    }
}