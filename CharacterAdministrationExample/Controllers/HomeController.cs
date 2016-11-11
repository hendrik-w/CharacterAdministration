using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterAdministrationExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        /// <summary>
        /// Views the character html with the param Models.Character.GetAll()
        /// </summary>
        /// <returns>Character view</returns>
        public ActionResult Character()
        {
            return View("Character", Models.Character.GetAll());
        }


        /// <summary>
        /// Creates the specified character name.
        /// </summary>
        /// <param name="characterName">Name of the character.</param>
        /// <returns></returns>
        public ActionResult Create(String characterName)
        {
            Models.Character.Create(characterName);
            return RedirectToAction("Character");
        }

    }
}
