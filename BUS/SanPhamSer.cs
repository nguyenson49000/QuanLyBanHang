using QuanLyBanHang.DAL.Models;
using QuanLyBanHang.DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class SanPhamSer
    {
        SanPhamRes _repos;

        public SanPhamSer()
        {
            _repos = new SanPhamRes();
        }

        public List<SanPham> GetAllSanPham()
        {
            return _repos.GetAll();
        }

        public string CreateSanPham(SanPham sanPham)
        {
            if (_repos.Create(sanPham))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";

        }

        public string DeleteSanPham(int id)
        {
            if (_repos.Delete(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }

        public string UpdateSanPham(SanPham sanPham, int id)
        {
            if (_repos.Update(sanPham, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        } 
    }
}
