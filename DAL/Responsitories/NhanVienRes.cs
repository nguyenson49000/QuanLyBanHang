using QuanLyBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL.Responsitories
{
    public class NhanVienRes
    {
        QuanLyBanHangContext context;

        public NhanVienRes()
        {
            context = new QuanLyBanHangContext();
        }

        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }

        public bool Create(NhanVien nhanVien)
        {
            try
            {
                context.NhanViens.Add(nhanVien);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(NhanVien nhanVien, int id)
        {
            try
            {
                var updateNhanVien = context.NhanViens.Find(id);
                updateNhanVien.TenNv = nhanVien.TenNv;
                updateNhanVien.Mail = nhanVien.Mail;
                updateNhanVien.Sdt = nhanVien.Sdt;
                updateNhanVien.ChucVu = nhanVien.ChucVu;
                context.NhanViens.Update(updateNhanVien);
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
                var deleteNhanVien = context.NhanViens.Find(id);
                
                context.NhanViens.Remove(deleteNhanVien);
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
