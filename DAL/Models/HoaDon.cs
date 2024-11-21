using System;
using System.Collections.Generic;

namespace QuanLyBanHang.DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int Idhd { get; set; }
        public int Idnv { get; set; }
        public double? SoTien { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? Idkh { get; set; }
        public int? Idkm { get; set; }
        public int IdthanhToan { get; set; }
        public bool TrangThai { get; set; }

        public virtual KhachHang? IdkhNavigation { get; set; }
        public virtual KhuyenMai? IdkmNavigation { get; set; }
        public virtual NhanVien IdnvNavigation { get; set; } = null!;
        public virtual ThanhToan IdthanhToanNavigation { get; set; } = null!;
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
