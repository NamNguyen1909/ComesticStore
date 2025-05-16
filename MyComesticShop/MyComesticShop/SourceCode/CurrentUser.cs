using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyComesticShop.SourceCode
{
    public static class CurrentUser
    {
        public static int id_taikhoan { get; set; }
        public static string ten_dang_nhap { get; set; }
        public static string ho_ten { get; set; }
        public static void Clear()
        {
            id_taikhoan = 0;
            ten_dang_nhap = string.Empty;
            ho_ten = string.Empty;
        }
    }
}
