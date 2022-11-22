using ANK_9.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ANK_9.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        IUserBLL _userBLL;
        public HomeController(IUserBLL userBLL)
        {
            _userBLL = userBLL;
        }

        public IActionResult Index()
        {
            //int id = int.Parse(TempData["Id"].ToString());

            return View();
        }
    }
}
