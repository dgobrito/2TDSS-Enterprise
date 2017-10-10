using Fiap.CorrecaoNac.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.CorrecaoNac.Persistencia
{
    public class NacContext : DbContext
    {
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
    }
}