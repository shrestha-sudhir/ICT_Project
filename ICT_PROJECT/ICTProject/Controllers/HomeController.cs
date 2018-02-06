using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICTProject.Models.DBC;
using ICTProject.Data;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace ICTProject.Controllers
{
    public class HomeController : Controller
    {

        [AllowAnonymous] // This is what you see when you're not logged in.

        public ActionResult RMHome()
        {
            using (DbcContext db = new DbcContext())
            {
                var user = db.Users.Where(a => a.Username.Equals(User.Identity.Name)).FirstOrDefault();

                if (user != null)
                {
                    if (user.accessLevel == 1)
                    {
                        return View();
                    }
                    if (user.accessLevel == 2)
                    {
                        return RedirectToAction("ZDHome");
                    }
                    if (user.accessLevel == 3)
                    {
                        return RedirectToAction("UMHome");
                    }

                }

            }
            return View();
        }

        public ActionResult ZDHome()
        {
            return View();
        }
        public ActionResult UMHome()
        {
            return View();
        }
    }
}