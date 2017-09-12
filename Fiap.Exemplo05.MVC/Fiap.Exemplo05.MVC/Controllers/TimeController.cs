﻿using Fiap.Exemplo05.MVC.Models;
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
        public ActionResult Buscar(string nome)
        {
            var lista = _context.Times.Include("Tecnico")
                .Where(t => t.Nome.Contains(nome)).ToList();
            //Informa o nome da tela e a lista de times
            return View("Listar",lista);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Buscar todos os times cadastrados com o tecnico
            var lista = _context.Times.Include("Tecnico").ToList();
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
            _context.Times.Add(time);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}