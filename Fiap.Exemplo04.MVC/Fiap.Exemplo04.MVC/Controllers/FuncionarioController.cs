using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private ZooContext _context = new ZooContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return Redirect("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Funcionarios.ToList());
        }
    }
}