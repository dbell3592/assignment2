using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBassignment2.Models;

namespace DBassignment2.Controllers
{
    public class HomeController : Controller
    {
 //       public IActionResult Index()
 //       {
 //           return View();
 //       }

//        public IActionResult Privacy()
//        {
 //           return View();
 //       }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index(ConversionModel model, string command)
        {

            if (command == "Decimal To Binary")
            {
                model.myOutput = ConversionCalculatorBL.ConvertNumber.toBinary(model.myInput);
            }
            if (command == "Binary To Decimal")
            {
                model.myOutput = ConversionCalculatorBL.ConvertNumber.toDecimal(model.myInput);
            }

            return View(model);

        }
    }
}
