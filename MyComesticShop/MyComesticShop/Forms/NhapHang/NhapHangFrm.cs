using ComesticShop;
using ComesticShop.SourceCode;
using MyComesticShop.DatabaseLayer;
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

namespace MyComesticShop.Forms.NhapHang
{
    public partial class NhapHangFrm : Form
    {

        public string id_ncc = string.Empty;
        public NhapHangFrm()
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
            dgvSaleCart.Columns[6].Width = 80;
            dgvSaleCart.Columns[7].Width = 200;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemNCCFrm searchSupplier = new TimKiemNCCFrm(txtSearch.Text.Trim(), this);
                searchSupplier.ShowDialog();
            }
        }

        private void NhapHangFrm_Load(object sender, EventArgs e)
        {
            ComboHelper.Categories(cmbCategory);
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
                        gia_ban, 
                        gia_nhap 
                    FROM v_ProductList 
                    WHERE id_sanpham = '{productId}'";

                DataTable dt = DatabaseAccess.Retrive(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    lbCurrentQty.Text = dt.Rows[0][0].ToString();
                    lbCurrentSaleUnitPrice.Text = dt.Rows[0][1].ToString();
                    lbCurrentPurUnitPrice.Text = dt.Rows[0][2].ToString();

                    txtSaleUnitPrice.Text = dt.Rows[0][1].ToString();
                    txtPurUnitPrice.Text = dt.Rows[0][2].ToString();
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
            lbCurrentPurUnitPrice.Text = "";

            txtSaleUnitPrice.Text = "";
            txtPurUnitPrice.Text = "";
        }

        private void txtPurQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CalculateItemCost()
        {
            try
            {
                // Parse quantity
                if (!int.TryParse(txtPurQty.Text.Trim(), out int qty))
                {
                    lbItemCost.Text = "Số lượng không hợp lệ";
                    return;
                }

                // Parse unit price
                if (!float.TryParse(txtPurUnitPrice.Text.Trim(), out float purUnitPrice))
                {
                    lbItemCost.Text = "Đơn giá không hợp lệ";
                    return;
                }

                // Calculate total cost
                lbItemCost.Text = (qty * purUnitPrice).ToString("F2");
            }
            catch
            {
                lbItemCost.Text = "";
            }
        }

        private void txtPurQty_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtPurQty_TextChanged(object sender, EventArgs e)
        {
            CalculateItemCost();
        }

        private void txtPurUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateItemCost();
        }


        private void ClearProductGroup()
        {
            cmbProducts.SelectedIndex = 0;
            txtPurQty.Clear();
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
            id_ncc = string.Empty;
            lBSupplierName.Text = "";
            lBContactNo.Text = "";
            LoadProductDetails(Convert.ToString(cmbProducts.SelectedValue));
            CalculateTotalAmount();
            ClearProductGroup();
            dgvSaleCart.Rows.Clear();
        }

        private void btAdd_Click(object sender, EventArgs e)
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
            int.TryParse(txtPurQty.Text.Trim(), out qty);

            float purunitprice = 0;
            float.TryParse(txtPurUnitPrice.Text.Trim(), out purunitprice);

            float saleunitprice = 0;
            float.TryParse(txtSaleUnitPrice.Text.Trim(), out saleunitprice);

            float itemcost = 0;
            float.TryParse(lbItemCost.Text.Trim(), out itemcost);

            if (qty == 0)
            {
                ep.SetError(txtPurQty, "Vui lòng nhập số lượng nhập hàng!");
                txtPurQty.Focus();
                txtPurQty.SelectAll();
                return;
            }

            if (purunitprice == 0)
            {
                ep.SetError(txtPurUnitPrice, "Vui lòng nhập đơn giá nhập hàng!");
                txtPurUnitPrice.Focus();
                txtPurUnitPrice.SelectAll();
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

            // Tạo một hàng mới cho DataGridView
            DataGridViewRow addItem = new DataGridViewRow();
            addItem.CreateCells(dgvSaleCart);

            // Gán giá trị cho từng cột trong hàng
            addItem.Cells[0].Value = productid;
            addItem.Cells[1].Value = productname;
            addItem.Cells[2].Value = categoryid;
            addItem.Cells[3].Value = categoryname;
            addItem.Cells[4].Value = qty;
            addItem.Cells[5].Value = purunitprice;
            addItem.Cells[6].Value = saleunitprice;
            addItem.Cells[7].Value = itemcost;

            // Thêm hàng vào DataGridView
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
                            txtPurQty.Text = Convert.ToString(currentrow.Cells[4].Value);
                            txtPurUnitPrice.Text = Convert.ToString(currentrow.Cells[5].Value);
                            txtSaleUnitPrice.Text = Convert.ToString(currentrow.Cells[6].Value);
                            lbItemCost.Text = Convert.ToString(currentrow.Cells[7].Value);

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
            int.TryParse(txtPurQty.Text.Trim(), out qty);

            float purunitprice = 0;
            float.TryParse(txtPurUnitPrice.Text.Trim(), out purunitprice);

            float saleunitprice = 0;
            float.TryParse(txtSaleUnitPrice.Text.Trim(), out saleunitprice);

            float itemcost = 0;
            float.TryParse(lbItemCost.Text.Trim(), out itemcost);

            if (qty == 0)
            {
                ep.SetError(txtPurQty, "Vui lòng nhập số lượng nhập hàng!");
                txtPurQty.Focus();
                txtPurQty.SelectAll();
                return;
            }

            if (purunitprice == 0)
            {
                ep.SetError(txtPurUnitPrice, "Vui lòng nhập đơn giá nhập hàng!");
                txtPurUnitPrice.Focus();
                txtPurUnitPrice.SelectAll();
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
            dgvSaleCart.CurrentRow.Cells[5].Value = purunitprice;
            dgvSaleCart.CurrentRow.Cells[6].Value = saleunitprice;
            dgvSaleCart.CurrentRow.Cells[7].Value = itemcost;

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
                            float.TryParse(item.Cells[7].Value.ToString(), out amount);
                            totalAmount = totalAmount + amount;
                        }

                        lbTotalCost.Text = totalAmount.ToString("N2"); // hoặc "0.00"
                    }
                    else
                    {
                        lbTotalCost.Text = "0.00";
                    }

                }
                else
                {
                    lbTotalCost.Text = "0.00";
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

        private void btPurConfirm_Click(object sender, EventArgs e)
        {
             try
            {
                ep.Clear();

                // Kiểm tra SupplierID có rỗng không
                if (string.IsNullOrEmpty(id_ncc))
                {
                    ep.SetError(txtSearch, "Vui lòng tìm kiếm nhà cung cấp!");
                    txtSearch.Focus();
                    return;
                }
     
                int supplierid = 0;
                int.TryParse(id_ncc, out supplierid);
                // Kiểm tra tên nhà cung cấp có rỗng không

                if (supplierid == 0)
                {
                    ep.SetError(txtSearch, "Vui lòng tìm kiếm nhà cung cấp!");
                    txtSearch.Focus();
                    return;
                }

                if (lBSupplierName.Text.Trim().Length == 0)
                {
                    ep.SetError(txtSearch, "Vui lòng tìm kiếm nhà cung cấp!");
                    txtSearch.Focus();
                    return;
                }

                if (dgvSaleCart == null)
                {
                    ep.SetError(btAdd, "Vui lòng nhập thêm hàng!");
                    cmbProducts.Focus();
                    return;
                }

                if (dgvSaleCart.Rows.Count < 1)
                {
                    ep.SetError(btAdd, "Vui lòng nhập thêm hàng!");
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
                        ep.SetError(btAdd, "Vui lòng nhập thêm hàng!");
                        cmbProducts.Focus();
                        return;
                    }

                    string purchaseheaderquery = string.Format("insert into DonNhapHang (id_ncc, id_taikhoan, ngay_lap, tong_tien, ghi_chu) VALUES ('{0}', '{1}', '{2}', '{3}', N'{4}')",
                         supplierid,  
                         UserInfo.id_taikhoan, 
                         DateTime.Now.ToString("yyyy/MM/dd"), 
                         totalamount, 
                         txtComments.Text.Trim());


                    bool purchaseheaderresult = DatabaseAccess.Insert(purchaseheaderquery);
                    string purchaseid = string.Empty; 
                    if (purchaseheaderresult == true)
                    {
                        purchaseid = DatabaseAccess.Retrive("select max(id_nhap) from DonNhapHang").Rows[0][0].ToString();
                        foreach (DataGridViewRow product in dgvSaleCart.Rows)
                        {
                            string productquery = string.Format("insert into ChiTietPhieuNhap(id_nhap, id_sanpham, soluong, don_gia) VALUES ({0}, {1}, {2}, {3})",
                                purchaseid, 
                                Convert.ToString(product.Cells[0].Value), 
                                Convert.ToString(product.Cells[4].Value), 
                                Convert.ToString(product.Cells[5].Value));
                            try
                            {
                                bool purductdeleteresult = DatabaseAccess.Insert(productquery);
                                if (purchaseheaderresult == false)
                                {
                                    DeletePurchase(purchaseid);
                                    MessageBox.Show("Đã xảy ra sự cố không mong muốn. Vui lòng thử lại.");
                                    return;
                                }

                                string stockupdatequery = string.Format("update ChiTietPhieuNhap set gia_nhap = '{0}', so_luong = so_luong + '{1}', gia_ban = '{2}' where id_sanpham = '{3}'",
                                    Convert.ToString(product.Cells[5].Value),
                                    Convert.ToString(product.Cells[4].Value),
                                    Convert.ToString(product.Cells[6].Value),
                                    Convert.ToString(product.Cells[0].Value));
                                DatabaseAccess.Update(stockupdatequery);
                            }           
                            catch
                            {
                                DeletePurchase(purchaseid);
                                MessageBox.Show("Đã xảy ra sự cố không mong muốn. Vui lòng thử lại.");
                                return;
                            }
                        }
                        BaoCaoNhapHang frm = new BaoCaoNhapHang(Convert.ToInt32(purchaseid));
                        frm.Show();
                        ResetForm();
                        MessageBox.Show("Đã xác nhận nhập hàng");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng cung cấp thông tin mua hàng chính xác / Đăng nhập lại");
                        return;
                    }
                }
                else
                {
                    ep.SetError(btAdd, "Vui lòng nhập thêm hàng!");
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

        private void DeletePurchase(string purchaseid)
        {
            DataTable dt = DatabaseAccess.Retrive("select * ChiTietPhieuNhap where id_nhap = '" + purchaseid + "'");
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
            string purchasedetailquery = "delete from ChiTietPhieuNhap where id_nhap = '" + purchaseid + "'";
            DatabaseAccess.Delete(purchasedetailquery);

            //string purchaseheaderquery = "delete from DonNhapHang where id_nhap = '" + purchaseid + "'";
            //DatabaseAccess.Delete(purchasedetailquery);

        }

        private void txtSaleUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbItemCost_Click(object sender, EventArgs e)
        {

        }
    }
}
