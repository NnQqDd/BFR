using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class HoaDonBanDTO
    {
        public HoaDonBanDTO()
        {
        }

        public HoaDonBanDTO(int maHDB, DateTime ngayBan, int maNV, int maKhach, decimal tongTien)
        {
            MaHDB = maHDB;
            NgayBan = ngayBan;
            MaNV = maNV;
            MaKhach = maKhach;
            TongTien = tongTien;
        }

        public int MaHDB { get; set; }
        public DateTime NgayBan { get; set; }
        public int MaNV { get; set; }
        public int MaKhach { get; set; }
        public decimal TongTien { get; set; }
    }
}
