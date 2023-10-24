using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class NhaCungCapDTO
    {
        public NhaCungCapDTO()
        {
        }

        public NhaCungCapDTO(int maNCC, string tenNCC, string diaChi, string dienThoai)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    }
}
