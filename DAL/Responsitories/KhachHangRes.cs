using QuanLyBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL.Responsitories
{
    public class KhachHangRes
    {
        QuanLyBanHangContext context;
        public KhachHangRes()
        {
            context = new QuanLyBanHangContext();
        }

        public List<KhachHang> GetAll()
        {
            return context.KhachHangs.ToList();
        }

        public List<KhachHang> SearchKH(string SDT)
        {
            return context.KhachHangs.Where(u => u.Sdt == SDT).ToList();
        }
        public bool Create(string sdt,string tenKH)
        {
            KhachHang khachHang = context.KhachHangs.SingleOrDefault(kh => kh.Sdt == sdt);

            if (khachHang != null)
            {
                // Khách hàng đã tồn tại, tăng số lần mua lên 1
                khachHang.SoLanMua += 1;
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                return true; // Trả về true nếu khách hàng đã tồn tại và được cập nhật
            }
            else
            {
                KhachHang khachHangMoi = new KhachHang()
                {
                    TenKh = tenKH,
                    Sdt = sdt,
                    SoLanMua = 1 // Khởi tạo số lần mua là 1
                };
                context.KhachHangs.Add(khachHangMoi);
                context.SaveChanges();
                return false;
            }
        }

        public bool Update(KhachHang khachHang, int id)
        {
            try
            {
                var updateKhachHang = context.KhachHangs.Find(id);
                updateKhachHang.TenKh = khachHang.TenKh;
                updateKhachHang.Sdt = khachHang.Sdt;
                updateKhachHang.SoLanMua = khachHang.SoLanMua;
                context.KhachHangs.Update(updateKhachHang);
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
                var deleteKhachHang = context.KhachHangs.Find(id);
                context.KhachHangs.Remove(deleteKhachHang);
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
