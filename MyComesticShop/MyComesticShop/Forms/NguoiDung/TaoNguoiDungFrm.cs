using MyComesticShop.Forms.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComesticShop.Forms.UserForms
{
    public partial class TaoNguoiDungFrm : Form
    {
        public int id_taikhoan = 0;

        public TaoNguoiDungFrm()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            TimKiemNVFrm frm = new TimKiemNVFrm(txtSearch.Text.Trim(), this);
            frm.ShowDialog();
        }

        private void TaoNguoiDungFrm_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa tất cả thông báo lỗi
                ep.Clear();

                // Kiểm tra EmployeeID
                if (id_taikhoan == 0)
                {
                    ep.SetError(btFind, "Vui lòng tìm kiếm nhân viên trước!");
                    txtSearch.Focus();
                    return;
                }

                // Kiểm tra UserName
                if (txtUserName.Text.Trim().Length == 0)
                {
                    ep.SetError(txtUserName, "Vui lòng nhập tên người dùng!");
                    txtUserName.Focus();
                    return;
                }

                // Kiểm tra Password
                if (txtPassword.Text.Trim().Length == 0)
                {
                    ep.SetError(txtPassword, "Vui lòng nhập mật khẩu!");
                    txtPassword.Focus();
                    return;
                }

                // Kiểm tra Confirm Password
                if (txtConfirmPassWords.Text.Trim().Length == 0)
                {
                    ep.SetError(txtConfirmPassWords, "Vui lòng xác nhận lại mật khẩu!");
                    txtConfirmPassWords.Focus();
                    return;
                }

                // So sánh Password và Confirm Password
                if (txtPassword.Text != txtConfirmPassWords.Text)
                {
                    ep.SetError(txtConfirmPassWords, "Không khớp!");
                    txtConfirmPassWords.Focus();
                    txtConfirmPassWords.SelectAll();
                    return;
                }

                DataTable dt = DatabaseLayer.DatabaseAccess.Retrive(string.Format("SELECT * FROM TaiKhoan WHERE ten_dang_nhap = '{0}' AND id_taikhoan != {1}", txtUserName.Text.Trim(), id_taikhoan));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtUserName, "Tên người dung đã tồn tại!");
                        txtUserName.Focus();
                        txtUserName.SelectAll();
                        return;
                    }
                }

                string createuser = string.Format("update TaiKhoan set ten_dang_nhap = '{0}', mat_khau = '{1}' where id_taikhoan = {2}", txtUserName.Text.Trim(), txtPassword.Text.Trim(), id_taikhoan);

                bool result = DatabaseLayer.DatabaseAccess.Update(createuser);
                if (result == true)
                {
                    MessageBox.Show("Tạo người dùng thành công");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Vui lòng thử lại!");
                }
            }
            catch 
            {

                MessageBox.Show("Vui lòng thử lại!");
            }
        }
        private void ResetForm()
        {
            id_taikhoan = 0;
            lbFullName.Text = "";
            lbContactNo.Text = "";
            lbCccd.Text = "";
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassWords.Clear();
        }

        private void lbFullName_Click(object sender, EventArgs e)
        {

        }
    }
}

