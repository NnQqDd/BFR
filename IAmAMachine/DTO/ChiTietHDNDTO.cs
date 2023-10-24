using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{

    public class ChiTietHDNDTO
    {
        public ChiTietHDNDTO()
        {
        }

        public ChiTietHDNDTO(int maHDN, int maThuoc, int sLNhap, decimal donGia, decimal khuyenMai, decimal thanhTien)
        {
            MaHDN = maHDN;
            MaThuoc = maThuoc;
            SLNhap = sLNhap;
            DonGia = donGia;
            KhuyenMai = khuyenMai;
            ThanhTien = thanhTien;
        }

        public int MaHDN { get; set; }
        public int MaThuoc { get; set; }
        public int SLNhap { get; set; }
        public decimal DonGia { get; set; }
        public decimal KhuyenMai { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
