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

namespace MyComesticShop.Forms.NhapHang
{
    public partial class DanhSachNhapHang : Form
    {
        public DanhSachNhapHang()
        {
            InitializeComponent();
        }
        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            if (string.IsNullOrEmpty(searchValue))
            {
                query = " SELECT ten_san_pham AS[Tên sản phẩm], id_sanpham AS[ID sản phẩm], id_nhap AS [ID nhập], soluong AS[Số lượng], don_gia AS[Đơn giá nhập], Gia_Tong_SP AS[Giá tổng nhập] FROM v_NhapHangTongGia ";
            }
            else
            {
                query = @"SELECT ten_san_pham AS[Tên sản phẩm], id_sanpham AS[ID sản phẩm], 
                id_nhap AS [ID nhập], soluong AS[Số lượng], don_gia AS[Đơn giá nhập],
                Gia_Tong_SP AS[Giá tổng nhập] FROM v_NhapHangTongGia
          WHERE 
              (ten_san_pham + ' ' + 
               CAST(id_sanpham AS NVARCHAR) + ' ' + 
               CAST(id_nhap AS NVARCHAR) + ' ' + 
               CAST(soluong AS NVARCHAR) + ' ' + 
               CAST(don_gia AS NVARCHAR)) + ' ' +  
                CAST(Gia_Tong_SP AS NVARCHAR)
              LIKE N'%" + searchValue.Trim() + @"%'";
            }

            DataTable dt = DatabaseAccess.Retrive(query);

            if (dt != null)
            {
                dgvDsNhapHang.DataSource = dt;

                // Cài đặt độ rộng các cột hiển thị
                dgvDsNhapHang.Columns[0].Width = 200; // Tên SP
                dgvDsNhapHang.Columns[1].Width = 120; // SL
                dgvDsNhapHang.Columns[2].Width = 200; // Gia Nhap
                dgvDsNhapHang.Columns[3].Width = 150; // Gia Ban
                dgvDsNhapHang.Columns[4].Width = 120; // ID danh muc
                dgvDsNhapHang.Columns[5].Width = 120; // ID danh muc
            }
            else
            {
                dgvDsNhapHang.DataSource = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }

        private void DanhSachNhapHang_Load(object sender, EventArgs e)
        {
            RetrieveList(string.Empty);
        }
    }
}
