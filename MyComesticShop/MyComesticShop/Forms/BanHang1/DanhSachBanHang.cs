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

namespace MyComesticShop.Forms.BanHang1
{
    public partial class DanhSachBanHang : Form
    {
        public DanhSachBanHang()
        {
            InitializeComponent();
        }

        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            if (string.IsNullOrEmpty(searchValue))
            {
                query = " SELECT ten_san_pham AS[Tên sản phẩm], so_luong AS[Số lượng], gia_nhap AS [Giá nhập], gia_ban AS[Giá bán], id_danh_muc AS[ID danh mục] FROM v_ProductList ";
            }
            else
            {
                query = @"SELECT ten_san_pham AS [Tên sản phẩm], so_luong AS [Số lượng], 
                 gia_nhap AS [Giá nhập], gia_ban AS [Giá bán], id_danh_muc AS [ID danh mục] 
          FROM v_ProductList
          WHERE 
              (ten_san_pham + ' ' + 
               CAST(so_luong AS NVARCHAR) + ' ' + 
               CAST(gia_nhap AS NVARCHAR) + ' ' + 
               CAST(gia_ban AS NVARCHAR) + ' ' + 
               CAST(id_danh_muc AS NVARCHAR)) 
              LIKE N'%" + searchValue.Trim() + @"%'";
            }

            DataTable dt = DatabaseAccess.Retrive(query);

            if (dt != null)
            {
                dgvDsBanHang.DataSource = dt;

                // Cài đặt độ rộng các cột hiển thị
                dgvDsBanHang.Columns[0].Width = 200; // Tên SP
                dgvDsBanHang.Columns[1].Width = 120; // SL
                dgvDsBanHang.Columns[2].Width = 200; // Gia Nhap
                dgvDsBanHang.Columns[3].Width = 150; // Gia Ban
                dgvDsBanHang.Columns[4].Width = 120; // ID danh muc
            }
            else
            {
                dgvDsBanHang.DataSource = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }

        private void DanhSachBanHang_Load(object sender, EventArgs e)
        {
            RetrieveList(string.Empty);
        }
    }
}
