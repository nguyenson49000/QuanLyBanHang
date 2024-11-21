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
    public partial class QuanLySanPham : Form
    {
        int selectedID = -1;
        SanPhamSer _ser;
        public QuanLySanPham()
        {
            _ser = new SanPhamSer();
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            string ten = tb_TenSP.Text;
            int gia = Convert.ToInt32(tb_Gia.Text);
            int soLuong = Convert.ToInt32(tb_SL.Text);
            string mota = tb_MoTa.Text;
            string loaiSP = tb_LoaiSP.Text;
            string danhGia = tb_DanhGia.Text;
            string thuongHieu = tb_ThuongHieu.Text;
            bool trangthai = cbb_TrangThai.SelectedIndex == 0;
            string img = ptb_AddImg.ImageLocation;
            SanPham sp = new SanPham() { TenSp = ten, Gia = gia, Sl = soLuong, MoTa = mota, LoaiSp = loaiSP, DanhGia = danhGia, ThuongHieu = thuongHieu, SldaBan = 0, TrangThai = trangthai, HinhAnh = img };
            MessageBox.Show(_ser.CreateSanPham(sp));
            Loaddata();
            ClearForm();
        }
        public void Loaddata()
        {
            dtg_QuanLySanPham.Rows.Clear();
            var allDatas = _ser.GetAllSanPham();
            dtg_QuanLySanPham.ColumnCount = 12;
            dtg_QuanLySanPham.Columns[0].HeaderText = "ID";
            dtg_QuanLySanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dtg_QuanLySanPham.Columns[2].HeaderText = "Giá";
            dtg_QuanLySanPham.Columns[3].HeaderText = "Số lượng";
            dtg_QuanLySanPham.Columns[4].HeaderText = "Mô tả";
            dtg_QuanLySanPham.Columns[5].HeaderText = "Loại sản phẩm";
            dtg_QuanLySanPham.Columns[6].HeaderText = "Đánh giá";
            dtg_QuanLySanPham.Columns[7].HeaderText = "Thương hiệu";
            dtg_QuanLySanPham.Columns[8].HeaderText = "Số lượng đã bán";
            dtg_QuanLySanPham.Columns[9].HeaderText = "Ngày nhập";
            dtg_QuanLySanPham.Columns[10].HeaderText = "Trạng thái";
            dtg_QuanLySanPham.Columns[11].HeaderText = "Hình ảnh";
            foreach (var data in allDatas)
            {
                dtg_QuanLySanPham.Rows.Add(data.Idsp, data.TenSp, data.Gia, data.Sl, data.MoTa, data.LoaiSp, data.DanhGia, data.ThuongHieu, data.SldaBan, data.NgayNhap, data.TrangThai, data.HinhAnh);
            }
            cbb_TrangThai.Items.Add("Active");
            cbb_TrangThai.Items.Add("InActive");
            cbb_TrangThai.SelectedIndex = 0;
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void ptb_AddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            string img = dialog.FileName;
            ptb_AddImg.Image = Image.FromFile(img);
            ptb_AddImg.ImageLocation = img;
        }

        private void dtg_QuanLySanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_QuanLySanPham.Rows[e.RowIndex];
            selectedID = Convert.ToInt32(row.Cells[0].Value.ToString());
            tb_TenSP.Text = row.Cells[1].Value.ToString();
            tb_Gia.Text = row.Cells[2].Value.ToString();
            tb_SL.Text = row.Cells[3].Value.ToString();
            tb_MoTa.Text = row.Cells[4].Value.ToString();
            tb_LoaiSP.Text = row.Cells[5].Value.ToString();
            tb_DanhGia.Text = row.Cells[6].Value.ToString();
            tb_ThuongHieu.Text = row.Cells[7].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells[10].Value);
            cbb_TrangThai.SelectedIndex = trangThai ? 0 : 1;
            ptb_AddImg.Image = Image.FromFile(row.Cells[11].Value.ToString());
            ptb_AddImg.ImageLocation = row.Cells[11].Value.ToString();

        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Hãy chọn sản phẩm bạn muốn sửa ");
            }
            else
            {
                string ten = tb_TenSP.Text;
                int gia = Convert.ToInt32(tb_Gia.Text);
                int soLuong = Convert.ToInt32(tb_SL.Text);
                string mota = tb_MoTa.Text;
                string loaiSP = tb_LoaiSP.Text;
                string danhGia = tb_DanhGia.Text;
                string thuongHieu = tb_ThuongHieu.Text;
                bool trangthai = cbb_TrangThai.SelectedIndex == 0;
                string img = ptb_AddImg.ImageLocation;
                SanPham sp = new SanPham() { TenSp = ten, Gia = gia, Sl = soLuong, MoTa = mota, LoaiSp = loaiSP, DanhGia = danhGia, ThuongHieu = thuongHieu, SldaBan = 0, TrangThai = trangthai, HinhAnh = img };
                MessageBox.Show(_ser.UpdateSanPham(sp, selectedID));
                Loaddata();
                selectedID = -1;
                ClearForm();
            }
        }

        public void ClearForm()
        {
            tb_TenSP.Text = string.Empty;
            tb_Gia.Text = string.Empty;
            tb_SL.Text = string.Empty;
            tb_MoTa.Text = string.Empty;
            tb_DanhGia.Text = string.Empty;
            tb_ThuongHieu.Text = string.Empty;
            cbb_TrangThai.SelectedIndex = 0;
            ptb_AddImg.ImageLocation = @"E:\DuAn1\Icon\icon_addimg.png";
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
