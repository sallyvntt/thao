﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Group3.Controllers
{
    public class FrontEndController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // Thông tin của tài khoản User
        //public IActionResult Detail() 
        //{
        //    var acc = 
        //return RedirectToAction("Detail");
        //}
    }
}

