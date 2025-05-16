using MyComesticShop.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComesticShop
{
    public class ComboHelper
    {

        public static void FillEmployeee(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_phan_quyen");
            dt.Columns.Add("ten_quyen");
            dt.Rows.Add("0", "----User Type----");

            var dbdt = DatabaseAccess.Retrive("SELECT id_phan_quyen, ten_quyen FROM PhanQuyen");

            if (dbdt != null)
            {
                if (dbdt.Rows.Count > 0)
                {
                    foreach (DataRow types in dbdt.Rows)
                    {
                        dt.Rows.Add(types["id_phan_quyen"], types["ten_quyen"]);
                    }
                }
            }
            cmb.DataSource = dt;
            cmb.DisplayMember = "ten_quyen";
            cmb.ValueMember = "id_phan_quyen";
        }

        public static void Categories(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_danh_muc");
            dt.Columns.Add("ten_danh_muc");
            dt.Rows.Add("0", "----Select Type----");

            var dbdt = DatabaseAccess.Retrive("SELECT id_danh_muc, ten_danh_muc FROM DanhMuc");

            if (dbdt != null)
            {
                if (dbdt.Rows.Count > 0)
                {
                    foreach (DataRow types in dbdt.Rows)
                    {
                        dt.Rows.Add(types["id_danh_muc"], types["ten_danh_muc"]);
                    }
                }
            }
            cmb.DataSource = dt;
            cmb.DisplayMember = "ten_danh_muc";
            cmb.ValueMember = "id_danh_muc";
        }

        public static void Products(ComboBox cmb, string id_danhmuc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_sanpham");
            dt.Columns.Add("ten_san_pham");
            dt.Rows.Add("0", "----Select Type----");

            var dbdt = DatabaseAccess.Retrive("SELECT id_sanpham, ten_san_pham FROM v_ProductList where id_danh_muc = '" + id_danhmuc + "'");

            if (dbdt != null)
            {
                if (dbdt.Rows.Count > 0)
                {
                    foreach (DataRow row in dbdt.Rows)
                    {
                        dt.Rows.Add(row["id_sanpham"], row["ten_san_pham"]);
                    }
                }

                cmb.DataSource = dt;
                cmb.DisplayMember = "ten_san_pham";
                cmb.ValueMember = "id_sanpham";
            }
        }
    }
}
