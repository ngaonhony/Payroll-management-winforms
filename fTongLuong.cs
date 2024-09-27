using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QLTL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTL
{
    public partial class fTongLuong : Form
    {
        private int selectedMonth;
        private int selectedYear;

        public fTongLuong(int month, int year)
        {
            InitializeComponent();
            selectedMonth = month;
            selectedYear = year;
            LoadData();
        }

        private void fTongluong_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void fTongluong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new EFDbContext())
            {
                var chamcongs = db.CHAMCONG.Include(cc => cc.NHANVIEN).ToList();

                foreach (var chamcong11 in chamcongs)
                {
                    if (chamcong11.NHANVIEN == null)
                    {
                        // Xử lý trường hợp NHANVIEN là null, bỏ qua hoặc ghi nhật ký lỗi
                        continue;
                    }
                    chamcong11.THANHTIEN = CalculateTotalSalary(chamcong11.MANV, chamcong11.NGAYCONG, chamcong11.NGHIHL, selectedMonth, selectedYear);
                    db.SaveChanges();
                }
                

                var chamcong = db.CHAMCONG
                                 .Where(c => c.THANG == selectedMonth && c.NAM == selectedYear).GroupBy(c => new { c.MANV, c.THANG, c.NAM }).Select(g => new
                                 {
                                     MANV = g.Key.MANV,
                                     NAME = g.FirstOrDefault().NHANVIEN.NAME,
                                     THANGNAM = string.Format("{0} / {1}", g.Key.THANG, g.Key.NAM),
                                     TONGLUONG = String.Format("{0:n0}", Math.Round(CalculateTotalSalary(g.Key.MANV, g.Sum(c => c.NGAYCONG), g.Sum(c => c.NGHIHL), selectedMonth, selectedYear))) + " VND"
                                 })
                                .ToList();

                dataGridView1.DataSource = chamcong;
            }
        }

        private static decimal CalculateTotalSalary(long manv, int ngaycong, int nghi, int selectedMonth, int selectedYear)
        {
            using (var db = new EFDbContext())
            {
                var ngayApDungChamCong = new DateTime(selectedYear, selectedMonth, 2);
                var nv = db.NHANVIEN.Where(n => n.MANV == manv).FirstOrDefault();
                var luong = db.NHANVIEN.Where(nv => nv.MANV == manv).Select(nv => nv.CHUCVU.LUONG).FirstOrDefault();
                var ngayTuyenDung = db.NHANVIEN.Where(nv => nv.MANV == manv).Select(nv => nv.NGAYVAOLAM).FirstOrDefault();
                var thangNamTuyenDung = new DateTime(ngayTuyenDung.Year, ngayTuyenDung.Month, 1); // Lấy tháng năm tuyển dụng
                int soThangChenhLech = (selectedYear * 12 + selectedMonth) - (thangNamTuyenDung.Year * 12 + thangNamTuyenDung.Month);
                int soNamChenhLech = (int)Math.Floor((decimal)soThangChenhLech / 12); 
                var ktkl = db.KHENTHUONGKYLUAT.Where(k => k.MANV == manv
            && k.NGAYAPDUNG.Year == selectedYear
            && k.NGAYAPDUNG.Month == selectedMonth).FirstOrDefault();
                
                var phat = ktkl?.THUONGPHAT == "Phạt" ? ktkl.SOTIEN : 0;
                var thuong = ktkl?.THUONGPHAT == "Thưởng" ? ktkl.SOTIEN : 0;
                  
                var tongluong = luong * (1 + soNamChenhLech * 10 / 100) * (ngaycong / (decimal)(ngaycong + nghi)) + thuong - phat;
                return tongluong;
            }
        }

       
    }
}
