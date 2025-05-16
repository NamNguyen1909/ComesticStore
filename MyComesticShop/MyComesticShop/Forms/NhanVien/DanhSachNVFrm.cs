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

namespace MyComesticShop.Forms.NhanVien
{
    public partial class DanhSachNVFrm : Form
    {
        public DanhSachNVFrm()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue)
        {
            string query = "SELECT [id_taikhoan] AS [ID], [ho_ten] AS [Họ_tên], [id_phan_quyen], [sdt] AS [SĐT], [email] AS [Email], [cccd] AS [Số_Cccd], [dia_chi] AS [Địa chỉ], [ten_dang_nhap], [mat_khau] FROM [TaiKhoan]";

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
            dgvEmployee.Columns[7].Visible = false;   // Tên đăng nhập
            dgvEmployee.Columns[8].Visible = false;   // Mật khẩu
        }

        private void DanhSachNV_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }
    }
}
