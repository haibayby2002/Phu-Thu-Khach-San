using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuThuKhachSan
{
    public partial class HangHoaControl : UserControl
    {
        public HangHoaControl()
        {
            InitializeComponent();
            donGia = 0;
        }

        decimal donGia;

        public decimal DonGia { get => donGia; set => donGia = value; }

        public TextBox TxtSoLuong { get => txtSoLuong; set => txtSoLuong = value; }

        public CheckBox ChkLucChon { get => chkLuaChon; set => chkLuaChon = value; }

        public HangHoaControl(string tenMatHang)
        {
            InitializeComponent();
            lblTenMatHang.Text = tenMatHang;
            lblTenMatHang_TextChanged(null, null);
            donGia = 0;
        }

        public HangHoaControl(string tenMatHang, decimal donGia)
        {
            InitializeComponent();
            lblTenMatHang.Text = tenMatHang;
            lblTenMatHang_TextChanged(null, null);
            this.donGia = donGia;
        }


        private void chkLuaChon_CheckedChanged(object sender, EventArgs e)
        {
            txtSoLuong.Visible = chkLuaChon.Checked;
            if (Chk_LuaChon_CheckChanged != null)
            {
                Chk_LuaChon_CheckChanged(this, e);
            }
        }

        private void lblTenMatHang_TextChanged(object sender, EventArgs e)
        {
            chkLuaChon.Location = new Point(lblTenMatHang.Right + 12, chkLuaChon.Location.Y);
        }

        private void chkLuaChon_LocationChanged(object sender, EventArgs e)
        {
            //txtDonGia.Width = txtDonGia.Location.Y - chkLuaChon.Right - 3;
            txtSoLuong.Location = new Point(chkLuaChon.Location.X + 30, txtSoLuong.Location.Y);
            txtSoLuong.Size = new Size(this.Size.Width - txtSoLuong.Location.X - 3, txtSoLuong.Size.Height);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSoLuong.TextLength > 8)
            {
                MessageBox.Show("Số lượng hàng mua quá lớn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

            else if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }

            if (SoLuong_KeyPressed != null)
            {
                SoLuong_KeyPressed(this, e);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.TextLength > 3)
            {
                txtSoLuong.Text = XuLyDuLieu.ChuanHoaTien(txtSoLuong.Text);
                txtSoLuong.Select(txtSoLuong.TextLength, 0);
            }
            if (SoLuong_Changed != null)
            {
                SoLuong_Changed(this, e);
            }
        }

        private void TxtSoLuong_GotFocus(object sender, System.EventArgs e)
        {
            if (FocusSoLuongHang != null)
            {
                FocusSoLuongHang(this, e);
            }
        }

        public event EventHandler FocusSoLuongHang;

        public event EventHandler SoLuong_Changed;

        public event EventHandler SoLuong_KeyPressed;

        public event EventHandler Chk_LuaChon_CheckChanged;
    }
}
