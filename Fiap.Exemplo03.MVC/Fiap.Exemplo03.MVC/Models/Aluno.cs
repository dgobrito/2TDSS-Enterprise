using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.MVC.Models
{
    public class Aluno
    {
        public string  Nome { get; set; }
        public int Rm { get; set; }

        [Display(Name ="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public bool Matriculado { get; set; }
        public string Curso { get; set; }
    }
}