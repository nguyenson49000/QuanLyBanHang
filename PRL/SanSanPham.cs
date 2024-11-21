using Microsoft.VisualBasic.ApplicationServices;
using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL.Models;
using QuanLyBanHang.DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.PRL
{
    public partial class SanSanPham : Form
    {
        int ids = 0;
        int selectedID = -1;
        int TongTien;
        DateTime NgayTao;

        KhachHangSer khachHangSer = new KhachHangSer();
        HoaDonSer hoaDonSer = new HoaDonSer();
        HDCTSer hDCT = new HDCTSer();
        SanPhamSer sanPhamSer = new SanPhamSer();
        List<SanPham> sanPhams = new List<SanPham>();

        public SanSanPham(int id)
        {
            sanPhams = sanPhamSer.GetAllSanPham();
            ids = id;
            InitializeComponent();
            LoadHoaDon();
        }
        public void LoadSPToPanel(int page)
        {
            tlp_HienThiSanPham.Controls.Clear();
            var availableProducts = sanPhams.Where(sp => sp.TrangThai).ToList();
            int numberpage = (int)Math.Ceiling((decimal)availableProducts.Count / 4);
            if (page < 1 || page > numberpage) return;
            else
            {
                if (page * 4 - 4 < availableProducts.Count)
                {
                    Panel s1 = CreatePanelSP(availableProducts[page * 4 - 4]);
                    tlp_HienThiSanPham.Controls.Add(s1, 0, 0);
                }

                if (page * 4 - 3 < availableProducts.Count)
                {
                    Panel s2 = CreatePanelSP(availableProducts[page * 4 - 3]);
                    tlp_HienThiSanPham.Controls.Add(s2, 0, 1);
                }
                if (page * 4 - 2 < availableProducts.Count)
                {
                    Panel s3 = CreatePanelSP(availableProducts[page * 4 - 2]);
                    tlp_HienThiSanPham.Controls.Add(s3, 1, 0);
                }
                if (page * 4 - 1 < availableProducts.Count)
                {
                    Panel s4 = CreatePanelSP(availableProducts[page * 4 - 1]);
                    tlp_HienThiSanPham.Controls.Add(s4, 1, 1);
                }
            }

        }

        private void bt_HienThiSanPham_Click(object sender, EventArgs e)
        {

            tlp_HienThiSanPham.ColumnCount = 2;
            tlp_HienThiSanPham.RowCount = 2;
            LoadSPToPanel(1);
        }
        public Panel CreatePanelSP(SanPham sp)
        {

            Panel p = new Panel();
            p.Size = new Size(457, 480);
            p.BackColor = Color.LightGray;
            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(238, 247);
            ptb.Image = Image.FromFile(sp.HinhAnh);
            ptb.Location = new Point(12, 12);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb.Name = "Image";
            p.Name = sp.Idsp.ToString();
            Label lbName = new Label(); lbName.Text = "Tên sản phẩm:"; lbName.Location = new Point(278, 2); lbName.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Label lbNameValue = new Label(); lbNameValue.Text = sp.TenSp; lbNameValue.Location = new Point(278, 22);
            lbNameValue.Name = "TenSP";
            Label lbGia = new Label(); lbGia.Text = "Giá:"; lbGia.Location = new Point(278, 45); lbGia.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Label lbGiaValue = new Label(); lbGiaValue.Text = sp.Gia + ""; lbGiaValue.Location = new Point(278, 65);
            lbGiaValue.Name = "GiaSP";
            Label lbSoLuong = new Label(); lbSoLuong.Text = "Số lượng:"; lbSoLuong.Location = new Point(278, 88); lbSoLuong.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Label lbSoLuongValue = new Label(); lbSoLuongValue.Text = sp.Sl + ""; lbSoLuongValue.Location = new Point(278, 108);
            lbSoLuongValue.Name = "SoLuong";
            Label lbMoTa = new Label(); lbMoTa.Text = "Mô tả:"; lbMoTa.Location = new Point(278, 130); lbMoTa.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Label lbMoTaValue = new Label(); lbMoTaValue.Text = sp.MoTa; lbMoTaValue.Location = new Point(278, 150);
            lbMoTaValue.Name = "MoTa";
            Label lbLoaiSanPham = new Label(); lbLoaiSanPham.Text = "Loại sản phẩm:"; lbLoaiSanPham.Location = new Point(278, 178); lbLoaiSanPham.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Label lbLoaiSanPhamValue = new Label(); lbLoaiSanPhamValue.Text = sp.LoaiSp; lbLoaiSanPhamValue.Location = new Point(278, 198);
            lbLoaiSanPhamValue.Name = "LoaiSP";
            Label lbThuongHieu = new Label(); lbThuongHieu.Text = "Thương hiệu:"; lbThuongHieu.Location = new Point(278, 220); lbThuongHieu.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Label lbThuongHieuValue = new Label(); lbThuongHieuValue.Text = sp.ThuongHieu; lbThuongHieuValue.Location = new Point(278, 240);
            lbThuongHieuValue.Name = "ThuongHieu";
            Label lbSoLuongMua = new Label(); lbSoLuongMua.Text = "Số lượng mua:"; lbSoLuongMua.Location = new Point(278, 263); lbSoLuongMua.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Button btnMua = new Button(); btnMua.Text = "Mua"; btnMua.Size = new Size(75, 27); btnMua.Location = new Point(278, 320);
            btnMua.MouseClick += btnMua_MouseClick; btnMua.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnMua.BackColor = Color.White;
            TextBox tb_SoLuong = new TextBox(); tb_SoLuong.PlaceholderText = "Nhập số lượng"; tb_SoLuong.Size = new Size(109, 32);
            tb_SoLuong.Location = new Point(278, 290); tb_SoLuong.Name = "tb_SoLuong";
            p.Controls.Add(lbName); p.Controls.Add(lbNameValue); p.Controls.Add(lbGia); p.Controls.Add(lbGiaValue);
            p.Controls.Add(lbSoLuong); p.Controls.Add(lbSoLuongValue); p.Controls.Add(lbMoTa); p.Controls.Add(lbMoTaValue); p.Controls.Add(lbLoaiSanPham);
            p.Controls.Add(lbLoaiSanPhamValue); p.Controls.Add(lbThuongHieu); p.Controls.Add(lbThuongHieuValue); p.Controls.Add(lbSoLuongMua); p.Controls.Add(ptb);
            p.Controls.Add(btnMua); p.Controls.Add(tb_SoLuong);
            return p;
        }

        private void lb_Next_Click(object sender, EventArgs e)
        {
            var availableProducts = sanPhams.Where(sp => sp.TrangThai).ToList();
            if (Convert.ToInt32(lb_page.Text) < (int)Math.Ceiling((decimal)availableProducts.Count / 4))
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) + 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }

        }

        private void lb_Back_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) > 1)
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) - 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }

        }

        private void btnMua_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            Panel p = (Panel)b.Parent;
            TextBox t = p.Controls["tb_SoLuong"] as TextBox;
            int soLuongMua = Convert.ToInt32(t.Text);
            Label soLuong = p.Controls["SoLuong"] as Label;
            int soLuongCon = Convert.ToInt32(soLuong.Text);
            Label TenSP = p.Controls["TenSP"] as Label;
            string NameSP = TenSP.Text.ToString();
            Label gia = p.Controls["GiaSP"] as Label;
            int GiaSP = Convert.ToInt32(gia.Text);
            Label moTa = p.Controls["MoTa"] as Label;
            string MoTa = moTa.Text.ToString();
            Label loaiSP = p.Controls["LoaiSP"] as Label;
            string LoaiSP = loaiSP.Text.ToString();
            Label thuongHieu = p.Controls["ThuongHieu"] as Label;
            string ThuongHieu = thuongHieu.Text.ToString();
            PictureBox img = p.Controls["Image"] as PictureBox;
            string HinhAnh = img.ImageLocation;
            if (soLuongMua > soLuongCon) { MessageBox.Show($"Không thể mua {soLuongMua} sản phẩm vì {p.Name} chỉ còn {soLuongCon} sản phẩm", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {

                if (selectedID == -1)
                {
                    MessageBox.Show("Hãy chọn hóa đơn bạn muốn thêm");
                }
                else
                {
                    MessageBox.Show($"Bạn vừa chọn mua sản phẩm: {NameSP}. Với số lượng là: {soLuongMua}. Vào hóa đơn {selectedID}", "ĐÃ THÊM SẢN PHẨM VÀO HÓA ĐƠN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet()
                    {
                        Idhd = selectedID,
                        TenSp = NameSP,
                        SoLuong = soLuongMua,
                        Gia = GiaSP,
                        Idsp = Convert.ToInt32(p.Name),
                        TrangThai = true
                    };
                    hDCT.CreateHDCT(hoaDonChiTiet);
                    LoadHDCT();
                    TongTien += GiaSP * soLuongMua;
                    HoaDon hoaDon = new HoaDon()
                    {
                        Idhd = selectedID,
                        Idnv = ids,
                        SoTien = TongTien,
                        IdthanhToan = 1,
                        NgayTao = NgayTao,
                        TrangThai = false
                    };
                    hoaDonSer.UpdateHoaDon(hoaDon, selectedID);
                    bool checktrangThai;
                    if (soLuongCon - soLuongMua == 0)
                    {
                        checktrangThai = false;
                    }
                    else
                    {
                        checktrangThai = true;
                    }
                    SanPham sp = new SanPham()
                    {
                        Idsp = Convert.ToInt32(p.Name),
                        TenSp = NameSP,
                        Gia = GiaSP,
                        Sl = soLuongCon - soLuongMua,
                        MoTa = MoTa,
                        LoaiSp = LoaiSP,
                        DanhGia = "Very Good",
                        ThuongHieu = ThuongHieu,
                        SldaBan = soLuongMua,
                        TrangThai = checktrangThai,
                        HinhAnh = HinhAnh


                    };
                    sanPhamSer.UpdateSanPham(sp, Convert.ToInt32(p.Name));
                    LoadHoaDon();
                    LoadSPToPanel(1);
                }


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tlp_HienThiSanPham.Controls.Clear();
            QuanLySanPham QLSP = new QuanLySanPham();
            QLSP.TopLevel = false;
            tlp_HienThiSanPham.ColumnCount = 1;
            tlp_HienThiSanPham.RowCount = 1;
            QLSP.FormBorderStyle = FormBorderStyle.None;
            tlp_HienThiSanPham.Controls.Add(QLSP);
            QLSP.Show();
            lb_page.Text = 1 + "";
        }
        public void LoadHoaDon()
        {
            dtg_hoaDon.Rows.Clear();
            var allDatas = hoaDonSer.GetAllHoaDon();
            var filteredDatas = allDatas.Where(data => !data.TrangThai).ToList();
            dtg_hoaDon.ColumnCount = 4;
            dtg_hoaDon.Columns[0].HeaderText = "ID";
            dtg_hoaDon.Columns[1].HeaderText = "Tổng tiền";
            dtg_hoaDon.Columns[2].HeaderText = "ID nhan vien";
            dtg_hoaDon.Columns[3].HeaderText = "Ngày tạo";
            foreach (var data in filteredDatas)
            {
                dtg_hoaDon.Rows.Add(data.Idhd, data.SoTien, data.Idnv, data.NgayTao, data.IdthanhToan);
            }

        }

        private void bt_TaoHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonSer.CreateHoaDon(ids);
            LoadHoaDon();
        }

        public void LoadHDCT()
        {
            dtg_HDCT.Rows.Clear();
            var allDatas = hDCT.ShowHDCT(selectedID);
            dtg_HDCT.ColumnCount = 7;
            dtg_HDCT.Columns[0].HeaderText = "ID";
            dtg_HDCT.Columns[1].HeaderText = "Tên sản phẩm";
            dtg_HDCT.Columns[2].HeaderText = "Số lượng";
            dtg_HDCT.Columns[3].HeaderText = "Giá";
            dtg_HDCT.Columns[4].HeaderText = "ID hóa đơn";
            dtg_HDCT.Columns[5].HeaderText = "ID sản phẩm";
            dtg_HDCT.Columns[6].HeaderText = "Trạng thái";
            foreach (var data in allDatas)
            {
                dtg_HDCT.Rows.Add(data.Id, data.TenSp, data.SoLuong, data.Gia, data.Idhd, data.Idsp, data.TrangThai);
            }

        }

        private void dtg_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_hoaDon.Rows[e.RowIndex];
            selectedID = Convert.ToInt32(row.Cells[0].Value.ToString());
            TongTien = Convert.ToInt32(row.Cells[1].Value.ToString());
            DateTime.TryParse(row.Cells[3].Value.ToString(), out NgayTao);
            LoadHDCT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? idKh = null;
            if (!string.IsNullOrEmpty(tb_SDT.Text))
            {
                khachHangSer.CreateKhachHang(tb_SDT.Text, tb_TenKH.Text);
                List<KhachHang> SearchKH = khachHangSer.TimKH(tb_SDT.Text);
                idKh = SearchKH.First().Idkh;
            }



            int ThanhToan;
            if (rdb_TienMat.Checked)
            {
                ThanhToan = 1;
            }
            else if (rdb_ChuyenKhoan.Checked)
            {
                ThanhToan = 2;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            HoaDon hd = new HoaDon()
            {
                Idhd = selectedID,
                Idnv = ids,
                SoTien = TongTien,
                NgayTao = NgayTao,
                Idkh = idKh,
                IdthanhToan = ThanhToan,
                TrangThai = true
            };
            hoaDonSer.UpdateHoaDon(hd, selectedID);
            MessageBox.Show($"Thanh toán thành công hóa đơn: {selectedID}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtg_HDCT.Controls.Clear();
            LoadHoaDon();
            LoadHDCT();
        }

        private void dtg_hoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
