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
using static MyComesticShop.Program;

namespace MyComesticShop.Forms.KhachHang
{
    public partial class KhachHangFrm: Form
    {
        public KhachHangFrm()
        {
            InitializeComponent();
        }

        private void KhachHangFrm_Load(object sender, EventArgs e)
        {
            RetrieveList(string.Empty);
        }

        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            if (string.IsNullOrEmpty(searchValue))
            {
                query = "SELECT  sđtKH AS [SĐT khách hàng], ho_ten AS [Họ tên khách hàng], email AS [Email], dia_chi AS [Địa Chỉ] FROM KhachHang";
            }
            else
            {
                query = string.Format("SELECT  sđtKH AS [SĐT khách hàng], ho_ten AS [Họ tên khách hàng], email AS [Email], dia_chi AS [Địa Chỉ] FROM KhachHang WHERE (sđtKH + ho_ten + email + dia_chi) LIKE N'%{0}%'", searchValue.Trim());
            }


            DataTable dt = DatabaseAccess.Retrive(query);

            if (dt != null)
            {
                dgvCustomers.DataSource = dt;

                // Cài đặt độ rộng các cột hiển thị
                dgvCustomers.Columns[0].Width = 200; // Tên KH
                dgvCustomers.Columns[1].Width = 120; // SDT
                dgvCustomers.Columns[2].Width = 200; // Email
                dgvCustomers.Columns[3].Width = 150; // Địa Chỉ
            }
            else
            {
                dgvCustomers.DataSource = null;
            }
        }

        private void ClearForm()
        {
            txtNameKH.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        private void EnableComponents()
        {
            btCancel.Enabled = true;
            btUpdate.Enabled = true;
            dgvCustomers.Enabled = false;
            btSave.Enabled = false;
            btClear.Enabled = true;
            txtSearch.Enabled = false;
        }

        private void DisableComponents()
        {
            btCancel.Enabled = true;
            btUpdate.Enabled = false;
            btSave.Enabled = true;
            btClear.Enabled = true;
            dgvCustomers.Enabled = true;
            txtSearch.Enabled = true;
            ClearForm();
            RetrieveList(string.Empty);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtNameKH.Text.Trim().Length == 0)
                {
                    ep.SetError(txtNameKH, "Vui lòng chọn khách hàng!");
                    txtNameKH.Focus();
                    return;
                }

                if (txtContactNo.Text.Trim().Length == 0)
                {
                    ep.SetError(txtContactNo, "Vui lòng điền số điện thoại khách hàng!");
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
                

                DataTable dt = DatabaseAccess.Retrive(string.Format("select * from KhachHang where ho_ten = N'{0}' AND sđtKH = '{1}'", txtNameKH.Text.Trim(), txtContactNo.Text.Trim()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtNameKH, "Đã đăng ký khách hàng");
                        txtNameKH.Focus();
                        return;
                    }
                }
                string insertquery = string.Format(
                    "INSERT INTO KhachHang (sđtKH, ho_ten, email, dia_chi) " +
                    "VALUES ('{0}', N'{1}', N'{2}', N'{3}')",
                     txtContactNo.Text.Trim(), txtNameKH.Text.Trim(), txtEmail.Text.Trim(), txtAddress.Text.Trim());

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
                if (txtNameKH.Text.Trim().Length == 0)
                {
                    ep.SetError(txtNameKH, "Vui lòng chọn khách hàng!");
                    txtNameKH.Focus();
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

                DataTable dt = DatabaseAccess.Retrive(string.Format("select * from KhachHang where sđtKH = N'{0}' AND ho_ten = '{1}'", txtContactNo.Text.Trim(), txtNameKH.Text.Trim()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtNameKH, "Đã đăng ký khách hàng");
                        txtNameKH.Focus();
                        return;
                    }
                }
                //string insertquery = string.Format("INSERT INTO TaiKhoan (ho_ten, id_phan_quyen, sdt, email, cccd, dia_chi, ten_dang_nhap, mat_khau) " +
                //             "VALUES (N'{0}', '{1}', '{2}', '{3}', '{4}', N'{5}', '{6}', '{7}')",
                //    txtHoten.Text.Trim(), cmbPhanQuyen.SelectedValue, txtSDT.Text.Trim(), txtEmail.Text.Trim(),
                //    txtCccd.Text.Trim(), txtDC.Text.Trim(), txtDangNhap);

                string updatequery = string.Format(
                    "UPDATE KhachHang SET ho_ten = N'{0}', email = N'{1}', dia_chi = N'{2}' WHERE sđtKH = '{3}'",
                    txtNameKH.Text.Trim(), txtEmail.Text.Trim(), txtAddress.Text.Trim(), txtContactNo.Text.Trim());

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
                if (dgvCustomers != null)
                {
                    if (dgvCustomers.Rows.Count > 0)
                    {
                        if (dgvCustomers.SelectedRows.Count == 1)
                        {
                            txtNameKH.Text = Convert.ToString(dgvCustomers.CurrentRow.Cells[0].Value);    // Họ tên
                            txtContactNo.Text = Convert.ToString(dgvCustomers.CurrentRow.Cells[1].Value);     // SĐT
                            txtEmail.Text = Convert.ToString(dgvCustomers.CurrentRow.Cells[2].Value);    //Email
                            txtAddress.Text = Convert.ToString(dgvCustomers.CurrentRow.Cells[3].Value);     //Địa chỉ

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

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
