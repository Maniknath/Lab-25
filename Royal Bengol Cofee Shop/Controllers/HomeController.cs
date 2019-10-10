using Microsoft.AspNetCore.Mvc;
using Royal_Bengol_Cofee_Shop.Models;
using System.Diagnostics;

namespace Royal_Bengol_Cofee_Shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Result(User user)
        {
            ViewBag.Name = user.FirstName;
            return View();
        }

        public IActionResult RegisterItem()
        {
            return View();
        }

       
        [HttpPost]
            public IActionResult RegisterItem(UserItem userItem)
        {
            if (ModelState.IsValid)
            {
            ViewBag.Name = userItem.Name;
            ViewBag.Price = userItem.Price;
            ViewBag.Description = userItem.Description;
            ViewBag.Quantity = userItem.Quantity;
            return View();

            }
            else
            {
                return View(userItem);
            }
        }
    }
}
