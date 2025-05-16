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

namespace MyComesticShop.Forms.KhuyenMai
{
    public partial class DanhSachMaKhuyenMai : Form
    {
        public DanhSachMaKhuyenMai()
        {
            InitializeComponent();
        }

        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            if (string.IsNullOrEmpty(searchValue))
            {
                query = "SELECT id_khuyen_mai AS [ID KM], " +
                             "ten_KM AS [Tên Khuyến Mãi], " +
                             "ma_Code AS [Mã Code], " +
                             "phan_tram_giam AS [% Giảm], " +
                             "ngay_bat_dau AS [Ngày Bắt Đầu], " +
                             "ngay_ket_thuc AS [Ngày Kết Thúc], " +
                             "mo_ta AS [Mô Tả], " +
                             "dieu_kien AS [Điều Kiện], " +
                             "trang_thai AS [Trạng Thái] " +
                             "FROM KhuyenMai";
            }
            else
            {
                query = "SELECT id_khuyen_mai AS [ID KM], " +
                         "ten_KM AS [Tên Khuyến Mãi], " +
                         "ma_Code AS [Mã Code], " +
                         "phan_tram_giam AS [% Giảm], " +
                         "ngay_bat_dau AS [Ngày Bắt Đầu], " +
                         "ngay_ket_thuc AS [Ngày Kết Thúc], " +
                         "mo_ta AS [Mô Tả], " +
                         "dieu_kien AS [Điều Kiện], " +
                         "trang_thai AS [Trạng Thái] " +
                         "FROM KhuyenMai " +
                         "WHERE (CAST(id_khuyen_mai AS NVARCHAR) + " +
                         "ISNULL(ten_KM, '') + " +
                         "ISNULL(ma_Code, '') + " +
                         "CAST(phan_tram_giam AS NVARCHAR) + " +
                         "FORMAT(ngay_bat_dau, 'yyyy-MM-dd') + " +
                         "FORMAT(ngay_ket_thuc, 'yyyy-MM-dd') + " +
                         "ISNULL(mo_ta, '') + " +
                         "ISNULL(dieu_kien, '') + " +
                         "CAST(trang_thai AS NVARCHAR)) LIKE N'%" +
                         searchValue.Trim().Replace("'", "''") + "%'";

            }

            DataTable dt = DatabaseAccess.Retrive(query);

            if (dt != null)
            {
                dgvKhuyenMai.DataSource = dt;

                // Cài đặt độ rộng các cột hiển thị theo dữ liệu từ KhuyenMai
                dgvKhuyenMai.Columns[0].Width = 80;   // ID KM
                dgvKhuyenMai.Columns[1].Width = 150;  // Tên Khuyến Mãi
                dgvKhuyenMai.Columns[2].Width = 100;  // Mã Code
                dgvKhuyenMai.Columns[3].Width = 80;   // % Giảm
                dgvKhuyenMai.Columns[4].Width = 110;  // Ngày Bắt Đầu
                dgvKhuyenMai.Columns[5].Width = 110;  // Ngày Kết Thúc
                dgvKhuyenMai.Columns[6].Width = 200;  // Mô Tả
                dgvKhuyenMai.Columns[7].Width = 200;  // Điều Kiện
                dgvKhuyenMai.Columns[8].Width = 90;   // Trạng Thái
            }
            else
            {
                dgvKhuyenMai.DataSource = null;
            }
        }

        private void DanhSachMaKhuyenMai_Load(object sender, EventArgs e)
        {
            RetrieveList(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }
    }
}
