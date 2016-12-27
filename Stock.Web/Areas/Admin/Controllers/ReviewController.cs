using Stock.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock.Web.Areas.Admin.Controllers
{
    public class ReviewController : StockControllerBase
    {
        // GET: Admin/Review
        public ActionResult Index()
        {
            return View();
        }
    }
}