using Fiap.Revisao.Persistencia;
using Fiap.Revisao.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Units
{
    public class UnitOfWork : IDisposable
    {
        private BibliotecaContext _context = new BibliotecaContext();

        private ILivroRepository _livroRepository;

        public ILivroRepository LivroRepository
        {
            get
            {
                if (_livroRepository == null)
                {
                    _livroRepository = new LivroRepository(_context);
                }
                return _livroRepository;
            }
        }

        private IEditoraRepository _editoraRepository;

        public IEditoraRepository EditoraRepository
        {
            get
            {
                if (_editoraRepository == null)
                {
                    _editoraRepository = new EditoraRepository(_context);
                }
                return _editoraRepository;
            }

        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}