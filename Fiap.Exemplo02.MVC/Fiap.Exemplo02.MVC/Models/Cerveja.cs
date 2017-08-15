using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Cerveja
    {
        public string Nome { get; set; }
        public DateTime Validade { get; set; }
        public double Teor { get; set; }
    }
}