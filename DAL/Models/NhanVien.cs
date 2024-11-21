using System;
using System.Collections.Generic;

namespace QuanLyBanHang.DAL.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Idnv { get; set; }
        public string? TenNv { get; set; }
        public string? Mail { get; set; }
        public string? Sdt { get; set; }
        public string ChucVu { get; set; } = null!;
        public int Idtk { get; set; }

        public virtual TaiKhoan IdtkNavigation { get; set; } = null!;
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
