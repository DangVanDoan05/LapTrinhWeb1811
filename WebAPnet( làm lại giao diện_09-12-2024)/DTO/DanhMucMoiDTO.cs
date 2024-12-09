using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucMoiDTO
    {
        // Ở đây tôi tạo ra một hàm dựng cho nó.
        public DanhMucMoiDTO(List<DanhMucDTO> ls, int iddanhmuc, string TenDM, string MoTa)
        {
            this.IDDMSUA = iddanhmuc;
            this.LISTDMSUA = ls;
            this.TENDM = TenDM;
            this.MOTA = MoTa;
        }

       
        private List<DanhMucDTO> lISTDMSUA;
        private int iDDMSUA;
        private string tENDM;
        private string mOTA;

        public int IDDMSUA { get => iDDMSUA; set => iDDMSUA = value; }
        public List<DanhMucDTO> LISTDMSUA { get => lISTDMSUA; set => lISTDMSUA = value; }
        public string TENDM { get => tENDM; set => tENDM = value; }
        public string MOTA { get => mOTA; set => mOTA = value; }
    }
}
