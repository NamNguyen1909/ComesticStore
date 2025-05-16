using ComesticShop.SourceCode;
using MyComesticShop.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComesticShop.Forms.NhaCungCap
{
    public partial class NhaCungCapFrm: Form
    {
        public NhaCungCapFrm()
        {
            InitializeComponent();
        }

        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            if (string.IsNullOrEmpty(searchValue))
            {
                query = " SELECT id_ncc AS[ID_NCC], ten_ncc AS[Tên NCC], sdt AS[SĐT], email AS[Email], dia_chi AS[Địa Chỉ], ma_so_thue AS[Mã Số Thuế], ten_dang_nhap AS[Tạo Bởi], ghi_chu AS[Ghi Chú] FROM v_SuppliersList ";
            }
            else
            {
                query = "SELECT id_ncc AS [ID_NCC], ten_ncc AS [Tên NCC], sdt AS [SĐT], email AS [Email], dia_chi AS [Địa Chỉ], ma_so_thue AS [Mã Số Thuế], ten_dang_nhap AS [Tạo Bởi], ghi_chu AS [Ghi Chú] FROM v_SuppliersList " +
                    "WHERE (ten_ncc + sdt + email + dia_chi + ma_so_thue + ten_dang_nhap) LIKE N'%" + searchValue.Trim() + "%'";
            }

                DataTable dt = DatabaseAccess.Retrive(query);

            if (dt != null)
            {
                dgvSuppliers.DataSource = dt;

                // Ẩn cột Mã nhà cung cấp
                dgvSuppliers.Columns[0].Visible = false; //Mã nhà cung cấp

                // Cài đặt độ rộng các cột hiển thị
                dgvSuppliers.Columns[1].Width = 200; // Tên NCC
                dgvSuppliers.Columns[2].Width = 120; // SDT
                dgvSuppliers.Columns[3].Width = 200; // Email
                dgvSuppliers.Columns[4].Width = 150; // Địa Chỉ
                dgvSuppliers.Columns[5].Width = 120; // Mã Số Thuế
                dgvSuppliers.Columns[6].Width = 100; // Tên DN
                dgvSuppliers.Columns[7].Width = 250; // ghi chú 
            }
            else
            {
                dgvSuppliers.DataSource = null;
            }
        }

        private void ClearForm()
        {
            txtNameNCC.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtTax.Clear();
            txtDiscript.Clear();
        }

        private void EnableComponents()
        {
            btCancel.Visible = true;
            btUpdate.Visible = true;
            btSave.Visible = false;
            btClear.Visible = false;
            dgvSuppliers.Enabled = false;
            txtSearch.Enabled = false;
        }

        private void DisableComponents()
        {
            btCancel.Visible = false;
            btUpdate.Visible = false;
            btSave.Visible = true;
            btClear.Visible = true;
            dgvSuppliers.Enabled = true;
            txtSearch.Enabled = true;
            ClearForm();
            RetrieveList(string.Empty);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtNameNCC.Text.Trim().Length == 0)
                {
                    ep.SetError(txtNameNCC, "Vui lòng chọn nhà cung cấp!");
                    txtNameNCC.Focus();
                    return;
                }
               
                if (txtContactNo.Text.Trim().Length == 0)
                {
                    ep.SetError(txtContactNo, "Vui lòng điền số điện thoại!");
                    txtContactNo.Focus();
                    return;
                }
                if (txtEmail.Text.Trim().Length == 0)
                {
                    ep.SetError(txtEmail, "Vui lòng điền email!");
                    txtEmail.Focus();
                    return;
                }
                if (txtAddress.Text.Trim().Length == 0)
                {
                    ep.SetError(txtAddress, "Vui lòng điền địa chỉ!");
                    txtAddress.Focus();
                    return;
                }
                if (txtTax.Text.Trim().Length == 0)
                {
                    ep.SetError(txtTax, "Vui lòng điền mã số thuế nhà cung cấp!");
                    txtTax.Focus();
                    return;
                }
                if (txtDiscript.Text.Trim().Length == 0)
                {
                    ep.SetError(txtDiscript, "Vui lòng điền ghi chú!");
                    txtDiscript.Focus();
                    return;
                }

                DataTable dt = DatabaseAccess.Retrive(string.Format("select * from NhaCungCap where ten_ncc = N'{0}' AND sdt = '{1}'", txtNameNCC.Text.Trim(), txtContactNo.Text.Trim()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtNameNCC, "Đã đăng ký nhà cung cấp");
                        txtNameNCC.Focus();
                        return;
                    }
                }
                string insertquery = string.Format(
                    "INSERT INTO NhaCungCap (ten_ncc, sdt, email, dia_chi, ma_so_thue, ghi_chu) " +
                    "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')",
                    txtNameNCC.Text.Trim(), txtContactNo.Text.Trim(), txtEmail.Text.Trim(), txtAddress.Text.Trim(), txtTax.Text.Trim(), txtDiscript.Text.Trim());

                bool result = DatabaseAccess.Insert(insertquery);

                if (result == true)
                {
                    MessageBox.Show("Lưu thành công!");
                    DisableComponents();
                }
                else
                {
                    MessageBox.Show("Vui lòng cung cấp thông tin chính xác, sau đó thử lại!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng cung cấp thông tin chính xác, sau đó thử lại!");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtNameNCC.Text.Trim().Length == 0)
                {
                    ep.SetError(txtNameNCC, "Vui lòng chọn nhà cung cấp!");
                    txtNameNCC.Focus();
                    return;
                }

                if (txtContactNo.Text.Trim().Length == 0)
                {
                    ep.SetError(txtContactNo, "Vui lòng điền số điện thoại!");
                    txtContactNo.Focus();
                    return;
                }
                if (txtEmail.Text.Trim().Length == 0)
                {
                    ep.SetError(txtEmail, "Vui lòng điền email!");
                    txtEmail.Focus();
                    return;
                }
                if (txtAddress.Text.Trim().Length == 0)
                {
                    ep.SetError(txtAddress, "Vui lòng điền địa chỉ!");
                    txtAddress.Focus();
                    return;
                }
                if (txtTax.Text.Trim().Length == 0)
                {
                    ep.SetError(txtTax, "Vui lòng điền mã số thuế nhà cung cấp!");
                    txtTax.Focus();
                    return;
                }
                if (txtDiscript.Text.Trim().Length == 0)
                {
                    ep.SetError(txtDiscript, "Vui lòng điền ghi chú!");
                    txtDiscript.Focus();
                    return;
                }

                DataTable dt = DatabaseAccess.Retrive(string.Format("select * from NhaCungCap where ten_ncc = N'{0}' AND sdt = '{1}'", txtNameNCC.Text.Trim(), txtContactNo.Text.Trim() + "' and id_ncc != '" + Convert.ToString(dgvSuppliers.CurrentRow.Cells[0].Value)));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtNameNCC, "Đã đăng ký nhà cung cấp");
                        txtNameNCC.Focus();
                        return;
                    }
                }
  
                string updatequery = string.Format(
                    "UPDATE NhaCungCap SET id_taikhoan = '{0}', ten_ncc = N'{1}',sdt = N'{2}',email = N'{3}',dia_chi = N'{4}',ma_so_thue = N'{5}',ghi_chu = N'{6}' WHERE id_ncc = '{7}'",
                    UserInfo.id_taikhoan, txtNameNCC.Text.Trim(), txtContactNo.Text.Trim(), txtEmail.Text.Trim(), txtAddress.Text.Trim(), txtTax.Text.Trim(), txtDiscript.Text.Trim(), Convert.ToString(dgvSuppliers.CurrentRow.Cells[0].Value));

                bool result = DatabaseAccess.Update(updatequery);

                if (result == true)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    EnableComponents();
                }
                else
                {
                    MessageBox.Show("Vui lòng cung cấp thông tin chính xác, sau đó thử lại!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng cung cấp thông tin chính xác, sau đó thử lại!");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSuppliers != null)
                {
                    if (dgvSuppliers.Rows.Count > 0)
                    {
                        if (dgvSuppliers.SelectedRows.Count == 1)
                        {
                            txtNameNCC.Text = Convert.ToString(dgvSuppliers.CurrentRow.Cells[1].Value);    // Họ tên
                            txtContactNo.Text = Convert.ToString(dgvSuppliers.CurrentRow.Cells[3].Value);     // SĐT
                            txtEmail.Text = Convert.ToString(dgvSuppliers.CurrentRow.Cells[4].Value);    //Email
                            txtAddress.Text = Convert.ToString(dgvSuppliers.CurrentRow.Cells[5].Value);     //Địa chỉ
                            txtTax.Text = Convert.ToString(dgvSuppliers.CurrentRow.Cells[6].Value);    //Mã Số Thuế
                            txtDiscript.Text = Convert.ToString(dgvSuppliers.CurrentRow.Cells[6].Value);    //GhiChu

                            EnableComponents();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn một bản ghi!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }

        private void NhaCungCapFrm_Load(object sender, EventArgs e)
        {
            RetrieveList(string.Empty);
        }
    }
}
