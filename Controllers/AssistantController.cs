﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gabinet_v2.Controllers
{
    public class AssistantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}