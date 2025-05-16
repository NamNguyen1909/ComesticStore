using ComesticShop.SourceCode;
using MyComesticShop;
using MyComesticShop.DatabaseLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace MyComesticShop.Forms.DangNhap
{
    public partial class TrangDangNhapFrm : Form
    {
        private TrangChuFrm FormHome;
        public TrangDangNhapFrm(TrangChuFrm homeForm)
        {
            InitializeComponent();
            FormHome = homeForm;
        }

 

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            ep.Clear();
            if (txtTenDN.Text.Trim().Length == 0)
            {
                ep.SetError(txtTenDN, "Hãy nhập tên đăng nhập!");
                txtTenDN.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                ep.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }
            DataTable dt = DatabaseAccess.Retrive(
                string.Format("select id_taikhoan,id_phan_quyen,mat_khau,email from TaiKhoan where ten_dang_nhap = '{0}' and mat_khau = '{1}'", txtTenDN.Text.Trim(), txtMatKhau.Text.Trim()));

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    UserInfo.id_taikhoan = Convert.ToInt32(dt.Rows[0][0]);
                    UserInfo.id_phan_quyen = Convert.ToInt32(dt.Rows[0][1]);
                    UserInfo.email = Convert.ToString(dt.Rows[0][3]);
                    UserInfo.mat_khau = Convert.ToString(dt.Rows[0][2]);

                    lblError.Visible = false;
                    FormHome.DangNhap();
                    this.Close();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            QuenMatKhauFrm frm = new QuenMatKhauFrm();
            frm.ShowDialog();
        }
        private void FrmUserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
