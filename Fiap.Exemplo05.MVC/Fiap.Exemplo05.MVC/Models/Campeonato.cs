using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo05.MVC.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }

        //Relacionamento
        public List<Time> Times { get; set; }
    }
}