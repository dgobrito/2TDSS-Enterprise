using Fiap.Exemplo05.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo05.MVC.Persistencia
{
    public class TimeContext : DbContext
    {
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
    }
}