using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class DangDieuCheDTO
    {
        public DangDieuCheDTO()
        {
        }

        public DangDieuCheDTO(int maDangDC, string tenDangDC)
        {
            MaDangDC = maDangDC;
            TenDangDC = tenDangDC;
        }

        public int MaDangDC { get; set; }
        public string TenDangDC { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
