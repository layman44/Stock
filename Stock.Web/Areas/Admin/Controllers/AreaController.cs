using Stock.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Stock.Web.Areas.Admin.Controllers
{
    public class AreaController : Controller
    {
        private readonly IAreaService _areaService;
        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        // GET: Admin/Area
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetRoots()
        {
            var output = await _areaService.GetRoots();
            return Json(output, JsonRequestBehavior.AllowGet);
        }
    }
}