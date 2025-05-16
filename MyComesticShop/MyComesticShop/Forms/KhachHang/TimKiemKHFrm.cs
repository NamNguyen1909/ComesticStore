using MyComesticShop.DatabaseLayer;
using MyComesticShop.Forms.BanHang1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComesticShop.Forms.KhachHang
{
    public partial class TimKiemKHFrm : Form
    {
        BanHangFrm FormBanHang;
        public TimKiemKHFrm(string value, BanHangFrm BanHang)
        {
            InitializeComponent();
            FormBanHang = BanHang;
            txtSearch.Text = value;
        }

        private void TimKiemKHFrm_Load(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }

        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            //if (string.IsNullOrEmpty(searchValue))
            //{
            //    query = "SELECT sđtKH AS [ID_KhH], ho_ten AS [Tên KH], email AS [Email], dia_chi AS [Địa Chỉ], ten_dang_nhap AS [Tạo Bởi] FROM v_Customer_TaiKhoan";
            //}
            //else
            //{
            //    query = "SELECT sđtKH AS [ID_KhH], ho_ten AS [Tên KH], email AS [Email], dia_chi AS [Địa Chỉ], ten_dang_nhap AS [Tạo Bởi] " +
            //        "FROM v_Customer_TaiKhoan " +
            //        "WHERE (ho_ten + email + dia_chi + ten_dang_nhap) LIKE N'%" + searchValue.Trim() + "%'";

            //}

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                query = "SELECT sđtKH AS [SĐT khách hàng], ho_ten AS [Họ tên khách hàng], email AS [Email], dia_chi AS [Địa Chỉ] FROM KhachHang";
            }
            else
            {
                query = "SELECT sđtKH AS [SĐT khách hàng], ho_ten AS [Họ tên khách hàng], email AS [Email], dia_chi AS [Địa Chỉ] " +
                        "FROM KhachHang WHERE (ho_ten + email + dia_chi) LIKE N'%" + searchValue.Trim() + "%'";
            }

            DataTable dt = DatabaseAccess.Retrive(query);

            if (dt != null)
            {
                dgvCustomers.DataSource = dt;
                dgvCustomers.Columns[0].Visible = true; // Mã KH
                dgvCustomers.Columns[1].Width = 200; //
                dgvCustomers.Columns[2].Width = 120;
                dgvCustomers.Columns[3].Width = 200;
            }
            else
            {
                dgvCustomers.DataSource = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }

        private void TimKiemKHFrm_Activated(object sender, EventArgs e)
        {
            dgvCustomers.Focus();
        }

        private void dgvCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvCustomers.Rows.Count > 0)
                {
                    if (dgvCustomers.SelectedRows.Count == 1)
                    {
                        SelectCustomer();
                    }
                    else
                    {
                        dgvCustomers.Rows[0].Selected = true;
                        SelectCustomer();
                    }
                }
            }
        }

        public void SelectCustomer()
        {
            if (FormBanHang != null)
            {
                FormBanHang.id_KH = Convert.ToString(dgvCustomers.CurrentRow.Cells[0].Value);
                FormBanHang.lbCustomerName.Text = Convert.ToString(dgvCustomers.CurrentRow.Cells[1].Value);
                FormBanHang.lbContactNo.Text = Convert.ToString(dgvCustomers.CurrentRow.Cells[2].Value);
                this.Close();
            }
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectCustomer();
        }

        private void dgvCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCustomer();
        }
    }
}
