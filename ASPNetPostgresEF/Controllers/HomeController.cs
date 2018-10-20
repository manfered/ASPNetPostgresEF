using ASPNetPostgresEF.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASPNetPostgresEF.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (DBModels dbmodel = new DBModels())
            {
                var test = dbmodel.alertsystems.Count().ToString();

                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, change to shouldLockout: true

                var SignInManager = HttpContext.GetOwinContext().Get<ApplicationSignInManager>(); ;

                var result = await SignInManager.PasswordSignInAsync("vog@vog.com", "1qaz@WSX", false, shouldLockout: false);
                switch (result)
                {
                    case SignInStatus.Success:
                        test += " success";
                        break;
                    case SignInStatus.LockedOut:
                        return View("Lockout");
                    case SignInStatus.RequiresVerification:
                        return RedirectToAction("SendCode", new { ReturnUrl = "", RememberMe = false });
                    case SignInStatus.Failure:
                    default:
                        ModelState.AddModelError("", "Invalid login attempt.");
                        break;
                }


                return Content(test.ToString());
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}