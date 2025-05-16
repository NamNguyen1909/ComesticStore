using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComesticShop.DatabaseLayer
{
    class DatabaseAccess
    {
        //    private static SqlConnection conn;

        //    public static SqlConnection ConnOpen()
        //    {

        //        if (conn == null)
        //        {
        //            conn = new SqlConnection(@"Data Source=DESKTOP-35QDHJG;Initial Catalog=TheCosmeticShop;Integrated Security=True");
        //}
        //        if (conn.State != System.Data.ConnectionState.Open)
        //        {
        //            conn.Open();
        //        }
        //            return conn;
        //    }
        public static SqlConnection ConnOpen()
        {
            string connStr = @"Data Source=DESKTOP-35QDHJG;Initial Catalog=TheCosmeticShop;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
        }


        public static bool ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection conn = ConnOpen())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


        public static bool Insert(String query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if (noofrecord > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(String query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if (noofrecord > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        internal static DataTable Retrive(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, ConnOpen());
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    return dt;
                }             
            }
            catch 
            {

                return null;
            }
        }

        public static bool Update(String query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noofrecord = cmd.ExecuteNonQuery();
                if (noofrecord > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable Retrive(String query, Dictionary<string, object> parameters)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, ConnOpen());
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    return dt;
                }
            }
            catch
            {

                return null;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

    }
}
