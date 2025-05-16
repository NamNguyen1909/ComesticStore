
namespace MyComesticShop.Forms.NhapHang
{
    partial class DanhSachNhapHang
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
            this.dgvDsNhapHang = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsNhapHang
            // 
            this.dgvDsNhapHang.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDsNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsNhapHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDsNhapHang.Location = new System.Drawing.Point(0, 123);
            this.dgvDsNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDsNhapHang.Name = "dgvDsNhapHang";
            this.dgvDsNhapHang.ReadOnly = true;
            this.dgvDsNhapHang.RowHeadersVisible = false;
            this.dgvDsNhapHang.RowHeadersWidth = 51;
            this.dgvDsNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsNhapHang.Size = new System.Drawing.Size(961, 329);
            this.dgvDsNhapHang.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(139, 59);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(737, 24);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // DanhSachNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 452);
            this.Controls.Add(this.dgvDsNhapHang);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachNhapHang";
            this.Text = "DanhSachNhapHang";
            this.Load += new System.EventHandler(this.DanhSachNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsNhapHang;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}