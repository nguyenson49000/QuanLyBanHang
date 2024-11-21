using Microsoft.EntityFrameworkCore.Metadata;
using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL.Models;
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
    public partial class KhachHangForm : Form
    {
        int selectedID;
        KhachHangSer KH = new KhachHangSer();
        public KhachHangForm()
        {
            InitializeComponent();
        }

        public void LoadKH()
        {
            dtg_DanhSachKH.Rows.Clear();
            var allDatas = KH.GetAllKhachHang();
            dtg_DanhSachKH.ColumnCount = 4;
            dtg_DanhSachKH.Columns[0].HeaderText = "ID Khách Hàng";
            dtg_DanhSachKH.Columns[1].HeaderText = "Tên Khách Hàng";
            dtg_DanhSachKH.Columns[2].HeaderText = "Số Điện Thoại";
            dtg_DanhSachKH.Columns[3].HeaderText = "Số Lần Mua";
            foreach (var data in allDatas)
            {
                dtg_DanhSachKH.Rows.Add(data.Idkh, data.TenKh, data.Sdt, data.SoLanMua);
            }
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void dtg_DanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_DanhSachKH.Rows[e.RowIndex];
            selectedID = Convert.ToInt32(row.Cells[0].Value.ToString());
            tb_IDKH.Text = row.Cells[0].Value.ToString();
            tb_NameKH.Text = row.Cells[1].Value.ToString();
            tb_SDT.Text = row.Cells[2].Value.ToString();
            tb_SLM.Text = row.Cells[3].Value.ToString();
        }

        private void bt_FixKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang()
            {
                Idkh = selectedID,
                TenKh = tb_NameKH.Text,
                Sdt = tb_SDT.Text,
                SoLanMua = Convert.ToInt32(tb_SLM.Text)
            };
            KH.UpdateKhachHang(kh, selectedID);
            LoadKH();

        }
    }
}
