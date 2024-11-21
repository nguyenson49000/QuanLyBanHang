using Microsoft.Data.SqlClient;
using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.PRL
{
    public partial class Login : Form
    {
        TaiKhoanSer taiKhoanSer; 
        public Login()
        {
            taiKhoanSer = new TaiKhoanSer();
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = tbt_userName.Text;
            string pass = tbt_pass.Text;
            if (taiKhoanSer.Login(user,pass) == "0")
            {
                MessageBox.Show("Đăng nhập thất bại. Sai tên đăng nhập hoặc mật khẩu","Đăng nhập thất bại",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (taiKhoanSer.Login(user, pass) == "1")
            {
                MessageBox.Show("Đăng nhập thất bại. Tài khoản bị trùng lặp", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int idtk = int.Parse(taiKhoanSer.Login(user, pass));
                GiaoDien gd = new GiaoDien(idtk);
                this.Hide();
                gd.Show();
  
            }

        }

        private void cb_hidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hidePass.Checked)
            {
                tbt_pass.PasswordChar = '\0';
            }
            else
            {
                tbt_pass.PasswordChar = '*';
            }
        }
    }
}
