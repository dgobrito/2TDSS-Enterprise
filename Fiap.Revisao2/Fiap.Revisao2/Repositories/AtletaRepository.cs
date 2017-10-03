using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Revisao2.Models;
using Fiap.Revisao2.Persistencia;
using System.Data.Entity;

namespace Fiap.Revisao2.Repositories
{
    public class AtletaRepository : IAtletaRepository
    {
        private JogosOlimpicosContext _context;

        public AtletaRepository(JogosOlimpicosContext context)
        {
            _context = context;
        }

        public void Atualizar(Atleta atleta)
        {
            _context.Entry(atleta).State = EntityState.Modified;
        }

        public Atleta Buscar(int id)
        {
            return _context.Atletas.Find(id);
        }

        public IList<Atleta> BuscarPor(Expression<Func<Atleta, bool>> filtro)
        {
            return _context.Atletas.Include("Esporte").Where(filtro).ToList();
        }

        public void Cadastrar(Atleta atleta)
        {
            _context.Atletas.Add(atleta);
        }

        public IList<Atleta> Listar()
        {
            return _context.Atletas.Include("Esporte").ToList();
        }

        public void Remover(int id)
        {
            var atleta = Buscar(id);
            _context.Atletas.Remove(atleta);
        }
    }
}