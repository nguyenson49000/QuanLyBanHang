using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL.Models;
using QuanLyBanHang.DAL.Responsitories;

namespace QuanLyBanHang.PRL
{
    public partial class NhanVienForm : Form
    {
        NhanVienSer nhanVienSer = new NhanVienSer();
        TaiKhoanSer taiKhoanSer = new TaiKhoanSer();

        int selectedID;
        int idtk;
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void bt_AddNV_Click(object sender, EventArgs e)
        {
            string UserName = tb_TenTK.Text;
            string pass = tb_MatKhau.Text;
            int idtk = 0;
            if (!string.IsNullOrEmpty(UserName) || !string.IsNullOrEmpty(pass))
            {
                MessageBox.Show(taiKhoanSer.Create(UserName, pass), "TẠO THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<TaiKhoan> SearchTK = taiKhoanSer.SearchTK(UserName);
                idtk = SearchTK.First().Idtk;
            }
            else
            {
                MessageBox.Show("Vui lòng tạo tài khoản cho nhân viên mới", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string Ten = tb_TenNV.Text;
            string Mail = tb_Mail.Text;
            string sdt = tb_SDT.Text;
            string chucVu = tb_ChucVu.Text;
            NhanVien nv = new NhanVien()
            {

                TenNv = Ten,
                Mail = Mail,
                Sdt = sdt,
                ChucVu = chucVu,
                Idtk = idtk,
            };
            nhanVienSer.CreateNhanVien(nv);
            LoadData();

        }

        public void LoadData()
        {
            dataGridView1.Rows.Clear();
            var allDatas = nhanVienSer.GetAllNhanVien();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "ID Nhân Viên";
            dataGridView1.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridView1.Columns[2].HeaderText = "Mail";
            dataGridView1.Columns[3].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[4].HeaderText = "Chức Vụ";
            dataGridView1.Columns[5].HeaderText = "ID Tài Khoản";
            foreach (var data in allDatas)
            {
                if (data.ChucVu != "Đã nghỉ việc")
                {
                    dataGridView1.Rows.Add(data.Idnv, data.TenNv, data.Mail, data.Sdt, data.ChucVu, data.Idtk);
                }
            }
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            tb_TenNV.Text = row.Cells[1].Value.ToString();
            if (!string.IsNullOrEmpty(row.Cells[2].Value?.ToString()))
            {
                tb_Mail.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                tb_Mail.Text = "";
            }
            if (!string.IsNullOrEmpty(row.Cells[3].Value?.ToString()))
            {
                tb_SDT.Text = row.Cells[3].Value.ToString();
            }
            else
            {
                tb_SDT.Text = "";
            }
            tb_ChucVu.Text = row.Cells[4].Value.ToString();
            selectedID = Convert.ToInt32(row.Cells[0].Value.ToString());
            idtk = Convert.ToInt32(row.Cells[5].Value.ToString());

        }

        private void bt_FixNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien()
            {
                Idnv = selectedID,
                TenNv = tb_TenNV.Text,
                Mail = tb_Mail.Text,
                Sdt = tb_SDT.Text,
                ChucVu = tb_ChucVu.Text,
                Idtk = idtk
            };
            MessageBox.Show(nhanVienSer.UpdateNhanVien(nv, selectedID));
            LoadData();
        }

        private void bt_DelNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien()
            {
                Idnv = selectedID,
                TenNv = tb_TenNV.Text,
                Mail = tb_Mail.Text,
                Sdt = tb_SDT.Text,
                ChucVu = "Đã nghỉ việc",
                Idtk = idtk
            };
            nhanVienSer.UpdateNhanVien(nv, selectedID);
            LoadData();
        }

        private void cb_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienThiMK.Checked)
            {
                tb_MatKhau.PasswordChar = '\0';
            }
            else
            {
                tb_MatKhau.PasswordChar = '*';
            }
        }

        private void tb_MatKhau_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
