using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        public static List<Models.ButtonModel> buttons = new List<Models.ButtonModel>();
        // GET: Button
        public ActionResult Index()
        {
            Models.ButtonModel button1 = new Models.ButtonModel(false);
            Models.ButtonModel button2 = new Models.ButtonModel(false);

            ButtonController.buttons.Add(button1);
            ButtonController.buttons.Add(button2);

            return View("Button", buttons);
        }

        public ActionResult OnButtonClick(string mine)
        {
            if (mine.Equals("1"))
            {
                if (buttons[0].State)
                {
                    buttons[0].State = false;
                }
                else
                {
                    buttons[0].State = true;

                }
            }
            else if (mine.Equals("2"))
            {
                if (buttons[1].State)
                {
                    buttons[1].State = false;
                }
                else
                {
                    buttons[1].State = true;

                }
            }

            return View("Button", buttons);
        }
    }
}