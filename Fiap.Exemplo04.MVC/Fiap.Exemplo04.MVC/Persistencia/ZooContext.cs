using Fiap.Exemplo04.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Persistencia
{
    public class ZooContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
    }
}