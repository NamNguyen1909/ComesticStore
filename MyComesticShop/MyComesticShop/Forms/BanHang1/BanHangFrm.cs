using ComesticShop;
using ComesticShop.SourceCode;
using MyComesticShop.DatabaseLayer;
using MyComesticShop.Forms.KhachHang;
using MyComesticShop.Forms.KhuyenMai;
using MyComesticShop.Forms.NhaCungCap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComesticShop.Forms.BanHang1
{
    public partial class BanHangFrm : Form
    {

        public string id_khuyen_mai = string.Empty;
        public string id_KH = string.Empty;

        public BanHangFrm()
        {
            InitializeComponent();
            SetColumnsWidth();
        }

        private void SetColumnsWidth()
        {
            dgvSaleCart.Columns[1].Width = 150;
            dgvSaleCart.Columns[3].Width = 150;
            dgvSaleCart.Columns[4].Width = 80;
            dgvSaleCart.Columns[5].Width = 100;
            dgvSaleCart.Columns[6].Width = 300;
            //dgvSaleCart.Columns[7].Width = 200;
            dgvSaleCart.Columns[6].DefaultCellStyle.Format = "N0";
        }



        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboHelper.Products(cmbProducts, Convert.ToString(cmbCategory.SelectedValue));
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductDetails(Convert.ToString(cmbProducts.SelectedValue));
        }

        private void LoadProductDetails(string productId)
        {
            try
            {
                string query = $@"
                    SELECT 
                        ISNULL(so_luong, 0) AS total_qty, 
                        gia_ban
                    FROM v_ProductList 
                    WHERE id_sanpham = '{productId}'";

                DataTable dt = DatabaseAccess.Retrive(query);

                if (dt != null && dt.Rows.Count > 0)
                {

                    lbCurrentQty.Text = dt.Rows[0][0].ToString();
                    lbCurrentSaleUnitPrice.Text = dt.Rows[0][1].ToString();

                    txtSaleUnitPrice.Text = dt.Rows[0][1].ToString();

                }
                else
                {
                    ClearProductDetails();
                }
            }
            catch (Exception ex)
            {
                ClearProductDetails();
                MessageBox.Show("Lỗi khi tải chi tiết sản phẩm:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void ClearProductDetails()
        {
            lbCurrentQty.Text = "";
            lbCurrentSaleUnitPrice.Text = "";

            txtSaleUnitPrice.Text = "";
        }
        private void CalculateItemCost()
        {
            try
            {
                // Parse quantity
                if (!int.TryParse(txtSaleQty.Text.Trim(), out int qty))
                {
                    lbItemCost.Text = "Số lượng không hợp lệ";
                    return;
                }

                // Parse unit price
                if (!float.TryParse(txtSaleUnitPrice.Text.Trim(), out float saleUnitPrice))
                {
                    lbItemCost.Text = "Đơn giá không hợp lệ";
                    return;
                }

                // Calculate total cost
                lbItemCost.Text = (qty * saleUnitPrice).ToString("N2");
            }
            catch
            {
                lbItemCost.Text = "";
            }
        }

        private void CalculateTotalCostAfterKM()
        {
            try
            {
                // Lấy tổng tiền từ lbTotalCost (ví dụ: "200000 VNĐ")
                if (!float.TryParse(lbTotalCost.Text.Trim(), out float tongTien))
                {
                    lbSoTienGiam.Text = "0.00 ";
                    return;
                }

                // Lấy phần trăm giảm từ label lbPhanTramGiam (ví dụ: "10" hoặc "10%")
                string phanTramText = lbPhanTramGiam.Text.Trim();
                if (!float.TryParse(phanTramText, out float phanTramGiam))
                {
                    lbSoTienGiam.Text = "0.00 ";
                    return;
                }

                // Tính số tiền giảm
                float soTienGiam = (tongTien * phanTramGiam) / 100;

                // Hiển thị số tiền giảm
                lbTotalCost.Text = soTienGiam.ToString("N2") ;

                // Nếu có label tổng tiền sau khi giảm (vd: lbThanhToan), thì cập nhật
                if (lbTotalCost != null)
                {
                    float tongTienSauGiam = tongTien - soTienGiam;
                    lbTotalCost.Text = tongTienSauGiam.ToString("N2");
                }
            }
            catch
            {
                lbTotalCost.Text = "";
            }
        }

        private void CalculateKMItemCost()
        {
            try
            {
                // Lấy tổng tiền từ lbTotalCost (ví dụ: "200000 VNĐ")
                if (!float.TryParse(lbItemCost.Text.Trim(), out float tongTien))
                {
                    lbSoTienGiam.Text = "0.00 ";
                    return;
                }

                // Lấy phần trăm giảm từ label lbPhanTramGiam (ví dụ: "10" hoặc "10%")
                string phanTramText = lbPhanTramGiam.Text.Trim();
                if (!float.TryParse(phanTramText, out float phanTramGiam))
                {
                    lbSoTienGiam.Text = "0.00 ";
                    return;
                }

                // Tính số tiền giảm
                float soTienGiam = (tongTien * phanTramGiam) / 100;

                // Hiển thị số tiền giảm
                lbSoTienGiam.Text = soTienGiam.ToString("N2");

                // Nếu có label tổng tiền sau khi giảm (vd: lbThanhToan), thì cập nhật
                //if (lbTotalCost != null)
                //{
                //    float tongTienSauGiam = tongTien - soTienGiam;
                //    lbTotalCost.Text = tongTienSauGiam.ToString("N2");
                //}
            }
            catch
            {
                lbSoTienGiam.Text = "";
            }
        }


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemKHFrm searchCustomer = new TimKiemKHFrm(txtSearch.Text.Trim(), this);
                searchCustomer.ShowDialog();
            }
        }



        private void BanHangFrm_Load(object sender, EventArgs e)
        {
            ComboHelper.Categories(cmbCategory);
        }

        private void txtSaleQty_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Chỉ cho nhập một dấu phẩy duy nhất
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSaleUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Không cho nhập số 0 ở đầu nếu chưa có dấu phẩy
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSaleQty_TextChanged(object sender, EventArgs e)
        {
            CalculateItemCost();
        }


        private void ClearProductGroup()
        {
            cmbProducts.SelectedIndex = 0;
            txtSaleQty.Clear();
        }

        private void EnableProductComponents()
        {
            btCancel.Visible = true;
            btUpdate.Visible = true;
            btAdd.Visible = false;
            btClear.Visible = false;
            dgvSaleCart.Enabled = false;
            txtSearch.Enabled = false;
        }

        private void DisableProductComponents()
        {
            btCancel.Visible = false;
            btUpdate.Visible = false;
            btAdd.Visible = true;
            btClear.Visible = true;
            dgvSaleCart.Enabled = true;
            txtSearch.Enabled = true;
            LoadProductDetails(Convert.ToString(cmbProducts.SelectedValue));
            CalculateTotalAmount();
        }

        private void ResetForm()
        {
            btCancel.Visible = false;
            btUpdate.Visible = false;
            btAdd.Visible = true;
            btClear.Visible = true;
            dgvSaleCart.Enabled = true;
            txtSearch.Enabled = true;
            id_KH = string.Empty;
            lbCustomerName.Text = "";
            lbContactNo.Text = "";
            LoadProductDetails(Convert.ToString(cmbProducts.SelectedValue));
            CalculateTotalAmount();
            ClearProductGroup();
            dgvSaleCart.Rows.Clear();

            txtSearchMaKhuyenMai.Text = "";
            lbTieuDeKM.Text = "";
            lbThongTinKM.Text = "";
            lbSoTienGiam.Text = "0 VNĐ";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int soLuongBan;
            int soLuongHienTai;

            ep.Clear();

            if (cmbCategory.SelectedIndex == 0)
            {
                ep.SetError(cmbCategory, "Vui lòng chọn danh mục!");
                cmbCategory.Focus();
                return;
            }

            if (cmbProducts.SelectedIndex == 0)
            {
                ep.SetError(cmbProducts, "Vui lòng chọn sản phẩm!");
                cmbProducts.Focus();
                return;
            }

            if (!int.TryParse(txtSaleQty.Text.Trim(), out soLuongBan))
            {
                MessageBox.Show("Số lượng bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(lbCurrentQty.Text.Trim(), out soLuongHienTai))
            {
                MessageBox.Show("Số lượng hiện tại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Kiểm tra trước khi thêm
            if (soLuongBan > soLuongHienTai)
            {
                MessageBox.Show("Số lượng bán vượt quá số lượng hiện có!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string categoryid = Convert.ToString(cmbCategory.SelectedValue);
            string categoryname = cmbCategory.Text;

            string productid = Convert.ToString(cmbProducts.SelectedValue);
            string productname = cmbProducts.Text;

            int qty = soLuongBan;

            float purunitprice = 0;
            float.TryParse(txtSaleUnitPrice.Text.Trim(), out purunitprice);

            float saleunitprice = 0;
            float.TryParse(txtSaleUnitPrice.Text.Trim(), out saleunitprice);

            float itemcost = 0;
            float.TryParse(lbItemCost.Text.Trim(), out itemcost);

            if (qty == 0)
            {
                ep.SetError(txtSaleQty, "Vui lòng nhập số lượng nhập hàng!");
                txtSaleQty.Focus();
                txtSaleQty.SelectAll();
                return;
            }

            if (purunitprice == 0)
            {
                ep.SetError(txtSaleUnitPrice, "Vui lòng nhập đơn giá nhập hàng!");
                txtSaleUnitPrice.Focus();
                txtSaleUnitPrice.SelectAll();
                return;
            }

            if (saleunitprice == 0)
            {
                ep.SetError(txtSaleUnitPrice, "Vui lòng nhập đơn giá bán hàng!");
                txtSaleUnitPrice.Focus();
                txtSaleUnitPrice.SelectAll();
                return;
            }

            foreach (DataGridViewRow checkitem in dgvSaleCart.Rows)
            {
                if (Convert.ToInt32(checkitem.Cells[0].Value.ToString()) == Convert.ToInt32(productid) &&
                    Convert.ToInt32(checkitem.Cells[2].Value.ToString()) == Convert.ToInt32(categoryid))
                {
                    ep.SetError(cmbProducts, "Sản phẩm đã có trong giỏ nhập hàng!");
                    cmbProducts.Focus();
                    dgvSaleCart.ClearSelection();
                    checkitem.Selected = true;
                    return;
                }
            }

            // ✅ Đến đây mới được thêm
            DataGridViewRow addItem = new DataGridViewRow();
            addItem.CreateCells(dgvSaleCart);

            addItem.Cells[0].Value = productid;
            addItem.Cells[1].Value = productname;
            addItem.Cells[2].Value = categoryid;
            addItem.Cells[3].Value = categoryname;
            addItem.Cells[4].Value = qty;
            addItem.Cells[5].Value = saleunitprice;
            addItem.Cells[6].Value = itemcost;

            dgvSaleCart.Rows.Add(addItem);
            DisableProductComponents();
            ClearProductGroup();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearProductGroup();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DisableProductComponents();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSaleCart != null)
                {
                    if (dgvSaleCart.Rows.Count > 0)
                    {
                        if (dgvSaleCart.SelectedRows.Count == 1)
                        {
                            if (MessageBox.Show("Bạn có chắc chắn muốn xóa mục đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                dgvSaleCart.Rows.Remove(dgvSaleCart.SelectedRows[0]);
                                CalculateTotalAmount();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn một bản ghi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giỏ hàng mua trống!");
                    }
                }
            }
            catch
            {

                MessageBox.Show("Vui lòng thử lại!");
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSaleCart != null)
                {
                    if (dgvSaleCart.Rows.Count > 0)
                    {
                        if (dgvSaleCart.SelectedRows.Count == 1)
                        {
                            DataGridViewRow currentrow = dgvSaleCart.CurrentRow;

                            cmbCategory.SelectedValue = currentrow.Cells[2].Value;
                            cmbProducts.SelectedValue = currentrow.Cells[0].Value;
                            txtSaleQty.Text = Convert.ToString(currentrow.Cells[4].Value);
                            //txtUnitPrice.Text = Convert.ToString(currentrow.Cells[5].Value);
                            txtSaleUnitPrice.Text = Convert.ToString(currentrow.Cells[5].Value);
                            lbItemCost.Text = Convert.ToString(currentrow.Cells[6].Value);

                            EnableProductComponents();

                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn một bản ghi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giỏ hàng mua trống!");
                    }
                }
            }
            catch
            {

                MessageBox.Show("Vui lòng thử lại!");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();

            if (cmbCategory.SelectedIndex == 0)
            {
                ep.SetError(cmbCategory, "Vui lòng chọn danh mục!");
                cmbCategory.Focus();
                return;
            }

            if (cmbProducts.SelectedIndex == 0)
            {
                ep.SetError(cmbProducts, "Vui lòng chọn sản phẩm!");
                cmbProducts.Focus();
                return;
            }

            string categoryid = Convert.ToString(cmbCategory.SelectedValue);
            string categoryname = cmbCategory.Text;

            string productid = Convert.ToString(cmbProducts.SelectedValue);
            string productname = cmbProducts.Text;

            int qty = 0;
            int.TryParse(txtSaleQty.Text.Trim(), out qty);

            //float saleunitprice = 0;
            //float.TryParse(txtPurUnitPrice.Text.Trim(), out purunitprice);

            float saleunitprice = 0;
            float.TryParse(txtSaleUnitPrice.Text.Trim(), out saleunitprice);

            float itemcost = 0;
            float.TryParse(lbItemCost.Text.Trim(), out itemcost);

            if (qty == 0)
            {
                ep.SetError(txtSaleQty, "Vui lòng nhập số lượng bán hàng!");
                txtSaleQty.Focus();
                txtSaleQty.SelectAll();
                return;
            }

            if (saleunitprice == 0)
            {
                ep.SetError(txtSaleUnitPrice, "Vui lòng nhập đơn giá bán hàng!");
                txtSaleUnitPrice.Focus();
                txtSaleUnitPrice.SelectAll();
                return;
            }

            foreach (DataGridViewRow checkitem in dgvSaleCart.Rows)
            {
                if (checkitem == dgvSaleCart.CurrentRow) continue;

                if (Convert.ToInt32(checkitem.Cells[0].Value.ToString()) == Convert.ToInt32(productid) &&
                    Convert.ToInt32(checkitem.Cells[2].Value.ToString()) == Convert.ToInt32(categoryid))
                {
                    ep.SetError(cmbProducts, "Sản phẩm đã có trong giỏ nhập hàng!");
                    cmbProducts.Focus();
                    dgvSaleCart.ClearSelection();
                    checkitem.Selected = true;
                    return;
                }
            }

            // Gán giá trị cho từng cột trong hàng
            dgvSaleCart.CurrentRow.Cells[0].Value = productid;
            dgvSaleCart.CurrentRow.Cells[1].Value = productname;
            dgvSaleCart.CurrentRow.Cells[2].Value = categoryid;
            dgvSaleCart.CurrentRow.Cells[3].Value = categoryname;
            dgvSaleCart.CurrentRow.Cells[4].Value = qty;
            //dgvPurchaseCart.CurrentRow.Cells[5].Value = purunitprice;
            dgvSaleCart.CurrentRow.Cells[5].Value = saleunitprice;
            dgvSaleCart.CurrentRow.Cells[6].Value = itemcost;

            // Thêm hàng vào DataGridView
            DisableProductComponents();
            ClearProductGroup();
        }

        private void CalculateTotalAmount()
        {
            try
            {
                if (dgvSaleCart != null)
                {
                    if (dgvSaleCart.Rows.Count > 0)
                    {
                        float totalAmount = 0;
                        foreach (DataGridViewRow item in dgvSaleCart.Rows)
                        {
                            float amount = 0;
                            float.TryParse(item.Cells[6].Value.ToString(), out amount);
                            totalAmount = totalAmount + amount;
                        }

                        lbTotalCost.Text = totalAmount.ToString("N2"); // hoặc "0.00"
                        CalculateTotalCostAfterKM();
                        CalculateKMItemCost();


                    }
                    else
                    {
                        lbTotalCost.Text = "";
                        lbSoTienGiam.Text = "";

                        // Hiển thị tổng tiền sau giảm giá (nếu bạn có label này)
                        if (lbSoTienGiam != null)
                        {
                            lbSoTienGiam.Text = "";
                        }
                    }
                }
                else
                {
                    lbTotalCost.Text = "";
                }

            }
            catch
            {
                lbTotalCost.Text = "!Lỗi";
            }
        }


        private void byPurCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btSaleConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();

                // Kiểm tra SupplierID có rỗng không
                if (string.IsNullOrEmpty(id_KH))
                {
                    ep.SetError(txtSearch, "Vui lòng tìm kiếm khách hàng!");
                    txtSearch.Focus();
                    return;
                }

                //string customerid;
                //int.TryParse(id_KH, out customerid);
                //// Kiểm tra tên nhà cung cấp có rỗng không

                //if (customerid == 0)
                //{
                //    ep.SetError(txtSearch, "Vui lòng tìm kiếm khách hàng!");
                //    txtSearch.Focus();
                //    return;
                //}

                if (lbCustomerName.Text.Trim().Length == 0)
                {
                    ep.SetError(txtSearch, "Vui lòng tìm kiếm khách hàng!");
                    txtSearch.Focus();
                    return;
                }

                if (dgvSaleCart == null)
                {
                    ep.SetError(btAdd, "Vui lòng nhập!");
                    cmbProducts.Focus();
                    return;
                }

                if (dgvSaleCart.Rows.Count < 1)
                {
                    ep.SetError(btAdd, "Vui lòng nhập!");
                    cmbProducts.Focus();
                    return;
                }

                if (dgvSaleCart.Rows.Count > 0)
                {
                    CalculateTotalAmount();
                    float totalamount = 0;
                    float.TryParse(lbTotalCost.Text.Trim(), out totalamount);

                    if (totalamount == 0)
                    {
                        ep.SetError(btAdd, "Vui lòng nhập!");
                        cmbProducts.Focus();
                        return;
                    }

                    string idKhuyenMaiSQL = string.IsNullOrEmpty(id_khuyen_mai) ? "NULL" : $"'{id_khuyen_mai}'";

                    string saleheaderquery = string.Format("" +
                        "insert into DonHang (sdtKH, id_khuyen_mai, id_taikhoan, ngay_lap, tong_tien, ghi_chu) VALUES ('{0}', {1}, {2}, '{3}', {4}, N'{5}')",
                            id_KH,
                            idKhuyenMaiSQL,
                            UserInfo.id_taikhoan,
                            DateTime.Now.ToString("yyyy/MM/dd"),
                            totalamount,
                            txtComments.Text.Trim());

                    // Kiểm tra giá trị các biến
                    //string debugMsg =
                    //    $"customerid: {id_KH}\n" +
                    //    $"UserInfo.id_taikhoan: {UserInfo.id_taikhoan}\n" +
                    //    $"DateTime.Now: {DateTime.Now.ToString("yyyy/MM/dd")}\n" +
                    //    $"totalamount: {totalamount}\n" +
                    //    $"lbPhanTramGiam: {lbPhanTramGiam.Text.Trim()}\n" +
                    //    $"id_khuyen_mai: {id_khuyen_mai}\n" +
                    //    $"ghi_chu: {txtComments.Text.Trim()}";

                    //MessageBox.Show(debugMsg, "DEBUG - Giá trị trước khi insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //// Kiểm tra luôn câu query nếu muốn
                    //MessageBox.Show(saleheaderquery, "DEBUG - Query sẽ insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bool saleheaderresult = DatabaseAccess.Insert(saleheaderquery);
                    string saleid = string.Empty;
                    if (saleheaderresult == true)
                    {
                        saleid = DatabaseAccess.Retrive("select max(id_don) from DonHang").Rows[0][0].ToString();
                        foreach (DataGridViewRow product in dgvSaleCart.Rows)
                        {
                            string productquery = string.Format("insert into ChiTietDonHang(id_don, id_sanpham, soluong, gia_ban) VALUES ({0}, {1}, {2}, {3})",
                                saleid,
                                Convert.ToString(product.Cells[0].Value),
                                Convert.ToString(product.Cells[4].Value),
                                Convert.ToString(product.Cells[5].Value));
                            try
                            {
                                bool purductdeleteresult = DatabaseAccess.Insert(productquery);
                                if (saleheaderresult == false)
                                {
                                    DeletePurchase(saleid);
                                    MessageBox.Show("Đã xảy ra sự cố không mong muốn. Vui lòng thử lại.");
                                    return;
                                }

                                string stockupdatequery = string.Format("update ChiTietDonHang set so_luong = so_luong + '{0}', gia_ban = '{1}' where id_sanpham = '{2}'",
                                    Convert.ToString(product.Cells[4].Value),
                                    Convert.ToString(product.Cells[5].Value),
                                    Convert.ToString(product.Cells[0].Value));
                                DatabaseAccess.Update(stockupdatequery);
                            }
                            catch
                            {
                                DeletePurchase(saleid);
                                MessageBox.Show("Đã xảy ra sự cố không mong muốn. Vui lòng thử lại.");
                                return;
                            }
                        }
                        BaoCaoBanHang frm = new BaoCaoBanHang(Convert.ToInt32(saleid));
                        frm.Show();
                        ResetForm();
                        MessageBox.Show("Đã xác nhận bán hàng");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng cung cấp thông tin bán hàng chính xác / Đăng nhập lại");
                        return;
                    }
                }
                else
                {
                    ep.SetError(btAdd, "Vui lòng nhập!");
                    cmbProducts.Focus();
                    return;
                }
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lời nhắn hệ thống");
            }
        }

        private void DeletePurchase(string saleid)
        {
            DataTable dt = DatabaseAccess.Retrive("select * ChiTietDonHang where id_don = '" + saleid + "'");
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    string stockupdatequery = string.Format("update v_ProductList set so_luong = so_luong - '{0}' where id_sanpham = '{1}'",
                        Convert.ToString(item[1]),
                        Convert.ToString(item[0]));
                    DatabaseAccess.Update(stockupdatequery);
                }
            }
            string saledetailquery = "delete from ChiTietDonHang where id_don = '" + saleid + "'";
            DatabaseAccess.Delete(saledetailquery);

            //string purchaseheaderquery = "delete from DonNhapHang where id_nhap = '" + purchaseid + "'";
            //DatabaseAccess.Delete(purchasedetailquery);

        }


        private void txtSearchMaKhuyenMai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemMaKMFrm searchMKM = new TimKiemMaKMFrm(txtSearch.Text.Trim(), this);
                searchMKM.ShowDialog();
            }
        }

        private void btApDung_Click(object sender, EventArgs e)
        {
            CalculateKMItemCost();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
