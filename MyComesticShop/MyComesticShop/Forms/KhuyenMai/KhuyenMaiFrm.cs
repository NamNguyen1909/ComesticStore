using ComesticShop;
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
    public partial class KhuyenMaiFrm : Form
    {
        private int selectedMaKM = 0;

        public KhuyenMaiFrm()
        {
            InitializeComponent();
        }

        private void KhuyenMaiFrm_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void FillGrid(string searchValue)
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
                    if (dt.Rows.Count > 0)
                    {
                        dgvKhuyenMai.DataSource = dt;
                        FormatGrid(); // Hàm định dạng cột nếu có
                    }
                }
                else
                {
                    dgvKhuyenMai.DataSource = null;
                    MessageBox.Show("Không tìm thấy khuyến mãi phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }

        private void FormatGrid()
        {
            // FormatGrid hoặc sau khi gán DataSource
            dgvKhuyenMai.Columns[0].Width = 80;    // id_khuyen_mai - Mã
            dgvKhuyenMai.Columns[1].Width = 150;   // ten_KM - Tên khuyến mãi
            dgvKhuyenMai.Columns[2].Width = 100;   // ma_Code - Mã Code
            dgvKhuyenMai.Columns[3].Width = 80;    // phan_tram_giam - Giảm (%)
            dgvKhuyenMai.Columns[4].Width = 120;   // ngay_bat_dau - Ngày bắt đầu
            dgvKhuyenMai.Columns[5].Width = 120;   // ngay_ket_thuc - Ngày kết thúc
            dgvKhuyenMai.Columns[6].Width = 200;   // mo_ta - Mô tả
            dgvKhuyenMai.Columns[7].Width = 150;   // dieu_kien - Điều kiện
            dgvKhuyenMai.Columns[8].Visible = false;    // trang_thai - Trạng thái (Hiện/Ẩn)

            dgvKhuyenMai.Columns[0].HeaderText = "ID";
            dgvKhuyenMai.Columns[1].HeaderText = "Tên Khuyến Mãi";
            dgvKhuyenMai.Columns[2].HeaderText = "Mã Code";
            dgvKhuyenMai.Columns[3].HeaderText = "Giảm (%)";
            dgvKhuyenMai.Columns[4].HeaderText = "Ngày Bắt Đầu";
            dgvKhuyenMai.Columns[5].HeaderText = "Ngày Kết Thúc";
            dgvKhuyenMai.Columns[6].HeaderText = "Mô Tả";
            dgvKhuyenMai.Columns[7].HeaderText = "Điều Kiện";

        }

        private void ClearForm()
        {
            txtTenKM.Clear();
            txtMaCode.Clear();
            nudPhanTramGiam.Value = 0;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;
            txtMoTa.Clear();
            txtDieuKien.Clear();
        }

        private void EnableComponents()
        {
            btCancel.Enabled = true;
            btUpdate.Enabled = true;
            dgvKhuyenMai.Enabled = true;
            btAdd.Enabled = false;
            txtSearch.Enabled = false;
            btClear.Enabled = true;
        }
        private void ResetComponents()
        {
            btCancel.Enabled = false;
            btUpdate.Enabled = false;
            btAdd.Enabled = true;
            dgvKhuyenMai.Enabled = true;
            txtSearch.Enabled = true;
            btClear.Enabled = false; 

            ClearForm();
            FillGrid(string.Empty);

        }



        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();

                // Kiểm tra Tên khuyến mãi
                if (txtTenKM.Text.Trim().Length == 0)
                {
                    ep.SetError(txtTenKM, "Vui lòng nhập tên khuyến mãi!");
                    txtTenKM.Focus();
                    return;
                }

                // Kiểm tra Mã Code
                if (txtMaCode.Text.Trim().Length == 0)
                {
                    ep.SetError(txtMaCode, "Vui lòng nhập mã khuyến mãi!");
                    txtMaCode.Focus();
                    return;
                }

                // Kiểm tra Phần trăm giảm (numeric)
                if (nudPhanTramGiam.Value <= 0)
                {
                    ep.SetError(nudPhanTramGiam, "Phần trăm giảm phải lớn hơn 0!");
                    nudPhanTramGiam.Focus();
                    return;
                }

                // Kiểm tra ngày bắt đầu <= ngày kết thúc
                if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
                {
                    ep.SetError(dtpNgayKetThuc, "Ngày kết thúc phải sau ngày bắt đầu!");
                    dtpNgayKetThuc.Focus();
                    return;
                }

                // Kiểm tra Mô tả
                if (txtMoTa.Text.Trim().Length == 0)
                {
                    ep.SetError(txtMoTa, "Vui lòng nhập mô tả!");
                    txtMoTa.Focus();
                    return;
                }

                // Kiểm tra Điều kiện
                if (txtDieuKien.Text.Trim().Length == 0)
                {
                    ep.SetError(txtDieuKien, "Vui lòng nhập điều kiện!");
                    txtDieuKien.Focus();
                    return;
                }

                // Kiểm tra trùng mã khuyến mãi
                //string code = txtMaCode.Text.Trim();
                //DataTable dt = DatabaseAccess.Retrive(string.Format("SELECT * FROM KhuyenMai WHERE ma_Code = N'{0}' AND id_khuyen_mai != '{1}'",
                //    txtMaCode.Text.Trim(), 
                //    Convert.ToString(dgvKhuyenMai.CurrentRow.Cells[0].Value)));

                //string code = string.Format(
                //   "SELECT COUNT(*) FROM KhuyenMai WHERE MaCode = '{0}' AND MaKM != {1} AND TrangThai = 1",
                //   txtMaCode.Text.Trim().Replace("'", "''"), selectedMaKM);
                //if (dt != null)
                //{
                //    if (dt.Rows.Count > 0)

                //    {
                //        ep.SetError(txtMaCode, "Mã khuyến mãi đã tồn tại!");
                //        txtMaCode.Focus();
                //        return;
                //    }
                //}

                // Kiểm tra mã code đã tồn tại chưa (khi cập nhật)
                string code = string.Format(
                    "SELECT COUNT(*) FROM KhuyenMai WHERE MaCode = '{0}' AND MaKM != {1} AND TrangThai = 1",
                    txtMaCode.Text.Trim().Replace("'", "''"), selectedMaKM);

                //string checkQuery = string.Format("SELECT * FROM KhuyenMai WHERE ma_Code = N'{0}' AND id_khuyen_mai != '{1}'",
                //    txtMaCode.Text.Trim(),
                //    Convert.ToString(dgvKhuyenMai.CurrentRow.Cells[0].Value));

                try
                {
                    DataTable dt = DatabaseAccess.Retrive(code);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        int count = Convert.ToInt32(dt.Rows[0][0]);
                        if (count > 0)
                        {
                            ep.SetError(txtMaCode, "Mã code này đã tồn tại!");
                            txtMaCode.Focus();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra mã code: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string insertQuery = string.Format(
                    "INSERT INTO KhuyenMai (ten_KM, ma_Code, phan_tram_giam, ngay_bat_dau, ngay_ket_thuc, mo_ta, dieu_kien) " +
                    "VALUES (N'{0}', '{1}', {2}, '{3}', '{4}', N'{5}', N'{6}')",
                    txtTenKM.Text.Trim(),
                    txtMaCode.Text.Trim(),
                    nudPhanTramGiam.Value,
                    dtpNgayBatDau.Value.ToString("yyyy-MM-dd"),
                    dtpNgayKetThuc.Value.ToString("yyyy-MM-dd"),
                    txtMoTa.Text.Trim(),
                    txtDieuKien.Text.Trim()
                );

                bool result = DatabaseAccess.Insert(insertQuery);

                if (result == true)
                {
                    MessageBox.Show("Đã áp dụng thành công!");
                    ResetComponents();

                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();

                // Kiểm tra Tên khuyến mãi
                if (txtTenKM.Text.Trim().Length == 0)
                {
                    ep.SetError(txtTenKM, "Vui lòng nhập tên khuyến mãi!");
                    txtTenKM.Focus();
                    return;
                }

                // Kiểm tra Mã Code
                if (txtMaCode.Text.Trim().Length == 0)
                {
                    ep.SetError(txtMaCode, "Vui lòng nhập mã khuyến mãi!");
                    txtMaCode.Focus();
                    return;
                }

                // Kiểm tra Phần trăm giảm (numeric)
                int phanTramGiam;
                if (!int.TryParse(nudPhanTramGiam.Text, out phanTramGiam) || phanTramGiam <= 0 || phanTramGiam > 100)
                {
                    ep.SetError(nudPhanTramGiam, "Phần trăm giảm phải là số từ 1 đến 100!");
                    nudPhanTramGiam.Focus();
                    return;
                }


                // Kiểm tra ngày bắt đầu <= ngày kết thúc
                if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
                {
                    ep.SetError(dtpNgayKetThuc, "Ngày kết thúc phải sau ngày bắt đầu!");
                    dtpNgayKetThuc.Focus();
                    return;
                }

                // Kiểm tra Mô tả
                if (txtMoTa.Text.Trim().Length == 0)
                {
                    ep.SetError(txtMoTa, "Vui lòng nhập mô tả!");
                    txtMoTa.Focus();
                    return;
                }

                // Kiểm tra Điều kiện
                if (txtDieuKien.Text.Trim().Length == 0)
                {
                    ep.SetError(txtDieuKien, "Vui lòng nhập điều kiện!");
                    txtDieuKien.Focus();
                    return;
                }

                // Kiểm tra mã code đã tồn tại chưa (khi cập nhật)
                string checkQuery = string.Format(
                    "SELECT COUNT(*) FROM KhuyenMai WHERE ma_Code = '{0}' AND id_khuyen_mai != {1} AND trang_thai = 1",
                    txtMaCode.Text.Trim().Replace("'", "''"), selectedMaKM);

                //string checkQuery = string.Format("SELECT * FROM KhuyenMai WHERE ma_Code = N'{0}' AND id_khuyen_mai != '{1}'",
                //    txtMaCode.Text.Trim(),
                //    Convert.ToString(dgvKhuyenMai.CurrentRow.Cells[0].Value));

                try
                {
                    DataTable dt = DatabaseAccess.Retrive(checkQuery);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        int count = Convert.ToInt32(dt.Rows[0][0]);
                        if (count > 0)
                        {
                            ep.SetError(txtMaCode, "Mã code này đã tồn tại!");
                            txtMaCode.Focus();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra mã code: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string updatequery = string.Format(
                    "UPDATE KhuyenMai SET ten_KM = N'{0}', ma_Code = '{1}', phan_tram_giam = {2}, ngay_bat_dau = '{3}', ngay_ket_thuc = '{4}', mo_ta = N'{5}', dieu_kien = N'{6}' WHERE id_khuyen_mai = {7}",
                    txtTenKM.Text.Trim(),
                    txtMaCode.Text.Trim(),
                    nudPhanTramGiam.Value,
                    dtpNgayBatDau.Value.ToString("yyyy-MM-dd"),
                    dtpNgayKetThuc.Value.ToString("yyyy-MM-dd"),
                    txtMoTa.Text.Trim(),
                    txtDieuKien.Text.Trim(),
                    selectedMaKM
                   );

                bool result = DatabaseAccess.Insert(updatequery);

                if (result == true)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    ResetComponents();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại! Hãy thử lại!");
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedMaKM == 0)
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = string.Format("UPDATE KhuyenMai SET TrangThai = 0 WHERE MaKM = {0}", selectedMaKM);
                    bool result = DatabaseAccess.Update(deleteQuery);

                    if (result)
                    {
                        MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid(string.Empty);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khuyến mãi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKhuyenMai != null)
            {
                if (dgvKhuyenMai.Rows.Count > 0)
                {
                    if (dgvKhuyenMai.SelectedRows.Count == 1)
                    {
                        DataGridViewRow row = dgvKhuyenMai.CurrentRow;

                        selectedMaKM = Convert.ToInt32(row.Cells[0].Value);   // ID 
                        txtTenKM.Text = Convert.ToString(row.Cells[1].Value);
                        txtMaCode.Text = Convert.ToString(row.Cells[2].Value);
                        nudPhanTramGiam.Value = Convert.ToDecimal(row.Cells[3].Value); 
                        dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells[4].Value);
                        dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells[5].Value);
                        txtMoTa.Text = Convert.ToString(row.Cells[6].Value);
                        txtDieuKien.Text = Convert.ToString(row.Cells[7].Value);
                        

                        EnableComponents();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một bản ghi!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
