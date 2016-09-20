using Stock.Area;
using Stock.Web.Areas.Admin.Models.Area;
using Stock.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Stock.Web.Areas.Admin.Controllers
{
    public class AreaController : StockControllerBase
    {
        private readonly IAreaService _areaService;
        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        // GET: Admin/Area
        public async Task<ActionResult> Index()
        {
            var output = await _areaService.GetRoots();
            var model = new IndexViewModel(output.Roots);
            return View(model);
        }

        [HttpGet]
        public async Task<JsonResult> GetAreaListByParentID(String id)
        {
            var input = new Area.Dtos.GetAreaListInput();
            input.ParentId = id;
            var output = await _areaService.GetChildList(input);
            return Json(output.Items, JsonRequestBehavior.AllowGet);
        }
    }
}