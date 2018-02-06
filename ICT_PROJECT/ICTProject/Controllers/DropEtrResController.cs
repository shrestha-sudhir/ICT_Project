using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICTProject.Controllers
{
    [AllowAnonymous]
    public class DropEtrResController : Controller
    {
        // GET: Drop2
        public ActionResult DailyResults()

        {
            return View();
        }
    }
}