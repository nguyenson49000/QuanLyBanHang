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
    public partial class GiaoDien : Form
    {
        int idtk = 0;
        public GiaoDien(int id)
        {
            idtk = id;
            InitializeComponent();
        }

        private void bt_SanPham_Click(object sender, EventArgs e)
        {
            pn_ChucNang.Controls.Clear();
            SanSanPham sp = new SanSanPham(idtk);
            sp.TopLevel = false;
            pn_ChucNang.Controls.Add(sp);
            sp.FormBorderStyle = FormBorderStyle.None;
            sp.Show();
        }

        private void bt_NhanVien_Click(object sender, EventArgs e)
        {
            pn_ChucNang.Controls.Clear();
            NhanVienForm nvf = new NhanVienForm();
            nvf.TopLevel = false;
            pn_ChucNang.Controls.Add(nvf);
            nvf.FormBorderStyle = FormBorderStyle.None;
            nvf.Show();

        }

        private void bt_HoaDon_Click(object sender, EventArgs e)
        {
            pn_ChucNang.Controls.Clear();
            HoaDonForm hdf = new HoaDonForm();
            hdf.TopLevel = false;
            pn_ChucNang.Controls.Add(hdf);
            hdf.FormBorderStyle = FormBorderStyle.None;
            hdf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_ChucNang.Controls.Clear();
            KhachHangForm kh = new KhachHangForm();
            kh.TopLevel = false;
            pn_ChucNang.Controls.Add(kh);
            kh.FormBorderStyle = FormBorderStyle.None;
            kh.Show();
        }
    }
}
