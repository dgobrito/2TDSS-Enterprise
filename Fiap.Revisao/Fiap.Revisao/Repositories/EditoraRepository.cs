using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Revisao.Models;
using Fiap.Revisao.Persistencia;

namespace Fiap.Revisao.Repositories
{
    public class EditoraRepository : IEditoraRepository
    {
        private BibliotecaContext _context;

        public EditoraRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public void Cadastrar(Editora editora)
        {
            _context.Editoras.Add(editora);
        }

        public List<Editora> Listar()
        {
            return _context.Editoras.ToList();
        }
    }
}