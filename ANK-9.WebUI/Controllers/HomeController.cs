using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.UserVMs;
using ANK_9.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ANK_9.WebUI.Controllers
{
    public class HomeController : Controller
    {
       private readonly IUserBLL _userBLL;

        public HomeController(IUserBLL userBLL)
        {
            _userBLL = userBLL;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginVM vm)
        {
            ResultService<User> user = _userBLL.Login(vm);

            if (user.HasError)
            {
                string error = user.Errors.FirstOrDefault().ErrorType;

                ViewData["Error"] = error;
                return View(vm);
            }

            TempData["Id"] = user.Data.ID;

            if (user.Data.UserTypes == UserTypes.Admin)
            {
                return Redirect("http://localhost:55838/Admin/Home/Index");
                //return RedirectToAction("Index","meal","admin");
            }
            else
            {
                //return Redirect($"https://localhost:7153/Member/Home/Index/{user.Data.ID}");      //1 numara çalışıyor
                //return RedirectToAction("Index", new { id = currentcoupon.Companyid.id, Area = "Member" });   //2 numara çalıştıramadım
                return RedirectToAction("Index","Home", new {id=user.Data.ID, Area="Member"});      //3 numara çalışıyor
                //3 farklı Area yönlendirmesi
            }

        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserCreateVM vm)
        {
            ResultService<User> user = _userBLL.CreateUser(vm);

            if (user.HasError)
            {
                ViewData["Error"] = user.Errors.FirstOrDefault().ErrorType;

                return View(vm);
            }

            return RedirectToAction("Index");

        }
    }
}