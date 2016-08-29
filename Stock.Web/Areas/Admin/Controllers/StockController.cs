using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock.Web.Areas.Admin.Controllers
{
    public class StockController : Controller
    {
        // GET: Admin/Stock
        public ActionResult Index()
        {
            return View();
        }
    }
}