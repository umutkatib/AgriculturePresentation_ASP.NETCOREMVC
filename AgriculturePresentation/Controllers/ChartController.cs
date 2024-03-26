using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();

            productClasses.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 1000
            });
            productClasses.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 480
            });
            productClasses.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 725
            });
            productClasses.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 900
            });
            productClasses.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 950
            });

            return Json(new {jsonlist = productClasses});
        }
    }
}
