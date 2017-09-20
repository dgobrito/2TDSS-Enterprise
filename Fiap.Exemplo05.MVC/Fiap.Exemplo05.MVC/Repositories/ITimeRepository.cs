using Fiap.Exemplo05.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo05.MVC.Repositories
{
    public interface ITimeRepository
    {
        void Cadastrar(Time time);
        void Alterar(Time time);
        void Remover(int id);
        Time Buscar(int id);
        List<Time> Listar();
        List<Time> BuscarPor(Expression<Func<Time, bool>> filtro);
    }
}
