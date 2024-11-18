using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Web2
{
    public class SanPhamDTO
    {

        public SanPhamDTO(DataRow row)
        {
            this.Id =int.Parse(row["Id"].ToString());
            this.Ten = row["Ten"].ToString();
            this.Gia= row["Gia"].ToString();
        }
    
        private int id;
        private string ten;
        private string gia;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gia { get => gia; set => gia = value; }

    }
}