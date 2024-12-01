﻿using System;
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


        // bây giờ đang muốn nó ánh xạ thông tin khi sửa ngay tại trang chủ.

        public ActionResult CapNhatDanhMuc(int idDanhMuc)
        {

            DanhMucDTO dmDTO = DanhMucDAO.Instance.GetDanhMucDTO(idDanhMuc);
            return View(dmDTO);
        }



        public ActionResult CapNhatDanhMucMoi(string idDanhMuc)
        {
            List<DanhMucDTO> Ls = DanhMucDAO.Instance.GetListDM();
            int idDMmoi = int.Parse(idDanhMuc);
            DanhMucDTO dmDTO = DanhMucDAO.Instance.GetDanhMucDTO(idDMmoi);
            DanhMucMoiDTO dsMoi = new DanhMucMoiDTO(Ls, idDMmoi,dmDTO.TENDM,dmDTO.MOTA);
            return View(dsMoi);
        }


    }
}