using System.Web.Mvc;
using Abp.Auditing;

namespace SSoft.PhoneBook.Web.Controllers
{
    public class ErrorController : PhoneBookControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}