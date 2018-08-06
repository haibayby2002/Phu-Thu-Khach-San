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
    public partial class LabelImage : UserControl
    {
        public LabelImage()
        {
            InitializeComponent();
        }

        public LabelImage(int soLuong, int toTien)
        {
            InitializeComponent();
            lbl.Text = soLuong.ToString();
            if (toTien == 500000)
            {
                ptbImage.Image = Properties.Resources._500000;
            }
            else if (toTien == 200000)
            {
                ptbImage.Image = Properties.Resources._200000;
            }
            else if (toTien == 100000)
            {
                ptbImage.Image = Properties.Resources._100000;
            }
            else if (toTien == 50000)
            {
                ptbImage.Image = Properties.Resources._50000;
            }
            else if (toTien == 20000)
            {
                ptbImage.Image = Properties.Resources._20000;
            }
            else if (toTien == 10000)
            {
                ptbImage.Image = Properties.Resources._10000;
            }
            else if (toTien == 5000)
            {
                ptbImage.Image = Properties.Resources._5000;
            }
            else if (toTien == 2000)
            {
                ptbImage.Image = Properties.Resources._2000;
            }
            else if(toTien == 1000)
            {
                ptbImage.Image = Properties.Resources._1000;
            }
            else if(toTien == 500)
            {
                ptbImage.Image = Properties.Resources._500;
            }
        }
    }
}
