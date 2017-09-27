using Fiap.Revisao.Models;
using Fiap.Revisao.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.Controllers
{
    public class LivroController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var editoras = _unit.EditoraRepository.Listar();
            ViewBag.lista = new SelectList(editoras, "EditoraId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Livro livro)
        {
            if (ModelState.IsValid)
            {
                _unit.LivroRepository.Cadastrar(livro);
                _unit.Salvar();
                TempData["msg"] = "Cadastrar";
                return RedirectToAction("Cadastrar");
            }
            else
            {
                return View(livro);
            }
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}