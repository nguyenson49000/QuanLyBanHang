using QuanLyBanHang.DAL.Models;
using QuanLyBanHang.DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class HDCTSer
    {
        HDCTRes _repos;

        public HDCTSer()
        {
            _repos = new HDCTRes();
        }

        public List<HoaDonChiTiet> ShowHDCT(int id)
        {
            return _repos.ShowHDCT(id);
        }

        public string CreateHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            if (_repos.Create(hoaDonChiTiet))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";

        }

        public string DeleteHDCT(int id)
        {
            if (_repos.Delete(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }

        public string UpdateHDCT(HoaDonChiTiet hoaDonChiTiet, int id)
        {
            if (_repos.Update(hoaDonChiTiet, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
