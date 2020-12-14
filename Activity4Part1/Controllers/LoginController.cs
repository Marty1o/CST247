using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using Activity1Part3.Utility;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        // this got replaced, left here for note purposes
        //private static Logger logger = LogManager.GetLogger("myAppLoggerRules");

        // new replacement for code above
        private static MyLogger1 logger = MyLogger1.GetInstance();

        [HttpGet] 
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            try
            {

                logger.Info("Entering LoginController.Login()");


                // Validate the Form POST
                if (!ModelState.IsValid)
                    return View("Login");

                Services.Business.SecurityService service = new Services.Business.SecurityService();

                bool authenticated = service.Authenticate(model);

                logger.Info("Parameters are:", new JavaScriptSerializer().Serialize(model));

                if (authenticated)
                {
                    logger.Info("Exit LoginController.DoLogin() with login passing");
                    return View("LoginPassed", model);
                }
                else
                {
                    logger.Info("Exit LoginController.DoLogin() with login failing");

                    return View("LoginFailed");
                }
            }
            catch (Exception e)
            {
                logger.Error("Exception LoginController.DoLogin()", e.Message);
                return View("Error");
            }
        }

    }
}