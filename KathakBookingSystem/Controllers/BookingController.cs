using System;
using KathakBookingSystem.Data;
using KathakBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KathakBookingSystem.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
          public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult ClassEnrollmentForm(int id)
        { 
            var classdata=_context.Classes.ToList();
            var studentdata=_context.Students.ToList();
            var studentcount= studentdata.Where(s=>s.ClassID==id).Count();
            var classcount=classdata.Where(c=>c.ClassID==id).Count();
            if(studentcount>classcount)
            throw new KathakClassBookingException("Class is fully booked.");
            var data=_context.Classes.Find(id);
            if(data==null) return NotFound();
            // Write ClassEnrollmentForm functionality here
            // if students count is greater than Class Capacity Throw a exception "Class is fully booked."
            // if class not found return NotFound() else return View()
            return View();
        }

        [HttpPost]
        public IActionResult ClassEnrollmentForm(int id, string name, string email)
        {
            // Write functionality for adding students
            // Successfull adding redirect to EnrollmentConfirmation with StudentID
            // Handle KathakClassBookingException "Class is fully booked."
            return View();
        }

        public IActionResult EnrollmentConfirmation(int studentId)
        {
            // Write functionality to display EnrollmentConfirmation student
            // Return NotFound if null else Return View
            return View();
        }
    }
}
