using System.Web.Mvc;

namespace SSoft.PhoneBook.Web.Controllers
{
    public class AboutController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}