using IAmAMachine.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DAO
{
    public class TrinhDoDAO
    {
        private static TrinhDoDAO instance;

        public static TrinhDoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TrinhDoDAO();
                return instance;
            }
        }

        private TrinhDoDAO() { }

        public List<TrinhDoDTO> GetAllTrinhDo()
        {
            List<TrinhDoDTO> trinhDos = new List<TrinhDoDTO>();

            string query = "SELECT * FROM TrinhDo";

            DataTable data = DataProvider.Instance.exceQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TrinhDoDTO trinhDo = new TrinhDoDTO()
                {
                    MaTrinhDo = Convert.ToInt32(row["MaTrinhDo"]),
                    TenTrinhDo = row["TenTrinhDo"].ToString()
                };

                trinhDos.Add(trinhDo);
            }

            return trinhDos;
        }

        public TrinhDoDTO GetTrinhDoByMaTrinhDo(int maTrinhDo)
        {
            TrinhDoDTO trinhDo = null;

            string query = string.Format("SELECT * FROM TrinhDo WHERE MaTrinhDo = {0}", maTrinhDo);

            DataTable data = DataProvider.Instance.exceQuery(query);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                trinhDo = new TrinhDoDTO()
                {
                    MaTrinhDo = Convert.ToInt32(row["MaTrinhDo"]),
                    TenTrinhDo = row["TenTrinhDo"].ToString()
                };
            }

            return trinhDo;
        }

        public bool UpdateTrinhDoByMaTrinhDo(int maTrinhDo, string tenTrinhDo)
        {
            string query = string.Format("UPDATE TrinhDo SET TenTrinhDo = '{0}' WHERE MaTrinhDo = {1}", tenTrinhDo, maTrinhDo);

            int result = DataProvider.Instance.exceNonQuery(query);

            return result > 0;
        }

        public bool DeleteTrinhDoByMaTrinhDo(int maTrinhDo)
        {
            string query = string.Format("DELETE FROM TrinhDo WHERE MaTrinhDo = {0}", maTrinhDo);

            int result = DataProvider.Instance.exceNonQuery(query);

            return result > 0;
        }
    }

}
