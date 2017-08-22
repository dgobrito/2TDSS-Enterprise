using Fiap.Exemplo03.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.MVC.Controllers
{
    public class AlunoController : Controller
    {
        //Simular o banco de dados
        private static List<Aluno> _banco = new List<Aluno>();

        [HttpPost]
        public ActionResult Cadastrar(Aluno aluno)
        {
            _banco.Add(aluno);
            TempData["msg"] = "Cadastrado com sucesso!";
            CarregarComboBox();
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarComboBox();
            return View();
        }

        private void CarregarComboBox()
        {
            List<string> cursos = new List<string>();
            cursos.Add("ADS");
            cursos.Add("SI");
            cursos.Add("DB");
            ViewBag.opcoes = new SelectList(cursos);
        }
    }
}