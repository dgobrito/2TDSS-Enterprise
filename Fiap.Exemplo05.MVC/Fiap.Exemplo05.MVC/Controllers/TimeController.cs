using Fiap.Exemplo05.MVC.Models;
using Fiap.Exemplo05.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo05.MVC.Controllers
{
    public class TimeController : Controller
    {
        private TimeContext _context = new TimeContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            _context.Times.Add(time);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}