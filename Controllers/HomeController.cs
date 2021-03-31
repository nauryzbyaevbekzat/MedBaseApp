using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MedBaseApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.IO;

namespace MedBaseApp.Controllers
{   
    public class HomeController : Controller
    {
        ApplicationContext db;
        
                
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

       
        [Authorize(Roles = "admin, user")]
        public IActionResult Profile()
        {
            string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            
            if (role == "user") {
                return View(db.Users.ToList());
            }

            return RedirectToAction("Admin","Home");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Admin()
        {
            return View(db.Users.ToList());
        }
   
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated == true) {
              
                return RedirectToAction("Index2","Home"  );
            
            }

            return View();
        }
        public IActionResult Index2()
        {
            ViewBag.UserName = User.Identity.Name;
            return View();
        }
        public IActionResult Hsptls()
        {
            return View(db.hospitals.ToList());
        }
        [Authorize(Roles = "admin")]
        public IActionResult Createhospital()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Create(HospitalViewModel hvm)
        {
            Hospital hospital = new Hospital {  HospitalName = hvm.HospitalName };
            if (hvm.HospitalImage != null)
            {
                byte[] imageData = null;
                
                using (var binaryReader = new BinaryReader(hvm.HospitalImage.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)hvm.HospitalImage.Length);
                }
                
                hospital.HospitalImage = imageData;
            }
            db.hospitals.Add(hospital);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
