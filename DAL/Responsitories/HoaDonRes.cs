using QuanLyBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL.Responsitories
{
    public class HoaDonRes
    {
        QuanLyBanHangContext context;

        public HoaDonRes()
        {
            context = new QuanLyBanHangContext();
        }

        public List<HoaDon> GetAll()
        {
            return context.HoaDons.ToList();
        }

        public bool Create(HoaDon HoaDon)
        {
            try
            {
                context.HoaDons.Add(HoaDon);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(HoaDon hoadon, int id)
        {
            try
            {
                var updateHoaDon = context.HoaDons.Find(id);
                updateHoaDon.Idhd = hoadon.Idhd;
                updateHoaDon.Idnv = hoadon.Idnv;
                updateHoaDon.SoTien = hoadon.SoTien;
                updateHoaDon.NgayTao = hoadon.NgayTao;
                updateHoaDon.Idkh = hoadon.Idkh;
                updateHoaDon.Idkm = hoadon.Idkm;
                updateHoaDon.IdthanhToan = hoadon.IdthanhToan;
                updateHoaDon.TrangThai = hoadon.TrangThai;
                context.HoaDons.Update(updateHoaDon);
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
                var deleteHoaDon = context.HoaDons.Find(id);
                context.HoaDons.Remove(deleteHoaDon);
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
