using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO()
        {
        }

        public KhachHangDTO(int maKhach, string tenKhach, string diaChi, string dienThoai)
        {
            MaKhach = maKhach;
            TenKhach = tenKhach;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        public int MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    }

}
