using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Exemplo05.MVC.Models;
using Fiap.Exemplo05.MVC.Persistencia;
using System.Data.Entity;

namespace Fiap.Exemplo05.MVC.Repositories
{
    public class TimeRepository : ITimeRepository
    {
        private TimeContext _context;

        public TimeRepository(TimeContext context)
        {
            _context = context;
        }

        public void Alterar(Time time)
        {
            _context.Entry(time).State = EntityState.Modified;
        }

        public Time Buscar(int id)
        {
            return _context.Times.Find(id);
        }

        public List<Time> BuscarPor(Expression<Func<Time, bool>> filtro)
        {
            return _context.Times.Include("Tecnico")
                                .Where(filtro).ToList();
        }

        public void Cadastrar(Time time)
        {
            _context.Times.Add(time);
        }

        public List<Time> Listar()
        {
            return _context.Times.Include("Tecnico").ToList();
        }

        public void Remover(int id)
        {
            var time = _context.Times.Find(id);
            _context.Times.Remove(time);
        }
    }
}