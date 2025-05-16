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

namespace MyComesticShop.Forms.KhuyenMai
{
    public partial class TimKiemMaKMFrm : Form
    {
        private BanHangFrm banHangFrm;

        // Constructor chính - nhận BanHangFrm làm tham số
        public TimKiemMaKMFrm(string value, BanHangFrm BanHang)
        {
            InitializeComponent();
            banHangFrm = BanHang;
            txtSearchMaKhuyenMai.Text = value;
        }

        // Constructor không tham số - chỉ để thiết kế form
        public TimKiemMaKMFrm()
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
                            "dieu_kien AS [Điều Kiện]" +
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
               "dieu_kien AS [Điều Kiện] " +  // ✅ Bỏ dấu phẩy cuối
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
                dgvMaKhuyenMai.DataSource = dt;

                // Ẩn cột ID khuyến mãi
                dgvMaKhuyenMai.Columns[0].Visible = false; // id_khuyen_mai

                // Cài đặt độ rộng các cột hiển thị
                dgvMaKhuyenMai.Columns[1].Width = 200; // Tên Khuyến Mãi
                dgvMaKhuyenMai.Columns[2].Width = 120; // Mã Code
                dgvMaKhuyenMai.Columns[3].Width = 100; // Phần Trăm Giảm
                dgvMaKhuyenMai.Columns[4].Width = 120; // Ngày Bắt Đầu
                dgvMaKhuyenMai.Columns[5].Width = 120; // Ngày Kết Thúc
                dgvMaKhuyenMai.Columns[6].Visible = false; // Mô Tả
                dgvMaKhuyenMai.Columns[7].Visible = false; // Điều Kiện..
            }
            else
            {
                dgvMaKhuyenMai.DataSource = null;
            }
        }

        private void TimKiemMaKMFrm_Load(object sender, EventArgs e)
        {
            RetrieveList(txtSearchMaKhuyenMai.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearchMaKhuyenMai.Text.Trim());
        }

        private void TimKiemMaKMFrm_Activated(object sender, EventArgs e)
        {
            dgvMaKhuyenMai.Focus();
        }

        private void TimKiemMaKMFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvMaKhuyenMai.Rows.Count > 0)
                {
                    if (dgvMaKhuyenMai.SelectedRows.Count == 1)
                    {
                        SelectMaKhuyenMai();
                    }
                    else
                    {
                        dgvMaKhuyenMai.Rows[0].Selected = true;
                        SelectMaKhuyenMai();
                    }
                }
            }

        }

        public void SelectMaKhuyenMai()
        {
            if (banHangFrm != null)
            {
                banHangFrm.id_khuyen_mai = Convert.ToString(dgvMaKhuyenMai.CurrentRow.Cells[0].Value);
                banHangFrm.lbTieuDeKM.Text = Convert.ToString(dgvMaKhuyenMai.CurrentRow.Cells[1].Value);
                banHangFrm.lbThongTinKM.Text = Convert.ToString(dgvMaKhuyenMai.CurrentRow.Cells[2].Value);
                banHangFrm.lbPhanTramGiam.Text = Convert.ToString(dgvMaKhuyenMai.CurrentRow.Cells[3].Value);

                this.Close();
            }
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectMaKhuyenMai();
        }

        private void dgvMaKhuyenMai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectMaKhuyenMai();
        }

        private void dgvMaKhuyenMai_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectMaKhuyenMai();
        }
    }
 }
