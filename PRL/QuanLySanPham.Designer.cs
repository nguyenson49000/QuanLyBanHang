namespace QuanLyBanHang.PRL
{
    partial class QuanLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySanPham));
            dtg_QuanLySanPham = new DataGridView();
            bt_Add = new Button();
            bt_Update = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb_TenSP = new TextBox();
            tb_Gia = new TextBox();
            tb_SL = new TextBox();
            tb_MoTa = new TextBox();
            tb_LoaiSP = new TextBox();
            tb_DanhGia = new TextBox();
            tb_ThuongHieu = new TextBox();
            groupBox1 = new GroupBox();
            cbb_TrangThai = new ComboBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ptb_AddImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtg_QuanLySanPham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_AddImg).BeginInit();
            SuspendLayout();
            // 
            // dtg_QuanLySanPham
            // 
            dtg_QuanLySanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_QuanLySanPham.Location = new Point(1, 430);
            dtg_QuanLySanPham.Name = "dtg_QuanLySanPham";
            dtg_QuanLySanPham.Size = new Size(784, 249);
            dtg_QuanLySanPham.TabIndex = 0;
            dtg_QuanLySanPham.CellClick += dtg_QuanLySanPham_CellClick;
            // 
            // bt_Add
            // 
            bt_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_Add.Image = (Image)resources.GetObject("bt_Add.Image");
            bt_Add.Location = new Point(23, 66);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new Size(164, 96);
            bt_Add.TabIndex = 1;
            bt_Add.Text = "Thêm Sản Phẩm";
            bt_Add.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_Add.UseVisualStyleBackColor = true;
            bt_Add.Click += bt_Add_Click;
            // 
            // bt_Update
            // 
            bt_Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_Update.Image = (Image)resources.GetObject("bt_Update.Image");
            bt_Update.Location = new Point(23, 273);
            bt_Update.Name = "bt_Update";
            bt_Update.Size = new Size(164, 96);
            bt_Update.TabIndex = 2;
            bt_Update.Text = "Sửa Sản Phẩm";
            bt_Update.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_Update.UseVisualStyleBackColor = true;
            bt_Update.Click += bt_Update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 4;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(28, 17);
            label2.TabIndex = 5;
            label2.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(6, 108);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 6;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(6, 158);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 7;
            label4.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(6, 206);
            label5.Name = "label5";
            label5.Size = new Size(98, 17);
            label5.TabIndex = 8;
            label5.Text = "Loại sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(6, 254);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 9;
            label6.Text = "Đánh giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(6, 302);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 10;
            label7.Text = "Thương hiệu";
            // 
            // tb_TenSP
            // 
            tb_TenSP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tb_TenSP.Location = new Point(6, 38);
            tb_TenSP.Name = "tb_TenSP";
            tb_TenSP.Size = new Size(383, 25);
            tb_TenSP.TabIndex = 12;
            // 
            // tb_Gia
            // 
            tb_Gia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tb_Gia.Location = new Point(6, 82);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.Size = new Size(383, 25);
            tb_Gia.TabIndex = 13;
            // 
            // tb_SL
            // 
            tb_SL.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tb_SL.Location = new Point(6, 130);
            tb_SL.Name = "tb_SL";
            tb_SL.Size = new Size(383, 25);
            tb_SL.TabIndex = 14;
            // 
            // tb_MoTa
            // 
            tb_MoTa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tb_MoTa.Location = new Point(6, 178);
            tb_MoTa.Name = "tb_MoTa";
            tb_MoTa.Size = new Size(383, 25);
            tb_MoTa.TabIndex = 15;
            // 
            // tb_LoaiSP
            // 
            tb_LoaiSP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tb_LoaiSP.Location = new Point(6, 226);
            tb_LoaiSP.Name = "tb_LoaiSP";
            tb_LoaiSP.Size = new Size(383, 25);
            tb_LoaiSP.TabIndex = 16;
            // 
            // tb_DanhGia
            // 
            tb_DanhGia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tb_DanhGia.Location = new Point(6, 274);
            tb_DanhGia.Name = "tb_DanhGia";
            tb_DanhGia.Size = new Size(383, 25);
            tb_DanhGia.TabIndex = 17;
            // 
            // tb_ThuongHieu
            // 
            tb_ThuongHieu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tb_ThuongHieu.Location = new Point(6, 322);
            tb_ThuongHieu.Name = "tb_ThuongHieu";
            tb_ThuongHieu.Size = new Size(383, 25);
            tb_ThuongHieu.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(cbb_TrangThai);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_ThuongHieu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_DanhGia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_LoaiSP);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_MoTa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tb_SL);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tb_Gia);
            groupBox1.Controls.Add(tb_TenSP);
            groupBox1.Location = new Point(186, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 439);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Location = new Point(6, 370);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(383, 25);
            cbb_TrangThai.TabIndex = 22;
            cbb_TrangThai.Text = "Chọn trạng thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(6, 350);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 21;
            label9.Text = "Trạng thái";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(bt_Update);
            groupBox2.Controls.Add(bt_Add);
            groupBox2.Location = new Point(585, -8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 437);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(ptb_AddImg);
            groupBox3.Location = new Point(-7, -7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(192, 437);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            // 
            // ptb_AddImg
            // 
            ptb_AddImg.Image = (Image)resources.GetObject("ptb_AddImg.Image");
            ptb_AddImg.Location = new Point(19, 65);
            ptb_AddImg.Name = "ptb_AddImg";
            ptb_AddImg.Size = new Size(163, 280);
            ptb_AddImg.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_AddImg.TabIndex = 0;
            ptb_AddImg.TabStop = false;
            ptb_AddImg.Click += ptb_AddImg_Click;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 681);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtg_QuanLySanPham);
            Name = "QuanLySanPham";
            Text = "QuanLySanPham";
            Load += QuanLySanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_QuanLySanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_AddImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_QuanLySanPham;
        private Button bt_Add;
        private Button bt_Update;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_TenSP;
        private TextBox tb_Gia;
        private TextBox tb_SL;
        private TextBox tb_MoTa;
        private TextBox tb_LoaiSP;
        private TextBox tb_DanhGia;
        private TextBox tb_ThuongHieu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox ptb_AddImg;
        private ComboBox cbb_TrangThai;
        private Label label9;
    }
}