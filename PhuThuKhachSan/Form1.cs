using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhuThuKhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        List<MatHang> listMatHang;

        private void frmMain_Load(object sender, EventArgs e)
        {
            listMatHang = new List<MatHang>();
            StreamReader r;
            try
            {
                r = new StreamReader("Mathang.txt");
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy file Mặt hàng.txt", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //Đọc mặt hàng vào class
            while (!r.EndOfStream)
            {
                MatHang mh = new MatHang(r.ReadLine());
                if (mh.TenMatHang != "")
                {
                    listMatHang.Add(mh);
                }
            }

            //Đọc class vào control
            for (int i = 0; i < listMatHang.Count; i++)
            {
                HangHoaControl hh = new HangHoaControl(listMatHang[i].TenMatHang, listMatHang[i].DonGia);
                hh.Location = new Point(5, (hh.Height + 2) * i);

                hh.FocusSoLuongHang += Hh_FocusSoLuongHang;
                hh.SoLuong_Changed += Hh_SoLuong_KeyPressed;
                hh.Chk_LuaChon_CheckChanged += Hh_Chk_LuaChon_CheckChanged;

                //MessageBox.Show(hh.DonGia.ToString());
                pnlMatHang.Controls.Add(hh);
            }

            
        }


        #region Xử lý thao tác với số lượng hàng
        string glb;

        private void Hh_FocusSoLuongHang(object sender, EventArgs e)
        {
            glb = (sender as HangHoaControl).Text;
            //MessageBox.Show(glb);
        }

        decimal tong;
        private void Hh_SoLuong_KeyPressed(object sender, EventArgs e)
        {
            tong = 0;
            for (int i = 0; i < pnlMatHang.Controls.Count; i++)
            {
                if (pnlMatHang.Controls[i] is HangHoaControl)
                {
                    HangHoaControl hh = pnlMatHang.Controls[i] as HangHoaControl;
                    if (hh.ChkLucChon.Checked && hh.TxtSoLuong.Text != "")
                    {
                        tong += (decimal)(int.Parse(hh.TxtSoLuong.Text.Replace(",", "")) * hh.DonGia);
                    }
                }
            }
            txtThanhTien.Text = tong != 0 ? XuLyDuLieu.ChuanHoaTien(tong) + " VND" : "";
        }

        private void Hh_Chk_LuaChon_CheckChanged(object sender, EventArgs e)
        {
            HangHoaControl HangHoa = sender as HangHoaControl;
            if (HangHoa.ChkLucChon.Checked)
            {
                if (HangHoa.TxtSoLuong.Text != "")
                {
                    tong += (decimal)(int.Parse(HangHoa.TxtSoLuong.Text.Replace(",", "")) * HangHoa.DonGia);
                }
            }
            else
            {
                if (HangHoa.TxtSoLuong.Text != "")
                {
                    tong -= (decimal)(int.Parse(HangHoa.TxtSoLuong.Text.Replace(",", "")) * HangHoa.DonGia);
                }
            }
            txtThanhTien.Text = tong != 0 ? XuLyDuLieu.ChuanHoaTien(tong) + " VND" : "";
        }

        //Tiền thối lại cho khách
        int[] tien = new int[] { 500000, 200000, 100000, 50000, 20000, 10000, 5000, 2000, 1000, 500 };
        List<LabelImage> listLi = new List<LabelImage>();
        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhachDua.Text != "" && txtThanhTien.Text != "")
            {
                decimal tienKhachDua = decimal.Parse(txtTienKhachDua.Text.Replace(",", ""));
                decimal tienThoiLai = tienKhachDua - tong;
                txtTienThoiLai.Text = XuLyDuLieu.ChuanHoaTien(tienThoiLai);

                pnlTienThoiLai.Controls.Clear();

                listLi = new List<LabelImage>();

                int dem = 0;
                foreach(int dv in tien)
                {
                    if (tienThoiLai >= dv)
                    {
                        int soLuong = (int)(tienThoiLai / dv);
                        LabelImage Li = new LabelImage(soLuong, dv);
                        tienThoiLai = tienThoiLai - soLuong * dv;
                        Li.Location = new Point(0, dem++ * 80);
                        listLi.Add(Li);
                        pnlTienThoiLai.Controls.Add(Li);
                    }
                }

            }
            else
            {
                txtTienThoiLai.Text = "";
            }
        }
        #endregion

        #region Xử lý tiền khách đưa
        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhachDua.TextLength > 3)
            {
                txtTienKhachDua.Text = XuLyDuLieu.ChuanHoaTien(txtTienKhachDua.Text);
                txtTienKhachDua.Select(txtTienKhachDua.TextLength, 0);
            }
            txtThanhTien_TextChanged(null, null);
        }
        #endregion


    }
}
