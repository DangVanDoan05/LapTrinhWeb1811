using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
        public class DanhMucDAO
        {
            private static DanhMucDAO instance;

            public static DanhMucDAO Instance
            {
                get { if (instance == null) instance = new DanhMucDAO(); return DanhMucDAO.instance; }
                private set { DanhMucDAO.instance = value; }
            }

            private DanhMucDAO() { }


            // HAM LAY BANG
            public DataTable GetTable()
            {
                string query = "select* from DSDANHMUC";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                return data;
            }


            public List<DanhMucDTO> GetListDM()
            {
                string query = "select * from DSDANHMUC";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                List<DanhMucDTO> lsv = new List<DanhMucDTO>();
                foreach (DataRow item in data.Rows)
                {
                    DanhMucDTO dmDTO = new DanhMucDTO(item);
                    lsv.Add(dmDTO);
                }
                return lsv;
            }

           // HAM THEM

            public int Insert(string TenDM, string MOTA)
            {
                string query = "insert DSDANHMUC(TENDM,MOTA) values( @Ten , @mota )";
                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenDM, MOTA });
                return data;
            }


            // HAM SUA

            public int Update(int id, string TenDM, string MOTA)
            {
                string query =" UPDATE	DSDANHMUC SET TENDM= @ten ,MOTA= @mota WHERE ID= @id ";
                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenDM, MOTA,id });
                return data;
            }


            // HAM XOA

            public int Delete(int id)
            {
                string query = "DELETE DSDANHMUC WHERE ID= @id ";
                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
                return data;
            }



        }
    }

