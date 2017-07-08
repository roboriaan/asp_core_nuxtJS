using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Starter_Nuxt.Controllers
{
    public class ApiController : Controller
    {
        public JsonResult MessageFromDrEvil()
        {
            return Json("We're not so different.. You and I.");
        }
    }
}
