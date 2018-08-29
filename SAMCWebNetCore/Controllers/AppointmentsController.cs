using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SAMCWebNetCore.Models;

namespace SAMCWebNetCore.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            AppointmentContext Context = HttpContext.RequestServices.GetService(typeof(SAMCWebNetCore.Models.AppointmentContext)) as AppointmentContext;
            return View(Context.GetAllAppointment());
        }

        public IActionResult Create()
        {
            AppointmentContext Context = HttpContext.RequestServices.GetService(typeof(SAMCWebNetCore.Models.AppointmentContext)) as AppointmentContext;
            return View(Context.GetAllAppointment());
        }


    }
}
