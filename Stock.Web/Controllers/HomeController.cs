using System.Web.Mvc;

namespace Stock.Web.Controllers
{
    public class HomeController : StockControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}