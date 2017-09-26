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
    public class JogadorController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _unit.JogadorRepository.Listar();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os times
            var lista = _unit.TimeRepository.Listar();
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                _unit.JogadorRepository.Cadastrar(jogador);
                _unit.Save();
                TempData["msg"] = "Jogador Cadastrado";
                return RedirectToAction("Cadastrar");
            }else
            {
                //Buscar todos os times
                var lista = _unit.TimeRepository.Listar();
                ViewBag.times = new SelectList(lista, "TimeId", "Nome");
                return View(jogador);
            }
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}