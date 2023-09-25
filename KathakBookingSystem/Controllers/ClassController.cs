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
         private readonly ApplicationDbContext _context;
          public ClassController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AvailableClasses()
        {
             var data=_context.Classes.ToList();
            return View(data);
            //Write Functionality to display AvailableClasses return view
           // return View();
        }
    }
}
