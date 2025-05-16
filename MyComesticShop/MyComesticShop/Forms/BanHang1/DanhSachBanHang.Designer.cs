
namespace MyComesticShop.Forms.BanHang1
{
    partial class DanhSachBanHang
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
            this.dgvDsBanHang = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsBanHang
            // 
            this.dgvDsBanHang.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDsBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsBanHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDsBanHang.Location = new System.Drawing.Point(0, 79);
            this.dgvDsBanHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDsBanHang.Name = "dgvDsBanHang";
            this.dgvDsBanHang.ReadOnly = true;
            this.dgvDsBanHang.RowHeadersVisible = false;
            this.dgvDsBanHang.RowHeadersWidth = 51;
            this.dgvDsBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsBanHang.Size = new System.Drawing.Size(1078, 329);
            this.dgvDsBanHang.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(196, 31);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(737, 24);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(111, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // DanhSachBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 408);
            this.Controls.Add(this.dgvDsBanHang);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachBanHang";
            this.Text = "Danh Sách Bán Hàng";
            this.Load += new System.EventHandler(this.DanhSachBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsBanHang;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}