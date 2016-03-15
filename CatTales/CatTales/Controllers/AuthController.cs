using CatTales.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace CatTales.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        // Hard coding a User Manager for now, to avoid having to do Dependency Injection
        UserManager<Member> userManager = new UserManager<Member>(
                new UserStore<Member>(new CatTalesContext()));

        // GET: /Auth/LogIn
        public ActionResult LogIn(string returnUrl)
        {
            var model = new AuthLogInViewModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        // POST: /Auth/LogIn
        [HttpPost]
        public ActionResult LogIn(AuthLogInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Using UserManager (no async)
            var user = userManager.Find(model.UserName, model.Password);

            if (user != null)
            {
                var identity = userManager.CreateIdentity(
                    user, DefaultAuthenticationTypes.ApplicationCookie);

                GetAuthenticationManager().SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }

            // user authN failed
            ModelState.AddModelError("", "Invalid username or password");
            return View();

            /*
            // Don't do this in production!
            // Hardcode an Admin user
            if (model.UserName == "admin" && model.Password == "password")
            {
                var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, "Admin"),
                new Claim(ClaimTypes.Email, "tester@test.com"),
                new Claim(ClaimTypes.Country, "USA")
            },
                    "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }

            // user authN failed
            ModelState.AddModelError("", "Invalid username or password");
            return View();
              */
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("Index", "Home");
            }

            return returnUrl;
        }

        // GET: /Auth/LogOut
        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }

        // Added from 'ASP.NET Identity Stripped Bare' example code on GitHub
        private IAuthenticationManager GetAuthenticationManager()
        {
            var ctx = Request.GetOwinContext();
            return ctx.Authentication;
        }
        // Also added from GitHub, modified to NOT use async
        private void SignIn(Member user)
        {
            var identity = userManager.CreateIdentity(
                user, DefaultAuthenticationTypes.ApplicationCookie);

            GetAuthenticationManager().SignIn(identity);
        }

        // GET: /Auth/Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Auth/Register
        [HttpPost]
        public ActionResult Register(AuthRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = new Member
            {
                // the order of the following is how they will display
                //UserName = model.Email,
                NameFirst = model.NameFirst,
                NameLast = model.NameLast,
                Email = model.Email,
                UserName = model.UserName
                //Password = model.Password,
                //Gender = model.Gender

            };

            var result = userManager.Create(user, model.Password);  

            if (result.Succeeded)
            {
                SignIn(user);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }

            return View();
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing && userManager != null)
            {
                userManager.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}