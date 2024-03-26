using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessageCount = 3;

            ViewBag.annoucementTrue = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.annoucementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.marketingProductHitman = c.Teams.Where(x => x.Title == "Tetikçi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.marketingProductCowboy = c.Teams.Where(x => x.Title == "Kovboy").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.marketingProductMoto = c.Teams.Where(x => x.Title == "Motorcu").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.marketingProductMC = c.Teams.Where(x => x.Title == "Başkan").Select(y => y.PersonName).FirstOrDefault();

            return View();
        }
    }
}
