using System;
using System.Collections.Generic;

namespace QuanLyBanHang.DAL.Models
{
    public partial class HoaDonChiTiet
    {
        public int Id { get; set; }
        public string? TenSp { get; set; }
        public int? SoLuong { get; set; }
        public double? Gia { get; set; }
        public string? DanhGia { get; set; }
        public int Idhd { get; set; }
        public int Idsp { get; set; }
        public bool TrangThai { get; set; }

        public virtual HoaDon IdhdNavigation { get; set; } = null!;
        public virtual SanPham IdspNavigation { get; set; } = null!;
    }
}
