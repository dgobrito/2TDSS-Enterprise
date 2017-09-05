using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.MVC.Controllers
{
    public class AnimalController : Controller
    {
        private ZooContext _context = new ZooContext();

        public ActionResult Remover(int id)
        {
            var animal = _context.Animais.Find(id);
            _context.Animais.Remove(animal);
            _context.SaveChanges();
            TempData["msg"] = "Excluido";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Alterar(Animal animal)
        {
            _context.Entry(animal).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            return View(_context.Animais.Find(id));
        }

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

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Animais.ToList());
        }
    }
}