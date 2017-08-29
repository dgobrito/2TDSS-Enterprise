using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.MVC.Controllers
{
    public class AnimalController : Controller
    {
        private ZooContext _context = new ZooContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal)
        {
            _context.Animais.Add(animal);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            //Para não cadastrar varias vezes
            return RedirectToAction("Cadastrar");
        }
    }
}