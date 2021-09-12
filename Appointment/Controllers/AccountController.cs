using Appointment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment.Controllers
{
    public class AccountController : Controller
    {
        //database access
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
