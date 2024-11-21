using QuanLyBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL.Responsitories
{
    public class HDCTRes
    {
        QuanLyBanHangContext context;

        public HDCTRes()
        {
            context = new QuanLyBanHangContext();
        }

        public List<HoaDonChiTiet> ShowHDCT(int id)
        {
            List<HoaDonChiTiet> hoaDonChiTietList = context.HoaDonChiTiets.Where(hdct => hdct.Idhd == id).ToList();
            return hoaDonChiTietList;
        }

        public bool Create(HoaDonChiTiet hoaDonChiTiet)
        {
            try
            {
                context.HoaDonChiTiets.Add(hoaDonChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(HoaDonChiTiet hoaDonChiTiet, int id)
        {
            try
            {
                var updateHoaDon = context.HoaDonChiTiets.Find(id);
                updateHoaDon = hoaDonChiTiet;
                context.HoaDonChiTiets.Update(hoaDonChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var deleteHoaDon = context.HoaDonChiTiets.Find(id);
                context.HoaDonChiTiets.Remove(deleteHoaDon);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
