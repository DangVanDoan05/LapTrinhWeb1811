using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using DTO;

namespace WebBanHang.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<DanhMucDTO> Ls = DanhMucDAO.Instance.GetListDM();
            return View(Ls);
           
        }

        public ActionResult ThemDanhMuc(string TenDM)
        {    
            DanhMucDAO.Instance.in
            // Lưu thêm mới danh mục.
            // quay trở về trang 
            return View(TenDM);
        }


    }


}