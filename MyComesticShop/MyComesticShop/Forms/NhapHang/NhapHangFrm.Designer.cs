
namespace MyComesticShop.Forms.NhapHang
{
    partial class NhapHangFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lBContactNo = new System.Windows.Forms.Label();
            this.lBSupplierName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbItemCost = new System.Windows.Forms.Label();
            this.txtSaleUnitPrice = new System.Windows.Forms.TextBox();
            this.txtPurUnitPrice = new System.Windows.Forms.TextBox();
            this.txtPurQty = new System.Windows.Forms.TextBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCurrentSaleUnitPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCurrentPurUnitPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCurrentQty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSaleCart = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.byPurCancel = new System.Windows.Forms.Button();
            this.btPurConfirm = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleCart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lBContactNo);
            this.groupBox1.Controls.Add(this.lBSupplierName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Nhà Cung Cấp";
            // 
            // lBContactNo
            // 
            this.lBContactNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lBContactNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lBContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBContactNo.Location = new System.Drawing.Point(541, 42);
            this.lBContactNo.Name = "lBContactNo";
            this.lBContactNo.Size = new System.Drawing.Size(213, 51);
            this.lBContactNo.TabIndex = 6;
            // 
            // lBSupplierName
            // 
            this.lBSupplierName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lBSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lBSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBSupplierName.Location = new System.Drawing.Point(294, 43);
            this.lBSupplierName.Name = "lBSupplierName";
            this.lBSupplierName.Size = new System.Drawing.Size(213, 49);
            this.lBSupplierName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 25);
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
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà Cung Cấp";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Nhà Cung Cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.btClear);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btCancel);
            this.groupBox2.Controls.Add(this.lbItemCost);
            this.groupBox2.Controls.Add(this.txtSaleUnitPrice);
            this.groupBox2.Controls.Add(this.txtPurUnitPrice);
            this.groupBox2.Controls.Add(this.txtPurQty);
            this.groupBox2.Controls.Add(this.cmbProducts);
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Sản Phẩm ";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdd.Location = new System.Drawing.Point(177, 270);
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
            this.btClear.Location = new System.Drawing.Point(87, 270);
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
            this.btUpdate.Location = new System.Drawing.Point(177, 271);
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
            this.btCancel.Location = new System.Drawing.Point(87, 271);
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
            this.lbItemCost.Location = new System.Drawing.Point(100, 226);
            this.lbItemCost.Name = "lbItemCost";
            this.lbItemCost.Size = new System.Drawing.Size(162, 21);
            this.lbItemCost.TabIndex = 12;
            this.lbItemCost.Click += new System.EventHandler(this.lbItemCost_Click);
            // 
            // txtSaleUnitPrice
            // 
            this.txtSaleUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaleUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleUnitPrice.Location = new System.Drawing.Point(102, 186);
            this.txtSaleUnitPrice.Name = "txtSaleUnitPrice";
            this.txtSaleUnitPrice.Size = new System.Drawing.Size(135, 23);
            this.txtSaleUnitPrice.TabIndex = 4;
            this.txtSaleUnitPrice.TextChanged += new System.EventHandler(this.txtSaleUnitPrice_TextChanged);
            this.txtSaleUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleUnitPrice_KeyPress);
            // 
            // txtPurUnitPrice
            // 
            this.txtPurUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurUnitPrice.Location = new System.Drawing.Point(102, 146);
            this.txtPurUnitPrice.Name = "txtPurUnitPrice";
            this.txtPurUnitPrice.Size = new System.Drawing.Size(135, 23);
            this.txtPurUnitPrice.TabIndex = 19;
            this.txtPurUnitPrice.TextChanged += new System.EventHandler(this.txtPurUnitPrice_TextChanged);
            this.txtPurUnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurQty_KeyDown);
            this.txtPurUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleUnitPrice_KeyPress);
            // 
            // txtPurQty
            // 
            this.txtPurQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurQty.Location = new System.Drawing.Point(102, 106);
            this.txtPurQty.Name = "txtPurQty";
            this.txtPurQty.Size = new System.Drawing.Size(135, 23);
            this.txtPurQty.TabIndex = 3;
            this.txtPurQty.TextChanged += new System.EventHandler(this.txtPurQty_TextChanged);
            this.txtPurQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurQty_KeyDown);
            this.txtPurQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurQty_KeyPress);
            // 
            // cmbProducts
            // 
            this.cmbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(102, 65);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(160, 24);
            this.cmbProducts.TabIndex = 18;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(102, 24);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(160, 24);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Đơn giá bán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Đơn giá nhập ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Số lượng nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 70);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lbCurrentSaleUnitPrice);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbCurrentPurUnitPrice);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbCurrentQty);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 503);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình Trạng Sản Phẩm Hiện Tại";
            // 
            // lbCurrentSaleUnitPrice
            // 
            this.lbCurrentSaleUnitPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbCurrentSaleUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentSaleUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentSaleUnitPrice.Location = new System.Drawing.Point(116, 109);
            this.lbCurrentSaleUnitPrice.Name = "lbCurrentSaleUnitPrice";
            this.lbCurrentSaleUnitPrice.Size = new System.Drawing.Size(138, 21);
            this.lbCurrentSaleUnitPrice.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Đơn giá bán";
            // 
            // lbCurrentPurUnitPrice
            // 
            this.lbCurrentPurUnitPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbCurrentPurUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentPurUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPurUnitPrice.Location = new System.Drawing.Point(116, 68);
            this.lbCurrentPurUnitPrice.Name = "lbCurrentPurUnitPrice";
            this.lbCurrentPurUnitPrice.Size = new System.Drawing.Size(138, 21);
            this.lbCurrentPurUnitPrice.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đơn giá nhập \r\nhiện tại";
            // 
            // lbCurrentQty
            // 
            this.lbCurrentQty.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbCurrentQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentQty.Location = new System.Drawing.Point(116, 30);
            this.lbCurrentQty.Name = "lbCurrentQty";
            this.lbCurrentQty.Size = new System.Drawing.Size(136, 21);
            this.lbCurrentQty.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng hiện tại";
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
            this.colPurchaseUnitPrice,
            this.colSaleUnitPrice,
            this.colItemCost});
            this.dgvSaleCart.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSaleCart.Location = new System.Drawing.Point(306, 178);
            this.dgvSaleCart.MultiSelect = false;
            this.dgvSaleCart.Name = "dgvSaleCart";
            this.dgvSaleCart.ReadOnly = true;
            this.dgvSaleCart.RowHeadersVisible = false;
            this.dgvSaleCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleCart.Size = new System.Drawing.Size(482, 352);
            this.dgvSaleCart.TabIndex = 3;
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
            // colPurchaseUnitPrice
            // 
            this.colPurchaseUnitPrice.HeaderText = "Đơn Giá Nhập ";
            this.colPurchaseUnitPrice.Name = "colPurchaseUnitPrice";
            this.colPurchaseUnitPrice.ReadOnly = true;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(303, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Giỏ Nhập Hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(543, 547);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Tổng Tiền";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.Location = new System.Drawing.Point(614, 542);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(174, 21);
            this.lbTotalCost.TabIndex = 12;
            // 
            // byPurCancel
            // 
            this.byPurCancel.BackColor = System.Drawing.Color.DarkRed;
            this.byPurCancel.FlatAppearance.BorderSize = 0;
            this.byPurCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPurCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.byPurCancel.Location = new System.Drawing.Point(607, 638);
            this.byPurCancel.Name = "byPurCancel";
            this.byPurCancel.Size = new System.Drawing.Size(86, 49);
            this.byPurCancel.TabIndex = 37;
            this.byPurCancel.Text = "Đóng";
            this.byPurCancel.UseVisualStyleBackColor = false;
            this.byPurCancel.Click += new System.EventHandler(this.byPurCancel_Click);
            // 
            // btPurConfirm
            // 
            this.btPurConfirm.BackColor = System.Drawing.Color.Green;
            this.btPurConfirm.FlatAppearance.BorderSize = 0;
            this.btPurConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPurConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPurConfirm.Location = new System.Drawing.Point(699, 636);
            this.btPurConfirm.Name = "btPurConfirm";
            this.btPurConfirm.Size = new System.Drawing.Size(89, 51);
            this.btPurConfirm.TabIndex = 37;
            this.btPurConfirm.Text = "Xác Nhận Nhập";
            this.btPurConfirm.UseVisualStyleBackColor = false;
            this.btPurConfirm.Click += new System.EventHandler(this.btPurConfirm_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(306, 563);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(213, 85);
            this.txtComments.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ghi Chú";
            // 
            // NhapHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 688);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btPurConfirm);
            this.Controls.Add(this.byPurCancel);
            this.Controls.Add(this.lbTotalCost);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvSaleCart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapHangFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng Mới ";
            this.Load += new System.EventHandler(this.NhapHangFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleCart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lBSupplierName;
        public System.Windows.Forms.Label lBContactNo;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lbItemCost;
        private System.Windows.Forms.TextBox txtSaleUnitPrice;
        private System.Windows.Forms.TextBox txtPurUnitPrice;
        private System.Windows.Forms.TextBox txtPurQty;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label lbCurrentSaleUnitPrice;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lbCurrentPurUnitPrice;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbCurrentQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSaleCart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Button byPurCancel;
        private System.Windows.Forms.Button btPurConfirm;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCost;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label3;
    }
}