using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo05.MVC.Models
{
    public class Tecnico
    {
        public int TecnicoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}