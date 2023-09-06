using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers 
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"] = saat > 12 ? "Iyi Günler":"Günaydin";
            int UserCount = Repository.Users.Where(info=> info.WillAttend==true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Kongre Merkezi",
                Date = new DateTime(2023,09,15,08,2,0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        }
    }
}


