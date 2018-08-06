namespace PhuThuKhachSan
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grbMatHang = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.pnlMatHang = new System.Windows.Forms.Panel();
            this.lblTienKhachDua = new System.Windows.Forms.Label();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.lblThoiLai = new System.Windows.Forms.Label();
            this.txtTienThoiLai = new System.Windows.Forms.TextBox();
            this.pnlTienThoiLai = new System.Windows.Forms.Panel();
            this.grbMatHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMatHang
            // 
            this.grbMatHang.Controls.Add(this.txtThanhTien);
            this.grbMatHang.Controls.Add(this.lblThanhTien);
            this.grbMatHang.Controls.Add(this.pnlMatHang);
            this.grbMatHang.Location = new System.Drawing.Point(12, 12);
            this.grbMatHang.Name = "grbMatHang";
            this.grbMatHang.Size = new System.Drawing.Size(326, 430);
            this.grbMatHang.TabIndex = 0;
            this.grbMatHang.TabStop = false;
            this.grbMatHang.Text = "Mặt hàng: ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(6, 368);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(314, 26);
            this.txtThanhTien.TabIndex = 2;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(105, 342);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(101, 23);
            this.lblThanhTien.TabIndex = 1;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // pnlMatHang
            // 
            this.pnlMatHang.AutoScroll = true;
            this.pnlMatHang.Location = new System.Drawing.Point(6, 25);
            this.pnlMatHang.Name = "pnlMatHang";
            this.pnlMatHang.Size = new System.Drawing.Size(314, 314);
            this.pnlMatHang.TabIndex = 0;
            // 
            // lblTienKhachDua
            // 
            this.lblTienKhachDua.AutoSize = true;
            this.lblTienKhachDua.Location = new System.Drawing.Point(422, 12);
            this.lblTienKhachDua.Name = "lblTienKhachDua";
            this.lblTienKhachDua.Size = new System.Drawing.Size(117, 20);
            this.lblTienKhachDua.TabIndex = 1;
            this.lblTienKhachDua.Text = "Tiền khách đưa";
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Location = new System.Drawing.Point(375, 37);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(211, 26);
            this.txtTienKhachDua.TabIndex = 2;
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDua_TextChanged);
            this.txtTienKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKhachDua_KeyPress);
            // 
            // lblThoiLai
            // 
            this.lblThoiLai.AutoSize = true;
            this.lblThoiLai.Location = new System.Drawing.Point(729, 12);
            this.lblThoiLai.Name = "lblThoiLai";
            this.lblThoiLai.Size = new System.Drawing.Size(58, 20);
            this.lblThoiLai.TabIndex = 3;
            this.lblThoiLai.Text = "Thối lại";
            // 
            // txtTienThoiLai
            // 
            this.txtTienThoiLai.Location = new System.Drawing.Point(646, 37);
            this.txtTienThoiLai.Name = "txtTienThoiLai";
            this.txtTienThoiLai.ReadOnly = true;
            this.txtTienThoiLai.Size = new System.Drawing.Size(225, 26);
            this.txtTienThoiLai.TabIndex = 4;
            // 
            // pnlTienThoiLai
            // 
            this.pnlTienThoiLai.AutoScroll = true;
            this.pnlTienThoiLai.Location = new System.Drawing.Point(646, 89);
            this.pnlTienThoiLai.Name = "pnlTienThoiLai";
            this.pnlTienThoiLai.Size = new System.Drawing.Size(225, 353);
            this.pnlTienThoiLai.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 454);
            this.Controls.Add(this.pnlTienThoiLai);
            this.Controls.Add(this.txtTienThoiLai);
            this.Controls.Add(this.lblThoiLai);
            this.Controls.Add(this.txtTienKhachDua);
            this.Controls.Add(this.lblTienKhachDua);
            this.Controls.Add(this.grbMatHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Phụ thu khách sạn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbMatHang.ResumeLayout(false);
            this.grbMatHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMatHang;
        private System.Windows.Forms.Panel pnlMatHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTienKhachDua;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.Label lblThoiLai;
        private System.Windows.Forms.TextBox txtTienThoiLai;
        private System.Windows.Forms.Panel pnlTienThoiLai;
    }
}

