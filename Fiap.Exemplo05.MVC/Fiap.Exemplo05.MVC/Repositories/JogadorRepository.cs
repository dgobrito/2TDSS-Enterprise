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
    public class JogadorRepository : IJogadorRepository
    {
        private TimeContext _context;

        public JogadorRepository(TimeContext context)
        {
            _context = context;
        }

        public void Alterar(Jogador jogador)
        {
            _context.Entry(jogador).State = EntityState.Modified;
        }

        public Jogador Buscar(int id)
        {
            return _context.Jogadores.Find(id);
        }

        public List<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro)
        {
            return _context.Jogadores.Include("Time").Where(filtro).ToList();
        }

        public void Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
        }

        public List<Jogador> Listar()
        {
            return _context.Jogadores.Include("Time").ToList();
        }

        public void Remover(int id)
        {
            var jogador = _context.Jogadores.Find(id);
            _context.Jogadores.Remove(jogador);
        }
    }
}