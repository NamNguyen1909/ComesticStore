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

namespace MyComesticShop.Forms.UserForms
{
    public partial class DanhSachNDFrm : Form
    {
        public DanhSachNDFrm()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue)
        {
            string query = "SELECT [id_taikhoan] AS [ID], [ho_ten] AS [Họ_tên], [id_phan_quyen], [sđt] AS [SĐT], [email] AS [Email], [cccd] AS [Số_Cccd], [dia_chi] AS [Địa chỉ], [ten_dang_nhap], [mat_khau] FROM [TaiKhoan] where ten_dang_nhap is not null ";

            if (!string.IsNullOrEmpty(searchvalue))
            {
                query += $" and (ho_ten LIKE '%{searchvalue}%' OR sđt LIKE '%{searchvalue}%' OR email LIKE '%{searchvalue}%' OR cccd LIKE '%{searchvalue}%' OR dia_chi LIKE '%{searchvalue}%')";
            }
            try
            {

                DataTable dt = DatabaseAccess.Retrive(query);   // DatabaseAccess su dung tu DatabasePlayer
                if (dt != null)
                {
                    dgvAllUsers.DataSource = dt;
                    if (dt.Rows.Count > 0)
                    {
                        FormatGrid();
                    }
                }
                else
                {
                    dgvAllUsers.DataSource = null;
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
            dgvAllUsers.Columns[0].Width = 100;   // ID 
            dgvAllUsers.Columns[1].Width = 150;   // Họ tên
            dgvAllUsers.Columns[2].Visible = false;   // id Phân quyền
            dgvAllUsers.Columns[3].Width = 100;   // SĐT
            dgvAllUsers.Columns[4].Width = 150;   // Email
            dgvAllUsers.Columns[5].Width = 100;   // Số CCCD
            dgvAllUsers.Columns[6].Width = 200;   // Địa chỉ
            dgvAllUsers.Columns[7].Width = 200;   // Tên đăng nhập
            dgvAllUsers.Columns[8].Visible = false;   // Mật khẩu
        }
        private void DanhSachNDFrm_Load(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

            private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUser();
        }

        public void RemoveUser()
        {
            // Kiểm tra nếu DataGridView (dgvAllUsers) rỗng
            if (dgvAllUsers != null)
            {
                if (dgvAllUsers.Rows.Count > 0)
                {
                    if (dgvAllUsers.SelectedRows.Count == 1)
                    {
                        int id_taikhoan = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value);
                        int id_phan_quyen = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[2].Value);
                        if (id_phan_quyen != 1)
                        {
                            string removeQuery = string.Format("UPDATE TaiKhoan SET ten_dang_nhap = NULL WHERE id_taikhoan = {0}", id_taikhoan);
                            bool result = DatabaseAccess.Update(removeQuery);
                            if (result == true)
                            {
                                MessageBox.Show("Xóa người dùng thành công!");
                                FillGrid(txtSearch.Text.Trim());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Quản trị viên không thể tự xóa chính mình!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!!! Vui lòng thử lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Danh sách trống!!!");
                }
            }
            else
            {
                MessageBox.Show("Danh sách trống!!!");
            }
        }


    }
}
