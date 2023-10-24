using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class HoaDonNhapDTO
    {
        public HoaDonNhapDTO()
        {
        }

        public HoaDonNhapDTO(int maHDN, DateTime ngayNhap, int maNCC, decimal tongTien)
        {
            MaHDN = maHDN;
            NgayNhap = ngayNhap;
            MaNCC = maNCC;
            TongTien = tongTien;
        }

        public int MaHDN { get; set; }
        public DateTime NgayNhap { get; set; }
        public int MaNCC { get; set; }
        public decimal TongTien { get; set; }
    }

}
