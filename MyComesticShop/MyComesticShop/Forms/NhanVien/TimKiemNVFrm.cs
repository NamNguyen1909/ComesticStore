using MyComesticShop.DatabaseLayer;
using MyComesticShop.Forms.UserForms;
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
    public partial class TimKiemNVFrm : Form
    {
        public TaoNguoiDungFrm TaoNguoiDungForm { get; set; }
        public TimKiemNVFrm(string searchvalue, TaoNguoiDungFrm taoNguoiDungFrm)
        {

            InitializeComponent();
            TaoNguoiDungForm = taoNguoiDungFrm;
            txtSearch.Text = searchvalue;  // Đặt giá trị tìm kiếm ban đầu
            FillGrid(searchvalue);  // Hiển thị kết quả ban đầu
        }

        private void FillGrid(string searchvalue)
        {
            string query = "SELECT [id_taikhoan] AS [ID], [ho_ten] AS [Họ_tên], [id_phan_quyen], [sđt] AS [SĐT], [email] AS [Email], [cccd] AS [Số_Cccd], [dia_chi] AS [Địa chỉ] FROM [TaiKhoan]";

            if (!string.IsNullOrEmpty(searchvalue))
            {
                query += $" WHERE (ho_ten LIKE '%{searchvalue}%' OR sđt LIKE '%{searchvalue}%' OR email LIKE '%{searchvalue}%' OR cccd LIKE '%{searchvalue}%' OR dia_chi LIKE '%{searchvalue}%')";
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
        }
        private void TimKiemNVFrm_Load(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }


        public void SelectEmployee()
        {
            if (dgvEmployee != null)
            {
                if (dgvEmployee.Rows.Count > 0)
                {
                    if (dgvEmployee.SelectedRows.Count == 1)
                    {
                        if (TaoNguoiDungForm != null)
                        {
                            TaoNguoiDungForm.id_taikhoan = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[0].Value);   // Ma Nhan Vien
                            TaoNguoiDungForm.lbFullName.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[1].Value);   // Ho ten
                            TaoNguoiDungForm.lbContactNo.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[3].Value);   // Sdt
                            TaoNguoiDungForm.lbCccd.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[5].Value);   // CCCD
                            //TaoNguoiDungForm.txtUserName.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[7].Value);   // Tên đăng nhập
                            //TaoNguoiDungForm.txtPassword.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[8].Value);   // Mật khẩu
                            //TaoNguoiDungForm.txtConfirmPassWords.Text = Convert.ToString(dgvEmployee.CurrentRow.Cells[8].Value);   // Xac nhan Mật khẩu
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select One Record!");
                    }
                }
                else
                {
                    MessageBox.Show("List is Empty!");
                }
            }
        }
        

        private void dgvEmployee_KeyDown(object sender, KeyEventArgs e)
        {if(e.KeyCode == Keys.Enter)
            {
                SelectEmployee();
            }

        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectEmployee();
        }

        private void dgvEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectEmployee();
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectEmployee();
        }
    }
}
