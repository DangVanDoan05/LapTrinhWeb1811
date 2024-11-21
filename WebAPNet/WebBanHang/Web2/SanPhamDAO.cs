using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAO;


namespace Web2
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return SanPhamDAO.instance; }
            private set { SanPhamDAO.instance = value; }
        }

        private SanPhamDAO() { }


        // HAM LAY BANG
        public DataTable GetTable()
        {
            string query = "select* from SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public List<SanPhamDTO> GetListSP()
        {
            string query = "select * from SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<SanPhamDTO> lsv = new List<SanPhamDTO>();
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO spDTO = new SanPhamDTO(item);
                lsv.Add(spDTO);
            }
            return lsv;
        }



        public int Insert(string MaCV, string TenCV, int BacCV)
        {
            string query = "insert QUANLYCHUCVU(MACHUCVU,TENCHUCVU,BACCV) values( @ma , @ten , @baccv )";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCV, TenCV, BacCV });
            return data;
        }

        // HAM SUA
        public int Update(string MaCV, string TenCV, int BacCV)
        {
            string query = "UPDATE	QUANLYCHUCVU SET TENCHUCVU= @ten ,BACCV= @bacCV WHERE MACHUCVU= @ma ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenCV, BacCV, MaCV });
            return data;
        }

        // HAM XOA
        public int Delete(string MaCV)
        {
            string query = "DELETE QUANLYCHUCVU WHERE MACHUCVU= @ma ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCV });
            return data;
        }

    }
}