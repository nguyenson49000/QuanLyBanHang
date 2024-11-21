using QuanLyBanHang.DAL.Models;
using QuanLyBanHang.DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class KhachHangSer
    {
        KhachHangRes _res;
        public KhachHangSer()
        {
            _res = new KhachHangRes();
        }
        public List<KhachHang> GetAllKhachHang()
        {
            return _res.GetAll();
        }
        public List<KhachHang> TimKH(string SDT)
        {
            return _res.SearchKH(SDT);
        }

        public string CreateKhachHang(string SDT, string tenKH)
        {
            if (_res.Create(SDT,tenKH))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";

        }

        public string DeleteKhachHang(int id)
        {
            if (_res.Delete(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }

        public string UpdateKhachHang(KhachHang khachHang, int id)
        {
            if (_res.Update(khachHang, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
