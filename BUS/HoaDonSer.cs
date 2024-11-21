using QuanLyBanHang.DAL.Models;
using QuanLyBanHang.DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class HoaDonSer
    {
        HoaDonRes _repos;

        public HoaDonSer()
        {
            _repos = new HoaDonRes();
        }

        public List<HoaDon> GetAllHoaDon() 
        {
            return _repos.GetAll();
        } 

        public string CreateHoaDon(int id)
        {
            HoaDon hd = new HoaDon()
            {
                Idnv = id,
                SoTien = 0,
                IdthanhToan = 1,
                TrangThai = false
            };
            if (_repos.Create(hd))
            {
                return "Thêm hóa đơn thành công";
            }
            else return "Thêm hóa đơn thất bại";

        }

        public string DeleteHoaDon(int id)
        {
            if (_repos.Delete(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }

        public string UpdateHoaDon(HoaDon hoaDon,int id)
        {
            if (_repos.Update(hoaDon, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
