using System;
using System.Collections.Generic;

namespace QuanLyBanHang.DAL.Models
{
    public partial class ThanhToan
    {
        public ThanhToan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int IdThanhToan { get; set; }
        public string? HinhThuc { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
