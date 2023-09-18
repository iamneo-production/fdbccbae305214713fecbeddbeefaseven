using System;
using System.Linq;
using KathakBookingSystem.Data;
using KathakBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KathakBookingSystem.Controllers
{
    public class ClassController : Controller
    {  
         private readonly ApplicationDbContext db=new ApplicationDbContext();

     
        public IActionResult AvailableClasses()
        {
            //ApplicationDbContext db=new ApplicationDbContext();
            //var data=db.Class.ToList();
var data=from c in db.Class select c;
            //Write Functionality to display AvailableClasses return view
            return View(data);
        }
    }
}
