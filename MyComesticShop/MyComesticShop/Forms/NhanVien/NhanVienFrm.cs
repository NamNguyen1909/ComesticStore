using MyComesticShop.DatabaseLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace ComesticShop
{
    public partial class NhanVienFrm : Form
    {
        public NhanVienFrm()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue)
        {
            string query = "SELECT [id_taikhoan] AS [ID], [ho_ten] AS [Họ Tên], [id_phan_quyen], [sdt] AS [SĐT], [email] AS [Email], [cccd] AS [Số Cccd], [dia_chi] AS [Địa Chỉ], [ten_dang_nhap], [mat_khau] FROM [TaiKhoan]";

            if (!string.IsNullOrEmpty(searchvalue))
            {
                query += $" WHERE (id_taikhoan LIKE '%{searchvalue}%' OR ho_ten LIKE '%{searchvalue}%' OR sđt LIKE '%{searchvalue}%' OR email LIKE '%{searchvalue}%' OR cccd LIKE '%{searchvalue}%' OR dia_chi LIKE '%{searchvalue}%')";
            }
            try
            {

                DataTable dt = DatabaseAccess.Retrive(query);   // DatabaseAccess su dung tu DatabasePlayer
                if (dt != null)
                {
                    dgvEmployee.DataSource = dt;
                    if (dt.Rows.Count > 0)
                    {
                        FormatGrid();
                    }
                }
                else
                {
                    dgvEmployee.DataSource = null;
                    MessageBox.Show("Không tìm thấy nhân viên khớp với yêu cầu tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            dgvEmployee.Columns[0].Width = 100;   // ID 
            dgvEmployee.Columns[1].Width = 150;   // Họ tên
            dgvEmployee.Columns[2].Visible = false;   // id Phân quyền
            dgvEmployee.Columns[3].Width = 100;   // SĐT
            dgvEmployee.Columns[4].Width = 150;   // Email
            dgvEmployee.Columns[5].Width = 100;   // Số CCCD
            dgvEmployee.Columns[6].Width = 200;   // Địa chỉ
            dgvEmployee.Columns[7].Width = 200;   // Tên đăng nhập
            dgvEmployee.Columns[8].Visible = false;   // Mật khẩu
        }

        private void FrmEmployee_load(object sender, EventArgs e)
        {
            ComboHelper.FillEmployeee(cmbPhanQuyen);
            FillGrid(string.Empty);
        }


        private void ClearForm()
        {
            txtHoten.Clear();
            cmbPhanQuyen.SelectedIndex = 0;
            txtCccd.Clear();
            txtDC.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtSearch.Clear();
        }

        private void EnableComponents()
        {
            btCancel.Enabled = true;
            btUpdate.Enabled = true;
            dgvEmployee.Enabled = true;
            btSave.Enabled = false;
            txtSearch.Enabled = false;
        }
        private void ResetComponents()
        {
            btCancel.Enabled = false;
            btUpdate.Enabled = false;
            btSave.Enabled = true;
            dgvEmployee.Enabled = true;
            txtSearch.Enabled = true;

            ClearForm();
            FillGrid(string.Empty);

        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtHoten.Text.Trim().Length == 0)
                {
                    ep.SetError(txtHoten, "Vui lòng điền đầy đủ họ tên!");
                    txtHoten.Focus();
                    return;
                }
                if (cmbPhanQuyen.SelectedIndex == 0)
                {
                    ep.SetError(cmbPhanQuyen, "Vui lòng chọn loại người dùng!");
                    cmbPhanQuyen.Focus();
                    return;
                }
                if (txtSDT.Text.Trim().Length == 0)
                {
                    ep.SetError(txtSDT, "Vui lòng điền số điện thoại!");
                    txtSDT.Focus();
                    return;
                }
                if (txtDC.Text.Trim().Length == 0)
                {
                    ep.SetError(txtDC, "Vui lòng điền địa chỉ!");
                    txtDC.Focus();
                    return;
                }
                DataTable dt = DatabaseAccess.Retrive(string.Format("select * from TaiKhoan where sđt = '{0}' and ho_ten = '{1}'", txtSDT.Text.Trim(), txtHoten.Text.Trim()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtHoten, "Đã đăng ký");
                        txtHoten.Focus();
                        return;
                    }
                }
                    string insertquery = string.Format(
                    "INSERT INTO TaiKhoan (ho_ten, id_phan_quyen, sđt, email, cccd, dia_chi) " +
                    "VALUES (N'{0}', '{1}', '{2}', '{3}', '{4}', N'{5}')",
                    txtHoten.Text.Trim(),
                    cmbPhanQuyen.SelectedValue,
                    txtSDT.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtCccd.Text.Trim(),
                    txtDC.Text.Trim());

                bool result = DatabaseAccess.Insert(insertquery);

                if (result == true)
                {
                    MessageBox.Show("Đã đăng ký thành công!");
                    ResetComponents();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }
            }
            catch
            {
                MessageBox.Show("Đăng ký thất bại! Hãy thử lại!");
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if(dgvEmployee !=null)
            {
                if (dgvEmployee.Rows.Count > 0)
                {
                    if(dgvEmployee.SelectedRows.Count == 1)
                    {
                        Convert.ToString(dgvEmployee.CurrentRow.Cells[0].Value);   // ID 
                        txtHoten.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[1].Value);    // Họ tên
                        cmbPhanQuyen.SelectedValue = Convert.ToString(dgvEmployee.CurrentRow.Cells[2].Value);   //id Phân quyền
                        txtSDT.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[3].Value);     // SĐT
                        txtEmail.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[4].Value);    //Email
                        txtCccd.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[5].Value);    //Số cccd
                        txtDC.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[6].Value);    //Địa chỉ

                        EnableComponents();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một bản ghi!", "Cảnh báo!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtHoten.Text.Trim().Length == 0)
                {
                    ep.SetError(txtHoten, "Vui lòng điền đầy đủ họ tên!");
                    txtHoten.Focus();
                    return;
                }
                if (cmbPhanQuyen.SelectedIndex == 0)
                {
                    ep.SetError(cmbPhanQuyen, "Vui lòng chọn loại người dùng!");
                    cmbPhanQuyen.Focus();
                    return;
                }
                if (txtSDT.Text.Trim().Length == 0)
                {
                    ep.SetError(txtSDT, "Vui lòng điền số điện thoại!");
                    txtSDT.Focus();
                    return;
                }
                if (txtDC.Text.Trim().Length == 0)
                {
                    ep.SetError(txtDC, "Vui lòng điền địa chỉ!");
                    txtDC.Focus();
                    return;
                }

                DataTable dt = DatabaseAccess.Retrive(string.Format("SELECT * FROM TaiKhoan WHERE sdt = '{0}' AND ho_ten = N'{1}' AND id_taikhoan != '{2}'", txtSDT.Text.Trim(), txtHoten.Text.Trim(), Convert.ToString(dgvEmployee.CurrentRow.Cells[0].Value)));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtHoten, "Đã đăng ký");
                        txtHoten.Focus();
                        return;
                    }
                }

                string updatequery = string.Format(
                            "update TaiKhoan set ho_ten = N'{0}', id_phan_quyen = '{1}', sdt = '{2}', email = '{3}', cccd = '{4}', dia_chi = N'{5}' where id_taikhoan = '{6}'",
                            txtHoten.Text.Trim(),
                            cmbPhanQuyen.SelectedValue,
                            txtSDT.Text.Trim(),
                            txtEmail.Text.Trim(),
                            txtCccd.Text.Trim(),
                            txtDC.Text.Trim(),
                            Convert.ToString(dgvEmployee.CurrentRow.Cells[0].Value)
                        );

                bool result = DatabaseAccess.Insert(updatequery);

                if (result == true)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    ResetComponents();

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại! Hãy thử lại!");
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (dgvEmployee.Rows.Count > 0)
            //{
            //    if (dgvEmployee.SelectedRows.Count == 1)
            //    {
            //        tsmiStatus.Visible = true;
            //        bool status = Convert.ToBoolean(dgvEmployee.CurrentRow.Cells[10].Value);
            //        if (status == false)
            //        {
            //            tsmiStatus.Text = "Active";
            //        }
            //        else
            //        {
            //            tsmiStatus.Text = "De-Active";
            //        }
            //    }
            //    else
            //    {
            //        tsmiStatus.Visible = false;
            //    }
            //}
            //else
            //{
            //    tsmiStatus.Visible = false;
            //}
        }

        private void tsmiStatus_Click(object sender, EventArgs e)
        {
            //if (dgvEmployee.Rows.Count > 0)
            //{
            //    if (dgvEmployee.SelectedRows.Count == 1)
            //    {
            //        tsmiStatus.Visible = true;
            //        bool changestatus = false;
            //        bool status = Convert.ToBoolean(dgvEmployee.CurrentRow.Cells[10].Value);
            //        if (tsmiStatus.Text == "Active")
            //        {
            //           changestatus = true;
            //        }
            //        else
            //        {
            //            changestatus = false;
            //        }
            //        string changestatusquery = string.Format("update TaiKhoan set IsActive = '{0}' where id_taikhoan = '{1}'",
            //           changestatus, Convert.ToString(dgvEmployee.CurrentRow.Cells[0].Value));
            //        bool result = DatabaseAccess.Update(changestatusquery);
            //        if (result)
            //        {
            //            ResetComponents();
            //            MessageBox.Show("Thay đổi thành công!");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Hãy thử lại!");
            //        }
            //    }
            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
