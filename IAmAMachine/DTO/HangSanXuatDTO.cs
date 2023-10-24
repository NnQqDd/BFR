using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class HangSanXuatDTO
    {
        public HangSanXuatDTO()
        {
        }

        public HangSanXuatDTO(int maHangSX, string tenHangSX, string tenNuocSX)
        {
            MaHangSX = maHangSX;
            TenHangSX = tenHangSX;
            TenNuocSX = tenNuocSX;
        }

        public int MaHangSX { get; set; }
        public string TenHangSX { get; set; }
        public string TenNuocSX { get; set; }
    }
}
