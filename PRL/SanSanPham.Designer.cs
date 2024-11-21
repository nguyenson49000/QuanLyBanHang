namespace QuanLyBanHang.PRL
{
    partial class SanSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanSanPham));
            bt_HienThiSanPham = new Button();
            tlp_HienThiSanPham = new TableLayoutPanel();
            lb_Back = new Label();
            lb_page = new Label();
            lb_Next = new Label();
            bt_TaoHoaDon = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            rdb_ChuyenKhoan = new RadioButton();
            rdb_TienMat = new RadioButton();
            button3 = new Button();
            dtg_hoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            dtg_HDCT = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tb_SDT = new TextBox();
            tb_TenKH = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HDCT).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // bt_HienThiSanPham
            // 
            bt_HienThiSanPham.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_HienThiSanPham.Image = (Image)resources.GetObject("bt_HienThiSanPham.Image");
            bt_HienThiSanPham.ImageAlign = ContentAlignment.TopCenter;
            bt_HienThiSanPham.Location = new Point(15, 22);
            bt_HienThiSanPham.Name = "bt_HienThiSanPham";
            bt_HienThiSanPham.Size = new Size(133, 98);
            bt_HienThiSanPham.TabIndex = 1;
            bt_HienThiSanPham.Text = "Show Sản Phẩm";
            bt_HienThiSanPham.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_HienThiSanPham.UseVisualStyleBackColor = true;
            bt_HienThiSanPham.Click += bt_HienThiSanPham_Click;
            // 
            // tlp_HienThiSanPham
            // 
            tlp_HienThiSanPham.ColumnCount = 2;
            tlp_HienThiSanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_HienThiSanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_HienThiSanPham.Location = new Point(160, 12);
            tlp_HienThiSanPham.Name = "tlp_HienThiSanPham";
            tlp_HienThiSanPham.RowCount = 2;
            tlp_HienThiSanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_HienThiSanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_HienThiSanPham.Size = new Size(800, 720);
            tlp_HienThiSanPham.TabIndex = 2;
            // 
            // lb_Back
            // 
            lb_Back.AutoSize = true;
            lb_Back.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Back.Location = new Point(498, 735);
            lb_Back.Name = "lb_Back";
            lb_Back.Size = new Size(43, 21);
            lb_Back.TabIndex = 3;
            lb_Back.Text = "<<<";
            lb_Back.Click += lb_Back_Click;
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_page.Location = new Point(551, 735);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(19, 21);
            lb_page.TabIndex = 4;
            lb_page.Text = "1";
            // 
            // lb_Next
            // 
            lb_Next.AutoSize = true;
            lb_Next.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Next.Location = new Point(580, 735);
            lb_Next.Name = "lb_Next";
            lb_Next.Size = new Size(43, 21);
            lb_Next.TabIndex = 5;
            lb_Next.Text = ">>>";
            lb_Next.Click += lb_Next_Click;
            // 
            // bt_TaoHoaDon
            // 
            bt_TaoHoaDon.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            bt_TaoHoaDon.Image = (Image)resources.GetObject("bt_TaoHoaDon.Image");
            bt_TaoHoaDon.ImageAlign = ContentAlignment.TopCenter;
            bt_TaoHoaDon.Location = new Point(15, 142);
            bt_TaoHoaDon.Name = "bt_TaoHoaDon";
            bt_TaoHoaDon.Size = new Size(133, 98);
            bt_TaoHoaDon.TabIndex = 6;
            bt_TaoHoaDon.Text = "Tạo Hóa Đơn";
            bt_TaoHoaDon.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_TaoHoaDon.UseVisualStyleBackColor = true;
            bt_TaoHoaDon.Click += bt_TaoHoaDon_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(15, 265);
            button2.Name = "button2";
            button2.Size = new Size(133, 98);
            button2.TabIndex = 7;
            button2.Text = "Quản Lý Sản Phẩm";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(rdb_ChuyenKhoan);
            groupBox1.Controls.Add(rdb_TienMat);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dtg_hoaDon);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(968, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 275);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // rdb_ChuyenKhoan
            // 
            rdb_ChuyenKhoan.AutoSize = true;
            rdb_ChuyenKhoan.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            rdb_ChuyenKhoan.Image = (Image)resources.GetObject("rdb_ChuyenKhoan.Image");
            rdb_ChuyenKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            rdb_ChuyenKhoan.Location = new Point(273, 34);
            rdb_ChuyenKhoan.Name = "rdb_ChuyenKhoan";
            rdb_ChuyenKhoan.Size = new Size(59, 29);
            rdb_ChuyenKhoan.TabIndex = 3;
            rdb_ChuyenKhoan.TabStop = true;
            rdb_ChuyenKhoan.Text = " ";
            rdb_ChuyenKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            rdb_ChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rdb_TienMat
            // 
            rdb_TienMat.AutoSize = true;
            rdb_TienMat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            rdb_TienMat.Image = (Image)resources.GetObject("rdb_TienMat.Image");
            rdb_TienMat.ImageAlign = ContentAlignment.MiddleLeft;
            rdb_TienMat.Location = new Point(208, 34);
            rdb_TienMat.Name = "rdb_TienMat";
            rdb_TienMat.Size = new Size(59, 29);
            rdb_TienMat.TabIndex = 2;
            rdb_TienMat.TabStop = true;
            rdb_TienMat.Text = " ";
            rdb_TienMat.TextImageRelation = TextImageRelation.ImageBeforeText;
            rdb_TienMat.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 20);
            button3.Name = "button3";
            button3.Size = new Size(188, 54);
            button3.TabIndex = 1;
            button3.Text = "Thanh toán";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dtg_hoaDon
            // 
            dtg_hoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hoaDon.Location = new Point(6, 80);
            dtg_hoaDon.Name = "dtg_hoaDon";
            dtg_hoaDon.RowHeadersWidth = 51;
            dtg_hoaDon.Size = new Size(329, 189);
            dtg_hoaDon.TabIndex = 0;
            dtg_hoaDon.CellClick += dtg_hoaDon_CellClick;
            dtg_hoaDon.CellContentClick += dtg_hoaDon_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(dtg_HDCT);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(968, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 438);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm trong hóa đơn";
            // 
            // dtg_HDCT
            // 
            dtg_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HDCT.Location = new Point(6, 39);
            dtg_HDCT.Name = "dtg_HDCT";
            dtg_HDCT.RowHeadersWidth = 51;
            dtg_HDCT.Size = new Size(329, 393);
            dtg_HDCT.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label1.Location = new Point(11, 42);
            label1.Name = "label1";
            label1.Size = new Size(89, 13);
            label1.TabIndex = 10;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label2.Location = new Point(11, 109);
            label2.Name = "label2";
            label2.Size = new Size(76, 13);
            label2.TabIndex = 11;
            label2.Text = "Số điện thoại";
            // 
            // tb_SDT
            // 
            tb_SDT.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            tb_SDT.Location = new Point(11, 125);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(133, 22);
            tb_SDT.TabIndex = 12;
            // 
            // tb_TenKH
            // 
            tb_TenKH.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            tb_TenKH.Location = new Point(11, 60);
            tb_TenKH.Name = "tb_TenKH";
            tb_TenKH.Size = new Size(133, 22);
            tb_TenKH.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(tb_TenKH);
            groupBox3.Controls.Add(tb_SDT);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(3, 404);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(154, 327);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khách hàng";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightGray;
            groupBox4.Controls.Add(bt_HienThiSanPham);
            groupBox4.Controls.Add(bt_TaoHoaDon);
            groupBox4.Controls.Add(button2);
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            groupBox4.Location = new Point(3, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(154, 392);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // SanSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 762);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lb_Next);
            Controls.Add(lb_page);
            Controls.Add(lb_Back);
            Controls.Add(tlp_HienThiSanPham);
            Name = "SanSanPham";
            Text = "SanPham";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_HDCT).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_HienThiSanPham;
        private TableLayoutPanel tlp_HienThiSanPham;
        private Label lb_Back;
        private Label lb_page;
        private Label lb_Next;
        private Button bt_TaoHoaDon;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private DataGridView dtg_hoaDon;
        private GroupBox groupBox2;
        private DataGridView dtg_HDCT;
        private RadioButton rdb_ChuyenKhoan;
        private RadioButton rdb_TienMat;
        private Label label1;
        private Label label2;
        private TextBox tb_SDT;
        private TextBox tb_TenKH;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}