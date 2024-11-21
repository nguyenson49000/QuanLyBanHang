using QuanLyBanHang.DAL.Models;
using QuanLyBanHang.DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class TaiKhoanSer
    {
        TaiKhoanRes _repos;
        
        public TaiKhoanSer()
        {
             
            _repos = new TaiKhoanRes();
        }

        public string Login(string username, string pass)
        {
           return _repos.CheckLogin(username, pass);
        }

        public string Create(string user, string pass)
        {
            if (_repos.CreateTK(user,pass))
            {
                return "Tạo tài khoản và thêm nhân viên mới thành công";
            }
            else return "Tên tài khoản đã được nhân viên khác sử dụng";
        }

        public List<TaiKhoan> SearchTK(string user)
        {
            return _repos.SearchTK(user);
        }
        public string DeleteTaiKhoan(int id)
        {
            if (_repos.Delete(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
    }
}
