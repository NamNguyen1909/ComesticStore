
namespace MyComesticShop.Forms.KhuyenMai
{
    partial class TimKiemMaKMFrm
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
            this.components = new System.ComponentModel.Container();
            this.dgvMaKhuyenMai = new System.Windows.Forms.DataGridView();
            this.txtSearchMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaKhuyenMai)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaKhuyenMai
            // 
            this.dgvMaKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaKhuyenMai.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMaKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaKhuyenMai.Location = new System.Drawing.Point(-1, 28);
            this.dgvMaKhuyenMai.Name = "dgvMaKhuyenMai";
            this.dgvMaKhuyenMai.ReadOnly = true;
            this.dgvMaKhuyenMai.RowHeadersVisible = false;
            this.dgvMaKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaKhuyenMai.Size = new System.Drawing.Size(679, 376);
            this.dgvMaKhuyenMai.TabIndex = 9;
            this.dgvMaKhuyenMai.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaKhuyenMai_CellContentDoubleClick);
            this.dgvMaKhuyenMai.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaKhuyenMai_CellDoubleClick);
            // 
            // txtSearchMaKhuyenMai
            // 
            this.txtSearchMaKhuyenMai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSearchMaKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaKhuyenMai.Location = new System.Drawing.Point(-1, 2);
            this.txtSearchMaKhuyenMai.Name = "txtSearchMaKhuyenMai";
            this.txtSearchMaKhuyenMai.Size = new System.Drawing.Size(679, 23);
            this.txtSearchMaKhuyenMai.TabIndex = 8;
            this.txtSearchMaKhuyenMai.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 28);
            // 
            // SelectToolStripMenuItem
            // 
            this.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            this.SelectToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.SelectToolStripMenuItem.Text = "Chọn";
            this.SelectToolStripMenuItem.Click += new System.EventHandler(this.SelectToolStripMenuItem_Click);
            // 
            // TimKiemMaKMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 405);
            this.Controls.Add(this.dgvMaKhuyenMai);
            this.Controls.Add(this.txtSearchMaKhuyenMai);
            this.Name = "TimKiemMaKMFrm";
            this.Text = "TimKiemMaKM";
            this.Activated += new System.EventHandler(this.TimKiemMaKMFrm_Activated);
            this.Load += new System.EventHandler(this.TimKiemMaKMFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimKiemMaKMFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaKhuyenMai)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaKhuyenMai;
        private System.Windows.Forms.TextBox txtSearchMaKhuyenMai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SelectToolStripMenuItem;
    }
}