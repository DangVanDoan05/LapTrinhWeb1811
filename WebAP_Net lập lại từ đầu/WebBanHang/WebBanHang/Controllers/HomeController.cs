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


        public ActionResult ThemDanhMuc(string TenDM,string MoTa)
        {
            DanhMucDAO.Instance.Insert(TenDM, MoTa);
            // Lưu thêm mới danh mục.
            // quay trở về trang 
            return RedirectToAction("Index");
        }


        public ActionResult CapNhatDanhMuc(int idDanhMuc)
        {
            DanhMucDTO dmDTO = DanhMucDAO.Instance.GetDanhMucDTO(idDanhMuc);
            return View(dmDTO);
        }


        public ActionResult IndexSua(string idDanhMuc)
        {
            int id = int.Parse(idDanhMuc);
            DanhMucDTO dmDTO = DanhMucDAO.Instance.GetDanhMucDTO(id);
            return RedirectToAction("Index");
        }

        public ActionResult SuaDanhMuc(string idDanhMuc,string TenDMMoi, string MoTaMoi)
        {
            int id = int.Parse(idDanhMuc);
            DanhMucDAO.Instance.Update(id, TenDMMoi, MoTaMoi);           
            return RedirectToAction("Index");
        }

    }
}