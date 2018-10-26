using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ImobileOnline.Web.Controllers
{
    public class DetalheImovelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}