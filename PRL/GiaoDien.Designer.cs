namespace QuanLyBanHang.PRL
{
    partial class GiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien));
            bt_SanPham = new Button();
            bt_NhanVien = new Button();
            bt_HoaDon = new Button();
            pn_ChucNang = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_SanPham
            // 
            bt_SanPham.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_SanPham.Image = (Image)resources.GetObject("bt_SanPham.Image");
            bt_SanPham.ImageAlign = ContentAlignment.MiddleLeft;
            bt_SanPham.Location = new Point(12, 22);
            bt_SanPham.Name = "bt_SanPham";
            bt_SanPham.Size = new Size(182, 75);
            bt_SanPham.TabIndex = 0;
            bt_SanPham.Text = "Sản Phẩm";
            bt_SanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_SanPham.UseVisualStyleBackColor = true;
            bt_SanPham.Click += bt_SanPham_Click;
            // 
            // bt_NhanVien
            // 
            bt_NhanVien.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_NhanVien.Image = (Image)resources.GetObject("bt_NhanVien.Image");
            bt_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            bt_NhanVien.Location = new Point(12, 103);
            bt_NhanVien.Name = "bt_NhanVien";
            bt_NhanVien.Size = new Size(182, 75);
            bt_NhanVien.TabIndex = 1;
            bt_NhanVien.Text = "Nhân Viên";
            bt_NhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_NhanVien.UseVisualStyleBackColor = true;
            bt_NhanVien.Click += bt_NhanVien_Click;
            // 
            // bt_HoaDon
            // 
            bt_HoaDon.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_HoaDon.Image = (Image)resources.GetObject("bt_HoaDon.Image");
            bt_HoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            bt_HoaDon.Location = new Point(12, 184);
            bt_HoaDon.Name = "bt_HoaDon";
            bt_HoaDon.Size = new Size(182, 75);
            bt_HoaDon.TabIndex = 2;
            bt_HoaDon.Text = "Hóa Đơn";
            bt_HoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_HoaDon.UseVisualStyleBackColor = true;
            bt_HoaDon.Click += bt_HoaDon_Click;
            // 
            // pn_ChucNang
            // 
            pn_ChucNang.Location = new Point(200, 9);
            pn_ChucNang.Margin = new Padding(3, 2, 3, 2);
            pn_ChucNang.Name = "pn_ChucNang";
            pn_ChucNang.Size = new Size(1328, 801);
            pn_ChucNang.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, 358);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 265);
            button1.Name = "button1";
            button1.Size = new Size(182, 75);
            button1.TabIndex = 5;
            button1.Text = "Khách Hàng";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GiaoDien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 812);
            Controls.Add(button1);
            Controls.Add(bt_HoaDon);
            Controls.Add(bt_SanPham);
            Controls.Add(bt_NhanVien);
            Controls.Add(pictureBox1);
            Controls.Add(pn_ChucNang);
            Name = "GiaoDien";
            Text = "GiaoDien";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bt_SanPham;
        private Button bt_NhanVien;
        private Button bt_HoaDon;
        private Panel pn_ChucNang;
        private PictureBox pictureBox1;
        private Button button1;
    }
}