using System;
using System.Collections.Generic;

namespace QuanLyBanHang.DAL.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public int Idtk { get; set; }
        public string? TenTk { get; set; }
        public string? MatKhau { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
