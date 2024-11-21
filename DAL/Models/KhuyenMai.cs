using System;
using System.Collections.Generic;

namespace QuanLyBanHang.DAL.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int IdkhuyenMai { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public double? TyLeKhuyenMai { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
