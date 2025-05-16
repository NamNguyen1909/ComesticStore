
namespace MyComesticShop.Forms.BanHang1
{
    partial class BanHangFrm
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
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSaleConfirm = new System.Windows.Forms.Button();
            this.byPurCancel = new System.Windows.Forms.Button();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvSaleCart = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbItemCost = new System.Windows.Forms.Label();
            this.txtSaleUnitPrice = new System.Windows.Forms.TextBox();
            this.txtSaleQty = new System.Windows.Forms.TextBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbContactNo = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCurrentSaleUnitPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCurrentQty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btApDung = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPhanTramGiam = new System.Windows.Forms.Label();
            this.lbSoTienGiam = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbThongTinKM = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTieuDeKM = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleCart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(327, 602);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(227, 65);
            this.txtComments.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ghi Chú";
            // 
            // btSaleConfirm
            // 
            this.btSaleConfirm.BackColor = System.Drawing.Color.Green;
            this.btSaleConfirm.FlatAppearance.BorderSize = 0;
            this.btSaleConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaleConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSaleConfirm.Location = new System.Drawing.Point(1131, 630);
            this.btSaleConfirm.Name = "btSaleConfirm";
            this.btSaleConfirm.Size = new System.Drawing.Size(89, 51);
            this.btSaleConfirm.TabIndex = 47;
            this.btSaleConfirm.Text = "Xác Nhận Bán";
            this.btSaleConfirm.UseVisualStyleBackColor = false;
            this.btSaleConfirm.Click += new System.EventHandler(this.btSaleConfirm_Click);
            // 
            // byPurCancel
            // 
            this.byPurCancel.BackColor = System.Drawing.Color.DarkRed;
            this.byPurCancel.FlatAppearance.BorderSize = 0;
            this.byPurCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPurCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.byPurCancel.Location = new System.Drawing.Point(1039, 631);
            this.byPurCancel.Name = "byPurCancel";
            this.byPurCancel.Size = new System.Drawing.Size(86, 49);
            this.byPurCancel.TabIndex = 48;
            this.byPurCancel.Text = "Đóng";
            this.byPurCancel.UseVisualStyleBackColor = false;
            this.byPurCancel.Click += new System.EventHandler(this.byPurCancel_Click);
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.Location = new System.Drawing.Point(1046, 577);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(174, 21);
            this.lbTotalCost.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(975, 582);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "Tổng Tiền";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(321, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Giỏ Hàng";
            // 
            // dgvSaleCart
            // 
            this.dgvSaleCart.AllowUserToAddRows = false;
            this.dgvSaleCart.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSaleCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProduct,
            this.colCategoryID,
            this.colCategory,
            this.colQty,
            this.colSaleUnitPrice,
            this.colItemCost});
            this.dgvSaleCart.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSaleCart.Location = new System.Drawing.Point(319, 222);
            this.dgvSaleCart.MultiSelect = false;
            this.dgvSaleCart.Name = "dgvSaleCart";
            this.dgvSaleCart.ReadOnly = true;
            this.dgvSaleCart.RowHeadersVisible = false;
            this.dgvSaleCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleCart.Size = new System.Drawing.Size(901, 345);
            this.dgvSaleCart.TabIndex = 43;
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Sản Phẩm";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colCategoryID
            // 
            this.colCategoryID.HeaderText = "Mã Danh Mục";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Danh Mục ";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Số Lượng";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colSaleUnitPrice
            // 
            this.colSaleUnitPrice.HeaderText = "Đơn Giá Bán";
            this.colSaleUnitPrice.Name = "colSaleUnitPrice";
            this.colSaleUnitPrice.ReadOnly = true;
            // 
            // colItemCost
            // 
            this.colItemCost.HeaderText = "Thành Tiền";
            this.colItemCost.Name = "colItemCost";
            this.colItemCost.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 52);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.EditToolStripMenuItem.Text = "Chỉnh Sửa";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.DeleteToolStripMenuItem.Text = "Xóa";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.btClear);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btCancel);
            this.groupBox2.Controls.Add(this.lbItemCost);
            this.groupBox2.Controls.Add(this.txtSaleUnitPrice);
            this.groupBox2.Controls.Add(this.txtSaleQty);
            this.groupBox2.Controls.Add(this.cmbProducts);
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 288);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Sản Phẩm ";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdd.Location = new System.Drawing.Point(179, 234);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(86, 34);
            this.btAdd.TabIndex = 36;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClear.Location = new System.Drawing.Point(87, 234);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(86, 34);
            this.btClear.TabIndex = 35;
            this.btClear.Text = "Làm Mới";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btUpdate.Location = new System.Drawing.Point(177, 234);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(86, 34);
            this.btUpdate.TabIndex = 34;
            this.btUpdate.Text = "Cập Nhật";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.Location = new System.Drawing.Point(87, 234);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(86, 34);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "Đóng";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbItemCost
            // 
            this.lbItemCost.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbItemCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbItemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemCost.Location = new System.Drawing.Point(98, 186);
            this.lbItemCost.Name = "lbItemCost";
            this.lbItemCost.Size = new System.Drawing.Size(162, 24);
            this.lbItemCost.TabIndex = 12;
            // 
            // txtSaleUnitPrice
            // 
            this.txtSaleUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaleUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleUnitPrice.Location = new System.Drawing.Point(98, 146);
            this.txtSaleUnitPrice.Name = "txtSaleUnitPrice";
            this.txtSaleUnitPrice.Size = new System.Drawing.Size(135, 23);
            this.txtSaleUnitPrice.TabIndex = 4;
            this.txtSaleUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleUnitPrice_KeyPress);
            // 
            // txtSaleQty
            // 
            this.txtSaleQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaleQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleQty.Location = new System.Drawing.Point(98, 106);
            this.txtSaleQty.Name = "txtSaleQty";
            this.txtSaleQty.Size = new System.Drawing.Size(135, 23);
            this.txtSaleQty.TabIndex = 3;
            this.txtSaleQty.TextChanged += new System.EventHandler(this.txtSaleQty_TextChanged);
            // 
            // cmbProducts
            // 
            this.cmbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(98, 65);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(160, 24);
            this.cmbProducts.TabIndex = 18;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(98, 24);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(160, 24);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Đơn giá bán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Số lượng bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = " Danh mục";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbContactNo);
            this.groupBox1.Controls.Add(this.lbCustomerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 188);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Khách Hàng";
            // 
            // lbContactNo
            // 
            this.lbContactNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbContactNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactNo.Location = new System.Drawing.Point(294, 111);
            this.lbContactNo.Name = "lbContactNo";
            this.lbContactNo.Size = new System.Drawing.Size(213, 51);
            this.lbContactNo.TabIndex = 6;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.Location = new System.Drawing.Point(294, 43);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(213, 49);
            this.lbCustomerName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Liên hệ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(29, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Khách Hàng";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lbCurrentSaleUnitPrice);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbCurrentQty);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 546);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 121);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình Trạng Sản Phẩm Hiện Tại";
            // 
            // lbCurrentSaleUnitPrice
            // 
            this.lbCurrentSaleUnitPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbCurrentSaleUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentSaleUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentSaleUnitPrice.Location = new System.Drawing.Point(116, 77);
            this.lbCurrentSaleUnitPrice.Name = "lbCurrentSaleUnitPrice";
            this.lbCurrentSaleUnitPrice.Size = new System.Drawing.Size(138, 21);
            this.lbCurrentSaleUnitPrice.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Đơn giá bán";
            // 
            // lbCurrentQty
            // 
            this.lbCurrentQty.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbCurrentQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentQty.Location = new System.Drawing.Point(116, 36);
            this.lbCurrentQty.Name = "lbCurrentQty";
            this.lbCurrentQty.Size = new System.Drawing.Size(136, 21);
            this.lbCurrentQty.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng hiện tại";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btApDung);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lbPhanTramGiam);
            this.groupBox4.Controls.Add(this.lbSoTienGiam);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lbThongTinKM);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lbTieuDeKM);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtSearchMaKhuyenMai);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(586, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(522, 189);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn Chương Trình Khuyến Mãi";
            // 
            // btApDung
            // 
            this.btApDung.BackColor = System.Drawing.Color.Chocolate;
            this.btApDung.FlatAppearance.BorderSize = 0;
            this.btApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApDung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btApDung.Location = new System.Drawing.Point(385, 129);
            this.btApDung.Name = "btApDung";
            this.btApDung.Size = new System.Drawing.Size(119, 49);
            this.btApDung.TabIndex = 52;
            this.btApDung.Text = "Áp Dụng";
            this.btApDung.UseVisualStyleBackColor = false;
            this.btApDung.Click += new System.EventHandler(this.btApDung_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Phần trăm giảm giá (%)";
            // 
            // lbPhanTramGiam
            // 
            this.lbPhanTramGiam.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbPhanTramGiam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPhanTramGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanTramGiam.Location = new System.Drawing.Point(258, 91);
            this.lbPhanTramGiam.Name = "lbPhanTramGiam";
            this.lbPhanTramGiam.Size = new System.Drawing.Size(246, 26);
            this.lbPhanTramGiam.TabIndex = 58;
            // 
            // lbSoTienGiam
            // 
            this.lbSoTienGiam.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbSoTienGiam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSoTienGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienGiam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSoTienGiam.Location = new System.Drawing.Point(31, 153);
            this.lbSoTienGiam.Name = "lbSoTienGiam";
            this.lbSoTienGiam.Size = new System.Drawing.Size(211, 25);
            this.lbSoTienGiam.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "Số tiền giảm";
            // 
            // lbThongTinKM
            // 
            this.lbThongTinKM.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbThongTinKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbThongTinKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinKM.Location = new System.Drawing.Point(258, 43);
            this.lbThongTinKM.Name = "lbThongTinKM";
            this.lbThongTinKM.Size = new System.Drawing.Size(246, 24);
            this.lbThongTinKM.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Thông tin khuyến mãi";
            // 
            // lbTieuDeKM
            // 
            this.lbTieuDeKM.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbTieuDeKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTieuDeKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeKM.Location = new System.Drawing.Point(29, 96);
            this.lbTieuDeKM.Name = "lbTieuDeKM";
            this.lbTieuDeKM.Size = new System.Drawing.Size(213, 26);
            this.lbTieuDeKM.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tiêu đề giảm giá";
            // 
            // txtSearchMaKhuyenMai
            // 
            this.txtSearchMaKhuyenMai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearchMaKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMaKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaKhuyenMai.Location = new System.Drawing.Point(29, 42);
            this.txtSearchMaKhuyenMai.Name = "txtSearchMaKhuyenMai";
            this.txtSearchMaKhuyenMai.Size = new System.Drawing.Size(213, 23);
            this.txtSearchMaKhuyenMai.TabIndex = 1;
            this.txtSearchMaKhuyenMai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchMaKhuyenMai_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nhập mã giảm giá";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // BanHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 693);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSaleConfirm);
            this.Controls.Add(this.byPurCancel);
            this.Controls.Add(this.lbTotalCost);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvSaleCart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BanHangFrm";
            this.Text = "Đơn Hàng";
            this.Load += new System.EventHandler(this.BanHangFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleCart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSaleConfirm;
        private System.Windows.Forms.Button byPurCancel;
        public System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvSaleCart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.Label lbItemCost;
        private System.Windows.Forms.TextBox txtSaleUnitPrice;
        private System.Windows.Forms.TextBox txtSaleQty;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lbContactNo;
        public System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCost;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label lbCurrentSaleUnitPrice;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lbCurrentQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label lbThongTinKM;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lbTieuDeKM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearchMaKhuyenMai;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label lbSoTienGiam;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label lbPhanTramGiam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btApDung;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}