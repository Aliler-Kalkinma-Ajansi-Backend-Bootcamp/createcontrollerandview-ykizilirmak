﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebBackend.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}