using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<Activity2Part1.Models.UserModel> users = new List<Activity2Part1.Models.UserModel>();

            Activity2Part1.Models.UserModel user1 = new Models.UserModel("Martin Carranza", "email@outlook.com", "(480)-333-3333");
            Activity2Part1.Models.UserModel user2 = new Models.UserModel("Eli Diaz", "email@email.com", "(404)-222-2222");
            Activity2Part1.Models.UserModel user3 = new Models.UserModel("Uli Bara", "email@yahoo.com", "(909)-111-1111");
            Activity2Part1.Models.UserModel user4 = new Models.UserModel("Mera Jesus", "email@yahoo.com", "(602)333-3333");

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);


            return View("Test", users);
        }
    }
}
