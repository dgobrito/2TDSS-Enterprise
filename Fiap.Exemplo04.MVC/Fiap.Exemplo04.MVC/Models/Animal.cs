using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public string Especie { get; set; }

        public bool Carnivoro { get; set; }

        [Required]
        public DateTime DataEntrada { get; set; }
    }
}