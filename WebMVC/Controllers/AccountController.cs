using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.ViewModels;

namespace WebMVC.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Login(AccountViewModel avm)
        {
            if(avm.Account.UserName.Equals("abc")&& avm.Account.Password.Equals("123"))
            {
                //Session["userName"] = avm.Account.UserName;
                return View("Welcome");
            }
            else
            {
                ViewBag.Error = "Account's Invalid";
                return View("Index");
            }
        }
    }
}
