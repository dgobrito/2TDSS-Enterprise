using Fiap.CorrecaoNac.Models;
using Fiap.CorrecaoNac.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.CorrecaoNac.Controllers
{
    public class AvaliacaoController : Controller
    {
        private NacContext _context = new NacContext();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Avaliacoes.Include("Disciplina").ToList());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _context.Disciplinas.ToList();
            ViewBag.lista = new SelectList(lista, "DisciplinaId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}