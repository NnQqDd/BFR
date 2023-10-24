using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class ChuyenMonDTO
    {
        public ChuyenMonDTO()
        {
        }

        public ChuyenMonDTO(int maChuyenMon, string tenChuyenMon)
        {
            MaChuyenMon = maChuyenMon;
            TenChuyenMon = tenChuyenMon;
        }

        public int MaChuyenMon { get; set; }
        public string TenChuyenMon { get; set; }
    }
}
