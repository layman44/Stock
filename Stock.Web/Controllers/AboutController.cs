using System.Web.Mvc;

namespace Stock.Web.Controllers
{
    public class AboutController : StockControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}