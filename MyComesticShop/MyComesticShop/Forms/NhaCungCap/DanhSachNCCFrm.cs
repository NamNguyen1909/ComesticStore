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

namespace MyComesticShop.Forms.NhaCungCap
{
    public partial class DanhSachNCCFrm : Form
    {
        public DanhSachNCCFrm()
        {
            InitializeComponent();
        }

        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            if (string.IsNullOrEmpty(searchValue))
            {
                query = " SELECT id_ncc AS[ID_NCC], ten_ncc AS[Tên NCC], sdt AS[SĐT], email AS[Email], dia_chi AS[Địa Chỉ], ma_so_thue AS[Mã Số Thuế], ten_dang_nhap AS[Tạo Bởi], ghi_chu AS[Ghi Chú] FROM v_SupplierList ";
            }
            else
            {
                query = "SELECT id_ncc AS [ID_NCC], ten_ncc AS [Tên NCC], sdt AS [SĐT], email AS [Email], dia_chi AS [Địa Chỉ], ma_so_thue AS [Mã Số Thuế], ten_dang_nhap AS [Tạo Bởi], ghi_chu AS [Ghi Chú] FROM v_SupplierList" +
                    "where (ten_ncc + '' + sdt + '' + email + '' + dia_chi + '' + ma_so_thue + '' + ten_dang_nhap) like '%" + searchValue.Trim() + "%'";
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
                dgvSuppliers.Columns[6].Width = 100; // Tên DN
                dgvSuppliers.Columns[7].Width = 250; // ghi chú 
            }
            else
            {
                dgvSuppliers.DataSource = null;
            }
        }

        private void TimKiemNCCFrm_Load(object sender, EventArgs e)
        {
            RetrieveList(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }
    }
}
