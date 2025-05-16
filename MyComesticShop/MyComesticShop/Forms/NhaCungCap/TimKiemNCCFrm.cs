using MyComesticShop.DatabaseLayer;
using MyComesticShop.Forms.NhapHang;
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
    public partial class TimKiemNCCFrm : Form
    {
        NhapHangFrm FormNhapHang;
        public TimKiemNCCFrm(string value, NhapHangFrm NhapHang)
        {
            InitializeComponent();
            FormNhapHang = NhapHang;
            txtSearch.Text = value;
            
        }
        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            if (string.IsNullOrEmpty(searchValue))
            {
                query = " SELECT id_ncc AS[ID_NCC], ten_ncc AS[Tên NCC], sdt AS[SĐT], email AS[Email], dia_chi AS[Địa Chỉ], ma_so_thue AS[Mã Số Thuế], ghi_chu AS[Ghi Chú] FROM NhaCungCap ";
            }
            else
            {
                query = "SELECT id_ncc AS [ID_NCC], ten_ncc AS [Tên NCC], sdt AS [SĐT], email AS [Email], dia_chi AS [Địa Chỉ], ma_so_thue AS [Mã Số Thuế], ghi_chu AS [Ghi Chú] FROM NhaCungCap " +
                    "WHERE (ten_ncc + sdt + email + dia_chi + ma_so_thue) LIKE N'%" + searchValue.Trim() + "%'";

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
                dgvSuppliers.Columns[6].Width = 250; // ghi chú 
            }
            else
            {
                dgvSuppliers.DataSource = null;
            }
        }
        private void TimKiemNCCFrm_Load(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }

        private void TimKiemNCCFrm_Activated(object sender, EventArgs e)
        {
            dgvSuppliers.Focus();
        }

        private void dgvSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvSuppliers.Rows.Count > 0)
                {
                    if (dgvSuppliers.SelectedRows.Count == 1)
                    {
                        SelectEmployee();
                    }
                    else
                    {
                        dgvSuppliers.Rows[0].Selected = true;
                        SelectEmployee();
                    }
                } 
            }
        }

        public void SelectEmployee()
        {
            if (FormNhapHang != null)
            {
                FormNhapHang.id_ncc = Convert.ToString(dgvSuppliers.CurrentRow.Cells[0].Value);
                FormNhapHang.lBSupplierName.Text = Convert.ToString(dgvSuppliers.CurrentRow.Cells[1].Value);
                FormNhapHang.lBContactNo.Text = Convert.ToString(dgvSuppliers.CurrentRow.Cells[2].Value);
                this.Close();
            }
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectEmployee();
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectEmployee();
        }

        private void dgvSuppliers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectEmployee();
        }
    }
}
