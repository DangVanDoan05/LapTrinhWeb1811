using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucDTO
    {
        public DanhMucDTO(DataRow row)
        {
            this.ID = int.Parse(row["ID"].ToString());
            this.TENDM = row["TENDM"].ToString();
            this.MOTA = row["MOTA"].ToString();
        }

        private int iD;
        private string tENDM;
        private string mOTA;

        public int ID { get => iD; set => iD = value; }
        public string TENDM { get => tENDM; set => tENDM = value; }
        public string MOTA { get => mOTA; set => mOTA = value; }

    }

}
