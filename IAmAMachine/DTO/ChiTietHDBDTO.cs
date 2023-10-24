using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class ChiTietHDBDTO
    {
        public ChiTietHDBDTO()
        {
        }

        public ChiTietHDBDTO(int maHDB, int maThuoc, int soLuong, decimal giamGia, decimal thanhTien)
        {
            MaHDB = maHDB;
            MaThuoc = maThuoc;
            SoLuong = soLuong;
            GiamGia = giamGia;
            ThanhTien = thanhTien;
        }

        public int MaHDB { get; set; }
        public int MaThuoc { get; set; }
        public int SoLuong { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
