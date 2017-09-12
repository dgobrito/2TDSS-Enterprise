using Fiap.Exemplo05.MVC.Models;
using Fiap.Exemplo05.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo05.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private TimeContext _context = new TimeContext();

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Jogadores.Include("Time").ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os times
            var lista = _context.Times.ToList();
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            TempData["msg"] = "Jogador Cadastrado";
            return RedirectToAction("Cadastrar");
        }
    }
}