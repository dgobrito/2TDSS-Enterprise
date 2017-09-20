using Fiap.Exemplo05.MVC.Models;
using Fiap.Exemplo05.MVC.Persistencia;
using Fiap.Exemplo05.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo05.MVC.Controllers
{
    public class TimeController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Buscar(string nome)
        {
            var lista = _unit.TimeRepository
                    .BuscarPor(t => t.Nome.Contains(nome));
            //Informa o nome da tela e a lista de times
            return View("Listar",lista);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Buscar todos os times cadastrados com o tecnico
            var lista = _unit.TimeRepository.Listar();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            _unit.TimeRepository.Cadastrar(time);
            _unit.Save();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

    }
}