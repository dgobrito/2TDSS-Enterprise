using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Banco
    {
        public int Agencia { get; set; }
        public string Nome { get; set; }
        public DateTime DataAbertura { get; set; }
    }
}