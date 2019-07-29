using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.DBModel;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class AccountController : Controller
    {
        UserDBEntities1 udb = new UserDBEntities1();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }


        // GET: Account
        public ActionResult Register()
        {
            UserModel us = new UserModel();
            return View(us);
        }
       [HttpPost]
        public ActionResult Register(UserModel userModel)
        {
            if(ModelState.IsValid)
            {
                User user = new DBModel.User();
                user.Created = DateTime.Now;
                user.FirstName = userModel.FirstName;
                user.LastName = userModel.LastName;
                user.Email = userModel.Email;
                user.Password = userModel.Password;

                udb.Users.Add(user);
                udb.SaveChanges();
                userModel.SuccessMessage = "success Fully Added";
                return View();

            }
            return View();
        }


        public ActionResult Login()
        {
            LoginModel lm = new LoginModel();
            return View(lm);
        }
        [HttpPost]
        public ActionResult Login(LoginModel lm)
        {
            if(ModelState.IsValid)
            {
                if(udb.Users.Where(x=>x.Email==lm.Email &&  x.Password == lm.Password).FirstOrDefault()== null)
                {
                    ModelState.AddModelError("Error","Email Or Password Not Match");
                    return View();
                }
                else
                {
                    Session["Email"] = lm.Email;
                    RedirectToAction("Index","Home");
                }

               
            }
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }
    }
}