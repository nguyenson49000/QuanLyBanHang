namespace QuanLyBanHang.PRL
{
    partial class NhanVienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_TenNV = new TextBox();
            tb_Mail = new TextBox();
            tb_SDT = new TextBox();
            tb_ChucVu = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cb_HienThiMK = new CheckBox();
            tb_TenTK = new TextBox();
            tb_MatKhau = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            bt_DelNV = new Button();
            bt_FixNV = new Button();
            bt_AddNV = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(9, 174);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(9, 246);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Chức vụ";
            // 
            // tb_TenNV
            // 
            tb_TenNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            tb_TenNV.Location = new Point(6, 68);
            tb_TenNV.Name = "tb_TenNV";
            tb_TenNV.Size = new Size(355, 27);
            tb_TenNV.TabIndex = 6;
            // 
            // tb_Mail
            // 
            tb_Mail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            tb_Mail.Location = new Point(6, 129);
            tb_Mail.Name = "tb_Mail";
            tb_Mail.Size = new Size(355, 27);
            tb_Mail.TabIndex = 7;
            // 
            // tb_SDT
            // 
            tb_SDT.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            tb_SDT.Location = new Point(6, 197);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(355, 27);
            tb_SDT.TabIndex = 8;
            // 
            // tb_ChucVu
            // 
            tb_ChucVu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            tb_ChucVu.Location = new Point(9, 269);
            tb_ChucVu.Name = "tb_ChucVu";
            tb_ChucVu.Size = new Size(352, 27);
            tb_ChucVu.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_TenNV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_ChucVu);
            groupBox1.Controls.Add(tb_Mail);
            groupBox1.Controls.Add(tb_SDT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 348);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(cb_HienThiMK);
            groupBox2.Controls.Add(tb_TenTK);
            groupBox2.Controls.Add(tb_MatKhau);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(466, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 348);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tài khoản";
            // 
            // cb_HienThiMK
            // 
            cb_HienThiMK.AutoSize = true;
            cb_HienThiMK.Location = new Point(216, 163);
            cb_HienThiMK.Name = "cb_HienThiMK";
            cb_HienThiMK.Size = new Size(153, 24);
            cb_HienThiMK.TabIndex = 4;
            cb_HienThiMK.Text = "Hiển thị mật khẩu";
            cb_HienThiMK.UseVisualStyleBackColor = true;
            cb_HienThiMK.CheckedChanged += cb_HienThiMK_CheckedChanged;
            // 
            // tb_TenTK
            // 
            tb_TenTK.Location = new Point(10, 71);
            tb_TenTK.Name = "tb_TenTK";
            tb_TenTK.Size = new Size(359, 27);
            tb_TenTK.TabIndex = 3;
            // 
            // tb_MatKhau
            // 
            tb_MatKhau.Location = new Point(10, 130);
            tb_MatKhau.Name = "tb_MatKhau";
            tb_MatKhau.PasswordChar = '*';
            tb_MatKhau.Size = new Size(359, 27);
            tb_MatKhau.TabIndex = 2;
            tb_MatKhau.TextChanged += tb_MatKhau_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 107);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 1;
            label8.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 48);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 0;
            label7.Text = "Tên tài khoản";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(bt_DelNV);
            groupBox3.Controls.Add(bt_FixNV);
            groupBox3.Controls.Add(bt_AddNV);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(889, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(426, 348);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // bt_DelNV
            // 
            bt_DelNV.Image = (Image)resources.GetObject("bt_DelNV.Image");
            bt_DelNV.Location = new Point(128, 237);
            bt_DelNV.Name = "bt_DelNV";
            bt_DelNV.Size = new Size(155, 97);
            bt_DelNV.TabIndex = 2;
            bt_DelNV.Text = "Xóa nhân viên";
            bt_DelNV.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_DelNV.UseVisualStyleBackColor = true;
            bt_DelNV.Click += bt_DelNV_Click;
            // 
            // bt_FixNV
            // 
            bt_FixNV.Image = (Image)resources.GetObject("bt_FixNV.Image");
            bt_FixNV.Location = new Point(128, 132);
            bt_FixNV.Name = "bt_FixNV";
            bt_FixNV.Size = new Size(155, 97);
            bt_FixNV.TabIndex = 1;
            bt_FixNV.Text = "Sửa nhân viên";
            bt_FixNV.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_FixNV.UseVisualStyleBackColor = true;
            bt_FixNV.Click += bt_FixNV_Click;
            // 
            // bt_AddNV
            // 
            bt_AddNV.Image = (Image)resources.GetObject("bt_AddNV.Image");
            bt_AddNV.Location = new Point(128, 29);
            bt_AddNV.Name = "bt_AddNV";
            bt_AddNV.Size = new Size(155, 97);
            bt_AddNV.TabIndex = 0;
            bt_AddNV.Text = "Thêm nhân viên";
            bt_AddNV.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_AddNV.UseVisualStyleBackColor = true;
            bt_AddNV.Click += bt_AddNV_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1312, 407);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 762);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NhanVienForm";
            Text = "NhanVien";
            Load += NhanVienForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_TenNV;
        private TextBox tb_Mail;
        private TextBox tb_SDT;
        private TextBox tb_ChucVu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox cb_HienThiMK;
        private TextBox tb_TenTK;
        private TextBox tb_MatKhau;
        private Label label8;
        private Label label7;
        private GroupBox groupBox3;
        private Button bt_DelNV;
        private Button bt_FixNV;
        private Button bt_AddNV;
        private DataGridView dataGridView1;
    }
}