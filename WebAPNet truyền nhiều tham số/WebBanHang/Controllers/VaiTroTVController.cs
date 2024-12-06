using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using DAO;

namespace WebBanHang.Controllers
{
    public class VaiTroTVController : Controller
    {
        // GET: VaiTroTV
        public ActionResult Index()
        {
            List<DanhMucDTO> Ls = DanhMucDAO.Instance.GetListDM();
            return View(Ls);
        }
    }
}