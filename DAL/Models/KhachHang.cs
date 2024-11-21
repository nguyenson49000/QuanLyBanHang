using System;
using System.Collections.Generic;

namespace QuanLyBanHang.DAL.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Idkh { get; set; }
        public string? TenKh { get; set; }
        public string? Sdt { get; set; }
        public int SoLanMua { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
