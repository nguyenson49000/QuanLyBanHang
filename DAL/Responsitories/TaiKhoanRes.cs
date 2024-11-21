using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL.Responsitories
{
    public class TaiKhoanRes
    {
        QuanLyBanHangContext context;
        


        public TaiKhoanRes()
        {
            
            context = new QuanLyBanHangContext();
        }

        public string CheckLogin(string username, string pass)
        {
            try
            {
                var check = context.TaiKhoans.SingleOrDefault(p => p.TenTk == username && p.MatKhau == pass);
                if (check != null)
                {
                    return check.Idtk.ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception)
            {
                return "1";
            }
        }

        public bool CreateTK(string user, string pass)
        {
            TaiKhoan tk = context.TaiKhoans.SingleOrDefault(tk => tk.TenTk == user);
            if(tk != null)
            {
                return false;
            }
            else
            {
                TaiKhoan taikhoan = new TaiKhoan()
                {
                    TenTk = user,
                    MatKhau = pass
                };
                context.TaiKhoans.Add(taikhoan);
                context.SaveChanges();
                return true;
            }
            
        }
        public List<TaiKhoan> SearchTK(string user)
        {
            return context.TaiKhoans.Where(u => u.TenTk == user).ToList();
        }
        public bool Delete(int id)
        {
            try
            {
                var deleteTaiKhoan = context.TaiKhoans.Find(id);
                context.TaiKhoans.Remove(deleteTaiKhoan);
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
