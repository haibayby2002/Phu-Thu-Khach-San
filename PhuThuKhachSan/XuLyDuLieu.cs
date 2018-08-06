using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuThuKhachSan
{
    class XuLyDuLieu
    {
        public static string ChuanHoaTien(string s)
        {
            return String.Format("{0:0,0}", Convert.ToDecimal(s));
        }

        public static string ChuanHoaTien(decimal s)
        {
            return String.Format("{0:0,0}", s);
        }
    }
}
