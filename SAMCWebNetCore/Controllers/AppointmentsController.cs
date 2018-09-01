using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SAMCWebNetCore.Models;

namespace SAMCWebNetCore.Controllers
{
    public class AppointmentsController : Controller
    {
        AppointmentContext ObjAppointment = new AppointmentContext();
        CustomerContext ObjCustomer = new CustomerContext();

        public IActionResult Index()
        {
            AppointmentContext context = HttpContext.RequestServices.GetService(typeof(SAMCWebNetCore.Models.AppointmentContext)) as AppointmentContext;
            return View(context.GetAllAppointments());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                ObjAppointment.AddNewAppointment(appointment);
                return RedirectToAction("Index");
            }

            return View(appointment);
        }
    }
}