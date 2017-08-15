using Fiap.Exemplo02.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Controllers
{
    public class CervejaController : Controller
    {        
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Cerveja cerveja)
        {
            //Enviando valores para a view
            ViewBag.nomeCerveja = cerveja.Nome;
            ViewBag.data = cerveja.Validade;
            ViewBag.alcool = cerveja.Teor;

            TempData["msg"] = "Cerveja cadastrada!";

            return View(cerveja);
            //return Content("Gravou!" + " " + cerveja.Nome + " " + 
            //    cerveja.Teor + " " + cerveja.Validade);
        }
    }
}