using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.PRL
{
    public partial class HoaDonForm : Form
    {
        int selectedID;
        HoaDonSer hoaDonSer = new HoaDonSer();
        HDCTSer hDCT = new HDCTSer();
        public HoaDonForm()
        {
            InitializeComponent();
        }

        public void LoadHoaDon()
        {
            dtg_HoaDon.Rows.Clear();
            var allDatas = hoaDonSer.GetAllHoaDon();
            dtg_HoaDon.ColumnCount = 8;
            dtg_HoaDon.Columns[0].HeaderText = "ID";
            dtg_HoaDon.Columns[1].HeaderText = "ID Nhân Viên";
            dtg_HoaDon.Columns[2].HeaderText = "ID Tổng Tiền";
            dtg_HoaDon.Columns[3].HeaderText = "Ngày Tạo";
            dtg_HoaDon.Columns[4].HeaderText = "ID Khách Hàng";
            dtg_HoaDon.Columns[5].HeaderText = "ID Khuyến Mãi";
            dtg_HoaDon.Columns[6].HeaderText = "ID Thanh Toán";
            dtg_HoaDon.Columns[7].HeaderText = "Trạng Thái";
            foreach (var data in allDatas)
            {
                dtg_HoaDon.Rows.Add(data.Idhd, data.Idnv,data.SoTien, data.NgayTao,data.Idkh,data.Idkm, data.IdthanhToan,data.TrangThai);
            }

        }

        public void LoadHDCT()
        {
            dtg_HDCT.Rows.Clear();
            var allDatas = hDCT.ShowHDCT(selectedID);
            dtg_HDCT.ColumnCount = 7;
            dtg_HDCT.Columns[0].HeaderText = "ID";
            dtg_HDCT.Columns[1].HeaderText = "Tên sản phẩm";
            dtg_HDCT.Columns[2].HeaderText = "Số lượng";
            dtg_HDCT.Columns[3].HeaderText = "Giá";
            dtg_HDCT.Columns[4].HeaderText = "ID hóa đơn";
            dtg_HDCT.Columns[5].HeaderText = "ID sản phẩm";
            dtg_HDCT.Columns[6].HeaderText = "Trạng thái";
            foreach (var data in allDatas)
            {
                dtg_HDCT.Rows.Add(data.Id, data.TenSp, data.SoLuong, data.Gia, data.Idhd, data.Idsp, data.TrangThai);
            }

        }

        private void dtg_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_HoaDon.Rows[e.RowIndex];
            selectedID = Convert.ToInt32(row.Cells[0].Value.ToString());
            LoadHDCT();
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
    }
}
