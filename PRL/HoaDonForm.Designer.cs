namespace QuanLyBanHang.PRL
{
    partial class HoaDonForm
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
            groupBox1 = new GroupBox();
            dtg_HoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            dtg_HDCT = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HDCT).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(dtg_HoaDon);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(1, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1310, 278);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dtg_HoaDon
            // 
            dtg_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HoaDon.Location = new Point(6, 28);
            dtg_HoaDon.Name = "dtg_HoaDon";
            dtg_HoaDon.Size = new Size(1298, 244);
            dtg_HoaDon.TabIndex = 0;
            dtg_HoaDon.CellClick += dtg_HoaDon_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(dtg_HDCT);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(1, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1310, 473);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtg_HDCT
            // 
            dtg_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HDCT.Location = new Point(6, 28);
            dtg_HDCT.Name = "dtg_HDCT";
            dtg_HDCT.Size = new Size(1298, 435);
            dtg_HDCT.TabIndex = 0;
            // 
            // HoaDonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 762);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "HoaDonForm";
            Text = "HoaDon";
            Load += HoaDonForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_HDCT).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dtg_HoaDon;
        private GroupBox groupBox2;
        private DataGridView dtg_HDCT;
    }
}