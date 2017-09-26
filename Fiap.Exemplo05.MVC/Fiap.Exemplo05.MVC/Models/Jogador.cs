using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo05.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Range(1,99)]
        public int Numero { get; set; }

        //Relacionamentos
        public Time Time { get; set; }

        public int TimeId { get; set; }
    }
}