using QuanLyBanHang.DAL.Models;
using QuanLyBanHang.DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class NhanVienSer
    {
        NhanVienRes _repos;

        public NhanVienSer()
        {
            _repos = new NhanVienRes();
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return _repos.GetAll();
        }

        public string CreateNhanVien(NhanVien nhanVien)
        {
            if (_repos.Create(nhanVien))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";

        }

        public string DeleteNhanVien(int id)
        {
            if (_repos.Delete(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }

        public string UpdateNhanVien(NhanVien nhanVien, int id)
        {
            if (_repos.Update(nhanVien, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
