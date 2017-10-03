using Fiap.Revisao2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap.Revisao2.Repositories
{
    public interface IAtletaRepository
    {
        void Cadastrar(Atleta atleta);
        void Remover(int id);
        void Atualizar(Atleta atleta);
        Atleta Buscar(int id);
        IList<Atleta> Listar();
        IList<Atleta> BuscarPor(Expression<Func<Atleta,bool>> filtro);
    }
}