using Fiap.Revisao2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao2.Repositories
{
    public interface IEsporteRepository
    {
        void Cadastrar(Esporte esporte);
        List<Esporte> Listar();
    }
}