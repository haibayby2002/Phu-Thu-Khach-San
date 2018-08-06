using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuThuKhachSan
{
    class MatHang
    {
        //Properties
        private string tenMatHang;
        private decimal donGia;
        //---------------------------------------------------------------

        //Get, set
        public string TenMatHang { get => tenMatHang; set => tenMatHang = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        //---------------------------------------------------------------

        //Constructor
        public MatHang()
        {
            tenMatHang = "";
            donGia = 0;
        }

        public MatHang(string tenMatHang, decimal donGia)
        {
            this.tenMatHang = tenMatHang;
            this.donGia = donGia;
        }

        public MatHang(string s)
        {
            try
            {
                string[] temp = s.Split('|');
                this.tenMatHang = temp[0];
                this.donGia = Convert.ToDecimal(temp[1]);
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi chuỗi đầu vào\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tenMatHang = "";
                this.donGia = 0;
            }
            
        }
        //---------------------------------------------------------------

        //Function, Procedure
        public decimal TinhTien(int soLuong)
        {
            return soLuong * this.donGia;
        }
        //---------------------------------------------------------------
    }
}
