using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class DanhMucThuocDTO
    {
        public DanhMucThuocDTO()
        {
        }

        public DanhMucThuocDTO(int maThuoc, string tenThuoc, string donViDongGoi, string thanhPhan, decimal giaNhap, decimal giaBan, int maDangDC, int sLHienCo, int maHangSX, string congDung, string hanSD)
        {
            MaThuoc = maThuoc;
            TenThuoc = tenThuoc;
            DonViDongGoi = donViDongGoi;
            ThanhPhan = thanhPhan;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            MaDangDC = maDangDC;
            SLHienCo = sLHienCo;
            MaHangSX = maHangSX;
            CongDung = congDung;
            HanSD = hanSD;
        }

        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DonViDongGoi { get; set; }
        public string ThanhPhan { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int MaDangDC { get; set; }
        public int SLHienCo { get; set; }
        public int MaHangSX { get; set; }
        public string CongDung { get; set; }
        public string HanSD { get; set; }
    }

}
