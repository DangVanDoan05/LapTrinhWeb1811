using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using DTO;

namespace WebBanHang.Controllers
{
    public class DanhMucController : Controller
    {
        // GET: DanhMuc
        public ActionResult Index()
        {
            List<DanhMucDTO> Ls = DanhMucDAO.Instance.GetListDM();
            return View(Ls);
        }



    }
}