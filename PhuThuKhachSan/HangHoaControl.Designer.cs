namespace PhuThuKhachSan
{
    partial class HangHoaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTenMatHang = new System.Windows.Forms.Label();
            this.chkLuaChon = new System.Windows.Forms.CheckBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTenMatHang
            // 
            this.lblTenMatHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTenMatHang.AutoSize = true;
            this.lblTenMatHang.Location = new System.Drawing.Point(-4, 11);
            this.lblTenMatHang.Name = "lblTenMatHang";
            this.lblTenMatHang.Size = new System.Drawing.Size(84, 20);
            this.lblTenMatHang.TabIndex = 0;
            this.lblTenMatHang.Text = "Mặt hàng: ";
            this.lblTenMatHang.TextChanged += new System.EventHandler(this.lblTenMatHang_TextChanged);
            // 
            // chkLuaChon
            // 
            this.chkLuaChon.AutoSize = true;
            this.chkLuaChon.Location = new System.Drawing.Point(86, 15);
            this.chkLuaChon.Name = "chkLuaChon";
            this.chkLuaChon.Size = new System.Drawing.Size(15, 14);
            this.chkLuaChon.TabIndex = 1;
            this.chkLuaChon.UseVisualStyleBackColor = true;
            this.chkLuaChon.CheckedChanged += new System.EventHandler(this.chkLuaChon_CheckedChanged);
            this.chkLuaChon.LocationChanged += new System.EventHandler(this.chkLuaChon_LocationChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSoLuong.Location = new System.Drawing.Point(168, 8);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(109, 26);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.Visible = false;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            this.txtSoLuong.GotFocus += TxtSoLuong_GotFocus;
            // 
            // HangHoaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.chkLuaChon);
            this.Controls.Add(this.lblTenMatHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HangHoaControl";
            this.Size = new System.Drawing.Size(280, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label lblTenMatHang;
        private System.Windows.Forms.CheckBox chkLuaChon;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}
