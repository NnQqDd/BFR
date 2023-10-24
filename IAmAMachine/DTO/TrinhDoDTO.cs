using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DTO
{
    public class TrinhDoDTO
    {
        public TrinhDoDTO()
        {
        }

        public TrinhDoDTO(int maTrinhDo, string tenTrinhDo)
        {
            MaTrinhDo = maTrinhDo;
            TenTrinhDo = tenTrinhDo;
        }



        public int MaTrinhDo { get; set; }
        public string TenTrinhDo { get; set; }
    }

}
