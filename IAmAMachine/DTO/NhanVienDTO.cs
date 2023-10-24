using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO()
        {
        }

        public NhanVienDTO(int maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string diaChi, int maTrinhDo, int maChuyenMon, string dienThoai, string userName)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            MaTrinhDo = maTrinhDo;
            MaChuyenMon = maChuyenMon;
            DienThoai = dienThoai;
            UserName = userName;
        }

        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int MaTrinhDo { get; set; }
        public int MaChuyenMon { get; set; }
        public string DienThoai { get; set; }
        public string UserName { get; set; }
    }
}
