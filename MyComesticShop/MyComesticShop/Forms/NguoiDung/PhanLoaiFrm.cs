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

namespace MyComesticShop.Forms
{
    public partial class PhanLoaiFrm : Form
    {
        public PhanLoaiFrm()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue)
        {
            string query = "select id_phan_quyen [ID], ten_quyen [Ten Quyen] from PhanQuyen";
            if (!string.IsNullOrEmpty(searchvalue))
            {
                query += " where ten_quyen like '%" + searchvalue + "%'";
            }

            DataTable dt = DatabaseAccess.Retrive(query);
            if (dt != null)
            {
                dgvPhanQuyen.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dgvPhanQuyen.Columns[0].Width = 100;
                    dgvPhanQuyen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgvPhanQuyen.DataSource = null;
            }
        }

        private void ClearForm()
        {
            txtTenPL.Clear();
            txtSearch.Clear();
        }


        private void btClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            FillGrid(string.Empty);
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtTenPL.Text.Trim().Length == 0)
            {
                ep.SetError(txtTenPL, "Vui lòng nhập tên phân loại!!!");
                txtTenPL.Focus();
                return;
            }

            //kiem tra ten da ton tai chua
            DataTable dt = DatabaseAccess.Retrive("select * from PhanQuyen where PhanQuyen Like = '" + txtTenPL.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtTenPL, "Đã đăng ký rồi!");
                    txtTenPL.Focus();
                    txtTenPL.SelectAll();
                    return;
                }
            }

            string insertquery = string.Format("insert into PhanQuyen(ten_quyen) values ('" + txtTenPL.Text.Trim() + "')");
            bool result = DatabaseAccess.Insert(insertquery);

            if (result == true)
            {
                MessageBox.Show(this, "Lưu Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chỉ xóa nội dung txtTenPL để nhập tiếp
                btClear_Click(sender, e);

                // Cập nhật lại lưới
                FillGrid(string.Empty);
            }
            else
            {
                ep.SetError(btSave, "Lỗi khi lưu. Vui lòng thử lại!");
                txtTenPL.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void PhanLoaiFrm_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void EnableComponents()
        {
            btCancel.Enabled = true;
            btUpdate.Enabled = true;
            dgvPhanQuyen.Enabled = false;
            btSave.Enabled = false;
            txtSearch.Enabled = false;
        }

        private void ResetComponents()
        {
            btCancel.Enabled = false;
            btUpdate.Enabled = false;
            dgvPhanQuyen.Enabled = true;
            btSave.Enabled = true;
            txtSearch.Enabled = true;
            ClearForm();
            FillGrid(string.Empty);
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            if (dgvPhanQuyen != null)
            {
                if (dgvPhanQuyen.Rows.Count > 0)
                {
                    if (dgvPhanQuyen.SelectedRows.Count == 1)
                    {
                        txtTenPL.Text = Convert.ToString(dgvPhanQuyen.CurrentRow.Cells[1].Value);
                        EnableComponents();

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một bản ghi!", "Cảnh báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtTenPL.Text.Trim().Length == 0)
            {
                ep.SetError(txtTenPL, "Vui lòng nhập tên phân loại!!!");
                txtTenPL.Focus();
                return;
            }
            DataTable dt = DatabaseAccess.Retrive("select * from PhanQuyen where PhanQuyen Like = '" + txtTenPL.Text.Trim() + "'  where id_phan_quyen != '" + Convert.ToString(dgvPhanQuyen.CurrentRow.Cells[0].Value) + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtTenPL, "Đã đăng ký rồi!");
                    txtTenPL.Focus();
                    txtTenPL.SelectAll();
                    return;
                }
            }
            string insertquery = string.Format("update PhanQuyen set ten_quyen = '" + txtTenPL.Text.Trim() + "' where id_phan_quyen = '" + Convert.ToString(dgvPhanQuyen.CurrentRow.Cells[0].Value) + "'");
            bool result = DatabaseAccess.Update(insertquery);
            if (result == true)
            {
                ResetComponents();
                MessageBox.Show("Cập Nhật Thành Công!!!");
            }
            else
            {
                ep.SetError(btUpdate, "Vui lòng thử lại!");
                txtTenPL.Focus();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ResetComponents();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhanQuyen.SelectedRows.Count == 1)
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string id = dgvPhanQuyen.CurrentRow.Cells[0].Value.ToString();
                    string deleteQuery = "DELETE FROM PhanQuyen WHERE id_phan_quyen = '" + id + "' ";
                    bool result = DatabaseAccess.Delete(deleteQuery); // đảm bảo có hàm này trong DatabaseAccess

                    if (result)
                    {
                        FillGrid(string.Empty);
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
