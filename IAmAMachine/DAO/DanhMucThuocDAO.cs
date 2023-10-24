using IAmAMachine.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAMachine.DAO
{
    public class DanhMucThuocDAO
    {
        private static DanhMucThuocDAO instance;

        public static DanhMucThuocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhMucThuocDAO();
                return instance;
            }
        }

        private DanhMucThuocDAO() { }

        public List<DanhMucThuocDTO> GetAllDanhMucThuoc()
        {
            List<DanhMucThuocDTO> danhMucThuocs = new List<DanhMucThuocDTO>();

            string query = "SELECT * FROM DanhMucThuoc";

            DataTable data = DataProvider.Instance.exceQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DanhMucThuocDTO danhMucThuoc = new DanhMucThuocDTO()
                {
                    MaThuoc = Convert.ToInt32(row["MaThuoc"]),
                    TenThuoc = row["TenThuoc"].ToString(),
                    DonViDongGoi = row["DonViDongGoi"].ToString(),
                    ThanhPhan = row["ThanhPhan"].ToString(),
                    GiaNhap = Convert.ToDecimal(row["GiaNhap"]),
                    GiaBan = Convert.ToDecimal(row["GiaBan"]),
                    MaDangDC = Convert.ToInt32(row["MaDangDC"]),
                    SLHienCo = Convert.ToInt32(row["SLHienCo"]),
                    MaHangSX = Convert.ToInt32(row["MaHangSX"]),
                    CongDung = row["CongDung"].ToString(),
                    HanSD = row["HanSD"].ToString()
                };

                danhMucThuocs.Add(danhMucThuoc);
            }

            return danhMucThuocs;
        }

           public DanhMucThuocDTO GetDanhMucThuocByMaThuoc(int maThuoc)
        {
            DanhMucThuocDTO danhMucThuoc = null;

            string query = string.Format("SELECT * FROM DanhMucThuoc WHERE MaThuoc = {0}", maThuoc);

            DataTable data = DataProvider.Instance.exceQuery(query);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                danhMucThuoc = new DanhMucThuocDTO()
                {
                    MaThuoc = Convert.ToInt32(row["MaThuoc"]),
                    TenThuoc = row["TenThuoc"].ToString(),
                    DonViDongGoi = row["DonViDongGoi"].ToString(),
                    ThanhPhan = row["ThanhPhan"].ToString(),
                    GiaNhap = Convert.ToDecimal(row["GiaNhap"]),
                    GiaBan = Convert.ToDecimal(row["GiaBan"]),
                    MaDangDC = Convert.ToInt32(row["MaDangDC"]),
                    SLHienCo = Convert.ToInt32(row["SLHienCo"]),
                    MaHangSX = Convert.ToInt32(row["MaHangSX"]),
                    CongDung = row["CongDung"].ToString(),
                    HanSD = row["HanSD"].ToString()
                };
            }

            return danhMucThuoc;
        }

        public bool UpdateDanhMucThuocByMaThuoc(int maThuoc, string tenThuoc, string donViDongGoi, string thanhPhan, decimal giaNhap, decimal giaBan, int maDangDC, int slHienCo, int maHangSX, string congDung, string hanSD)
        {
            string query = string.Format("UPDATE DanhMucThuoc SET TenThuoc = '{0}', DonViDongGoi = '{1}', ThanhPhan = '{2}', GiaNhap = {3}, GiaBan = {4}, MaDangDC = {5}, SLHienCo = {6}, MaHangSX = {7}, CongDung = '{8}', HanSD = '{9}' WHERE MaThuoc = {10}",
                tenThuoc, donViDongGoi, thanhPhan, giaNhap, giaBan, maDangDC, slHienCo, maHangSX, congDung, hanSD, maThuoc);

            int result = DataProvider.Instance.exceNonQuery(query);

            return result > 0;
        }

        public bool DeleteDanhMucThuocByMaThuoc(int maThuoc)
        {
            string query = string.Format("DELETE FROM DanhMucThuoc WHERE MaThuoc = {0}", maThuoc);

            int result = DataProvider.Instance.exceNonQuery(query);

            return result > 0;
        }
    }

}
