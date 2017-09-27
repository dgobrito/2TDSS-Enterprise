using Fiap.Revisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap.Revisao.Repositories
{
    public interface ILivroRepository
    {
        void Cadastrar(Livro livro);
        void Alterar(Livro livro);
        void Remover(int id);
        Livro Buscar(int id);
        List<Livro> Listar();
        List<Livro> BuscarPor(Expression<Func<Livro,bool>> filtro);
    }
}