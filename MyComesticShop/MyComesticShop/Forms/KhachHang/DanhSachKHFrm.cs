using MyComesticShop.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyComesticShop.Program;

namespace MyComesticShop.Forms.KhachHang
{
    public partial class DanhSachKHFrm: Form
    {
        public DanhSachKHFrm()
        {
            InitializeComponent();
        }

        //private void RetrieveList(string searchValue)
        //{
        //    string query = string.Empty;
        //    if (string.IsNullOrEmpty(searchValue))
        //    {
        //        query = "SELECT sđtKH AS [SĐT khách hàng], ho_ten AS [Họ tên khách hàng],  email AS [Email], dia_chi AS [Địa Chỉ] FROM KhachHang";
        //    }
        //    else
        //    {
        //        query = $"SELECT sđtKH AS [SĐT khách hàng], ho_ten AS [Họ tên khách hàng], email AS [Email], dia_chi AS [Địa Chỉ] " +
        //                $"FROM KhachHang WHERE " +
        //                $"sđtKH LIKE N'%{searchValue}%' OR " +
        //                $" LIKE N'%{searchValue}%' OR " +
        //                $"email LIKE N'%{searchValue}%' OR " +
        //                $"dia_chi LIKE N'%{searchValue}%'";

        //    }

        //    DataTable dt = DatabaseAccess.Retrive(query);

        //    if (dt != null)
        //    {
        //        dgvCustomers.DataSource = dt;

        //        // Cài đặt độ rộng các cột hiển thị
        //        dgvCustomers.Columns[0].Width = 200; // Tên KH
        //        dgvCustomers.Columns[1].Width = 120; // SDT
        //        dgvCustomers.Columns[2].Width = 200; // Email
        //        dgvCustomers.Columns[3].Width = 150; // Địa Chỉ

        //    }
        //    else
        //    {
        //        dgvCustomers.DataSource = null;
        //    }
        //}

        private void RetrieveList(string searchValue)
        {
            string query = string.Empty;

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                query = "SELECT sđtKH AS [SĐT khách hàng], ho_ten AS [Họ tên khách hàng], email AS [Email], dia_chi AS [Địa Chỉ] FROM KhachHang";
            }
            else
            {
                query = "SELECT sđtKH AS [SĐT khách hàng], ho_ten AS [Họ tên khách hàng], email AS [Email], dia_chi AS [Địa Chỉ] " +
                        "FROM KhachHang WHERE sđtKH LIKE @value OR ho_ten LIKE @value OR email LIKE @value OR dia_chi LIKE @value";
            }

            using (SqlConnection conn = DatabaseAccess.ConnOpen())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchValue))
                        {
                            cmd.Parameters.AddWithValue("@value", "%" + searchValue + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCustomers.DataSource = dt;

                        // Cài đặt độ rộng các cột hiển thị nếu có dữ liệu
                        if (dt.Columns.Count >= 4)
                        {
                            dgvCustomers.Columns[0].Width = 200;
                            dgvCustomers.Columns[1].Width = 120;
                            dgvCustomers.Columns[2].Width = 200;
                            dgvCustomers.Columns[3].Width = 150;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvCustomers.DataSource = null;
                }
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveList(txtSearch.Text.Trim());
        }

        private void DanhSachKHFrm_Load(object sender, EventArgs e)
        {
            RetrieveList(string.Empty);
           
        }
    }
}
