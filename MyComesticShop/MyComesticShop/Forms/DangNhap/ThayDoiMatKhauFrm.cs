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

namespace MyComesticShop.Forms.DangNhap
{
    public partial class ThayDoiMatKhauFrm : Form
    {
        public ThayDoiMatKhauFrm()
        {
            InitializeComponent();
        }

        private void ThayDoiMatKhau_Load(object sender, EventArgs e)
        {
        }

        private void btnTDoiMK_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtMKCu.Text.Trim().Length == 0)
            {
                ep.SetError(txtMKCu, "Hãy nhập mật khẩu cũ!");
                txtMKCu.Focus();
                return;
            }

            if (txtMKMoi.Text.Trim().Length == 0)
            {
                ep.SetError(txtMKMoi, "Hãy nhập mật khẩu mới!");
                txtMKMoi.Focus();
                return;
            }

            if (txtNhapLaiMK.Text.Trim().Length == 0)
            {
                ep.SetError(txtMKMoi, "Hãy nhập lại mật khẩu!");
                txtNhapLaiMK.Focus();
                return;
            }

            if (txtMKMoi.Text.Trim() != txtNhapLaiMK.Text.Trim())
            {
                ep.SetError(txtNhapLaiMK, "2 mật khẩu không trùng khớp!");
                txtNhapLaiMK.Focus();
                txtNhapLaiMK.SelectAll();
                return;
            }

            if (txtMKCu.Text.Trim() != UserInfo.mat_khau)
            {
                ep.SetError(txtMKCu, "Mật khẩu cũ không đúng");
                txtMKCu.Focus();
                txtMKCu.SelectAll();
                return;
            }


            string updatepassword = string.Format("Update TaiKhoan set mat_khau = '{0}' where id_taikhoan = '{1}'",
                                                         txtMKMoi.Text.Trim(), UserInfo.id_taikhoan);
            bool result = DatabaseAccess.Update(updatepassword);
            if (result == true)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                UserInfo.mat_khau = txtMKMoi.Text.Trim();
                txtMKCu.Clear();
                txtMKMoi.Clear();
                txtNhapLaiMK.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại!");
            }

        }
    }
}
