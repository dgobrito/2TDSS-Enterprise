using Fiap.Exemplo05.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo05.MVC.Repositories
{
    public interface IJogadorRepository
    {
        void Cadastrar(Jogador jogador);
        void Alterar(Jogador jogador);
        void Remover(int id);
        Jogador Buscar(int id);
        List<Jogador> Listar();
        List<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro);
    }
}
