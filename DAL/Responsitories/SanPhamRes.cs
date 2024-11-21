using QuanLyBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL.Responsitories
{
    public class SanPhamRes
    {
        QuanLyBanHangContext context;

        public SanPhamRes()
        {
            context = new QuanLyBanHangContext();
        }

        public List<SanPham> GetAll()
        {
            return context.SanPhams.ToList();
        }

        public bool Create(SanPham sanpham)
        {
            try
            {
                context.SanPhams.Add(sanpham);
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
                var deleteSanPham = context.SanPhams.Find(id);
                context.SanPhams.Remove(deleteSanPham);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(SanPham sanpham, int id) 
        {
            try
            {
                var updateSanPham = context.SanPhams.Find(id);
                updateSanPham.TenSp = sanpham.TenSp;
                updateSanPham.Gia = sanpham.Gia;
                updateSanPham.Sl = sanpham.Sl;
                updateSanPham.MoTa = sanpham.MoTa;
                updateSanPham.LoaiSp = sanpham.LoaiSp;
                updateSanPham.DanhGia = sanpham.DanhGia;
                updateSanPham.ThuongHieu = sanpham.ThuongHieu;
                updateSanPham.TrangThai = sanpham.TrangThai;
                context.SanPhams.Update(updateSanPham);
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
