using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Revisao.Models;
using Fiap.Revisao.Persistencia;
using System.Data.Entity;

namespace Fiap.Revisao.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private BibliotecaContext _context;

        public LivroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public void Alterar(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
        }

        public Livro Buscar(int id)
        {
            return _context.Livros.Find(id);
        }

        public List<Livro> BuscarPor(Expression<Func<Livro, bool>> filtro)
        {
            return _context.Livros.Include("Editora").Where(filtro).ToList();
        }

        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
        }

        public List<Livro> Listar()
        {
            return _context.Livros.Include("Editora").ToList();
        }

        public void Remover(int id)
        {
            var livro = Buscar(id);
            _context.Livros.Remove(livro);
        }
    }
}