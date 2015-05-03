using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;

namespace ZeMnaJedz.Controllers
{
    public class AdministratorController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AdministratorController()
        {
        }

        public AdministratorController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }




        // Zwraca jakiś user view model do podgladu uzytkownika
        [HttpGet]
        [Authorize(Roles = "Moderator, Administrator")]
        public ActionResult GetUser(string id)
        {
            return null;
        }

        // Strona do edycji uzytkownika
        [HttpGet]
        [Authorize(Roles = "Moderator, Administrator")]
        public ActionResult EditUser(string id)
        {
            return null;
        }

        // Zapisanie zedytowanego uzytkownika
        [HttpPost]
        [Authorize(Roles = "Moderator, Administrator")]
        public ActionResult EditUser(string id, EditUserViewModel model)
        {
            return null;
        }

        // Strona do wyszukiwania uzytkownika
        [HttpGet]
        [Authorize(Roles = "Moderator, Administrator")]
        public ActionResult SearchForUser()
        {
            return null;
        }

        // Strona wyswietlaja wyniki wyszukiwania uzytkownika
        [HttpPost]
        [ActionName("SearchForUser")]
        [Authorize(Roles = "Moderator, Administrator")]
        public ActionResult SearchForUserPost(SearchUserViewModel model)
        {
            return null;
        }

        // Zbanowanie użytkownika
        [HttpPost]
        [Authorize(Roles = "Moderator, Administrator")]
        public ActionResult BanUser(string id, string returlUrl)
        {
            return null;
        }

        // Odbanowanie użytkownika
        [HttpPost]
        [Authorize(Roles = "Moderator, Administrator")]
        public ActionResult UnbanUser(string id, string returlUrl)
        {
            return null;
        }

        // Nadanie uprawnien moderatora
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult AddPermission(string id, string returlUrl)
        {
            return null;
        }

        // Odebranie uprawnien moderatora 
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult RemovePermission(string id, string returlUrl)
        {
            return null;
        }


    }
}