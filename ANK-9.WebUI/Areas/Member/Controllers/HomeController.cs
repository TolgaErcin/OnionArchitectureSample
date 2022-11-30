using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.UserVMs;
using Microsoft.AspNetCore.Mvc;

namespace ANK_9.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class HomeController : Controller
    {
        private readonly IUserBLL userBLL;
        private static ResultService<User> _result;

        public HomeController(IUserBLL userBLL)
        {
            this.userBLL = userBLL;
        }
        public IActionResult Index(int id)
        {
            _result=userBLL.GetUserById(id);
            TempData["Id"] = id;
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UserUpdateVM vm)
        {
            return View(vm);
        }
    }
}
