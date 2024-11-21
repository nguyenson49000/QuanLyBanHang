using System;
using System.Collections.Generic;

namespace QuanLyBanHang.DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int Idsp { get; set; }
        public string? TenSp { get; set; }
        public double Gia { get; set; }
        public int Sl { get; set; }
        public string? MoTa { get; set; }
        public string? LoaiSp { get; set; }
        public string? DanhGia { get; set; }
        public string? ThuongHieu { get; set; }
        public int? SldaBan { get; set; }
        public DateTime? NgayNhap { get; set; }
        public bool TrangThai { get; set; }
        public string? HinhAnh { get; set; }

        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
