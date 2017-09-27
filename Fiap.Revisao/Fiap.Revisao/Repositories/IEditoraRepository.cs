using Fiap.Revisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Repositories
{
    public interface IEditoraRepository
    {
        List<Editora> Listar();
        void Cadastrar(Editora editora);
    }
}