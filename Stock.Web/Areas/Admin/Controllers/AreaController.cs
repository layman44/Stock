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

        [HttpGet]
        public async Task<JsonResult> GetAreaListByParentID(String id = null)
        {
            if (id == null)
            {
                var roots = await _areaService.GetRoots();
                return Json(roots, JsonRequestBehavior.AllowGet);
            }
            var input = new Area.Dtos.GetAreaListInput();
            input.ParentId = id;
            var childs = await _areaService.GetChildList(input);
            return Json(childs, JsonRequestBehavior.AllowGet);
        }
    }
}