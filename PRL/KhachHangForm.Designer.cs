namespace QuanLyBanHang.PRL
{
    partial class KhachHangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            tb_SLM = new TextBox();
            tb_SDT = new TextBox();
            tb_NameKH = new TextBox();
            tb_IDKH = new TextBox();
            groupBox2 = new GroupBox();
            bt_FixKH = new Button();
            groupBox3 = new GroupBox();
            dtg_DanhSachKH = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DanhSachKH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 43);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 0;
            label1.Text = "ID Khách Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 110);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 176);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 2;
            label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 247);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 3;
            label4.Text = "Số Lần Mua";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(tb_SLM);
            groupBox1.Controls.Add(tb_SDT);
            groupBox1.Controls.Add(tb_NameKH);
            groupBox1.Controls.Add(tb_IDKH);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(834, 335);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // tb_SLM
            // 
            tb_SLM.Location = new Point(9, 271);
            tb_SLM.Name = "tb_SLM";
            tb_SLM.ReadOnly = true;
            tb_SLM.Size = new Size(495, 29);
            tb_SLM.TabIndex = 7;
            // 
            // tb_SDT
            // 
            tb_SDT.Location = new Point(9, 200);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(495, 29);
            tb_SDT.TabIndex = 6;
            // 
            // tb_NameKH
            // 
            tb_NameKH.Location = new Point(9, 134);
            tb_NameKH.Name = "tb_NameKH";
            tb_NameKH.Size = new Size(495, 29);
            tb_NameKH.TabIndex = 5;
            // 
            // tb_IDKH
            // 
            tb_IDKH.Location = new Point(9, 67);
            tb_IDKH.Name = "tb_IDKH";
            tb_IDKH.ReadOnly = true;
            tb_IDKH.Size = new Size(495, 29);
            tb_IDKH.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(bt_FixKH);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(843, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 335);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bt_FixKH
            // 
            bt_FixKH.Image = (Image)resources.GetObject("bt_FixKH.Image");
            bt_FixKH.Location = new Point(42, 53);
            bt_FixKH.Name = "bt_FixKH";
            bt_FixKH.Size = new Size(389, 94);
            bt_FixKH.TabIndex = 0;
            bt_FixKH.Text = "Sửa Thông Tin Khách Hàng";
            bt_FixKH.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_FixKH.UseVisualStyleBackColor = true;
            bt_FixKH.Click += bt_FixKH_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(dtg_DanhSachKH);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(3, 343);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1310, 417);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách khách hàng";
            // 
            // dtg_DanhSachKH
            // 
            dtg_DanhSachKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DanhSachKH.Location = new Point(9, 28);
            dtg_DanhSachKH.Name = "dtg_DanhSachKH";
            dtg_DanhSachKH.Size = new Size(1288, 379);
            dtg_DanhSachKH.TabIndex = 0;
            dtg_DanhSachKH.CellClick += dtg_DanhSachKH_CellClick;
            // 
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 762);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "KhachHangForm";
            Text = "KhachHangForm";
            Load += KhachHangForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_DanhSachKH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dtg_DanhSachKH;
        private TextBox tb_SLM;
        private TextBox tb_SDT;
        private TextBox tb_NameKH;
        private TextBox tb_IDKH;
        private Button bt_FixKH;
    }
}