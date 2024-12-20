﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        // In My Company

        public string strcon = "Data Source=192.168.4.48,1433;Initial Catalog=WebSiteBanHang;User ID=sa;Password=P@ssword@123456";

        
      // public string strcon = "Data Source=192.168.0.10,1433;Initial Catalog=WebBanHang29-11-2024;User ID=sa;Password=12345678";


        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                if (para != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
                sqlcon.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] para = null)
        {
            int data = 0;
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                if (para != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] para = null)
        {
            object data = null;
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                if (para != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }

                }
                data = cmd.ExecuteScalar();
                sqlcon.Close();

            }
            return data;

        }
    }
}
