using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2.Controllers
{
    public class HomeController : Controller // Nó đang là một Class.
    {
        // GET: Home
        // Luôn chạy File Index đầu tiên.
        // Như thế này thì sẽ hơi khó hiểu bản chất vấn đề.

        public ActionResult Index()  // Đây là một phương thức.
        {           
            return View();
        }
        public ActionResult Category()  // Xuất ra View Category
        {
            return View();
        }
    }
}