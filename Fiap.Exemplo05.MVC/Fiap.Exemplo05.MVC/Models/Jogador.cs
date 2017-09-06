using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo05.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }

        //Relacionamentos
        public Time Time { get; set; }
        public int TimeId { get; set; }
    }
}