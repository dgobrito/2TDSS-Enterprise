using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo05.MVC.Models
{
    public class Time
    {
        public int TimeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public bool Mundial { get; set; }

        //Relacionamentos
        public Tecnico Tecnico { get; set; }
        public int TecnicoId { get; set; }

        public List<Jogador> Jogadores { get; set; }

        public List<Campeonato> Campeonatos { get; set; }
    }
}