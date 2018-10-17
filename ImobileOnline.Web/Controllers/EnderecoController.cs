using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImobileOnline.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImobileOnline.Web.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Eae noite, narguilé - Imdex";

            var model = new EnderecoModel();
            model.Id = 1;
            model.Rua = "Panamerica";
            model.Numero = 4323;

            return View(model);
        }

        public IActionResult Cindex()
        {
            ViewBag.Message = "Eae noite CIMDEX";

            var model = new EnderecoModel();
            model.Id = 1;
            model.Rua = "Panamerica";
            model.Numero = 4323;

            return View("Index", model);
        }
    }
}

//CRTL + .