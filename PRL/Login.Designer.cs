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
            groupBox1 = new GroupBox();
            button1 = new Button();
            cb_hidePass = new CheckBox();
            tbt_pass = new TextBox();
            tbt_userName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cb_hidePass);
            groupBox1.Controls.Add(tbt_pass);
            groupBox1.Controls.Add(tbt_userName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(-2, -23);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(390, 844);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(105, 676);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 81);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_hidePass
            // 
            cb_hidePass.AutoSize = true;
            cb_hidePass.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_hidePass.Location = new Point(223, 511);
            cb_hidePass.Margin = new Padding(3, 4, 3, 4);
            cb_hidePass.Name = "cb_hidePass";
            cb_hidePass.Size = new Size(157, 27);
            cb_hidePass.TabIndex = 6;
            cb_hidePass.Text = "Show Password";
            cb_hidePass.UseVisualStyleBackColor = true;
            cb_hidePass.CheckedChanged += cb_hidePass_CheckedChanged;
            // 
            // tbt_pass
            // 
            tbt_pass.Font = new Font("Noto Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tbt_pass.Location = new Point(16, 465);
            tbt_pass.Margin = new Padding(3, 4, 3, 4);
            tbt_pass.Name = "tbt_pass";
            tbt_pass.PasswordChar = '*';
            tbt_pass.PlaceholderText = "Mật khẩu";
            tbt_pass.Size = new Size(351, 35);
            tbt_pass.TabIndex = 5;
            tbt_pass.TextChanged += textBox2_TextChanged;
            // 
            // tbt_userName
            // 
            tbt_userName.Font = new Font("Noto Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbt_userName.Location = new Point(16, 391);
            tbt_userName.Margin = new Padding(3, 4, 3, 4);
            tbt_userName.Name = "tbt_userName";
            tbt_userName.PlaceholderText = "Tên đăng nhập";
            tbt_userName.Size = new Size(351, 35);
            tbt_userName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label3.Location = new Point(16, 432);
            label3.Name = "label3";
            label3.Size = new Size(57, 29);
            label3.TabIndex = 3;
            label3.Text = "Pass";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label2.Location = new Point(16, 356);
            label2.Name = "label2";
            label2.Size = new Size(122, 29);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 256);
            label1.Name = "label1";
            label1.Size = new Size(159, 56);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(386, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(735, 821);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 815);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox tbt_pass;
        private TextBox tbt_userName;
        private Label label3;
        private Label label2;
        private Button button1;
        private CheckBox cb_hidePass;
        private PictureBox pictureBox2;
    }
}