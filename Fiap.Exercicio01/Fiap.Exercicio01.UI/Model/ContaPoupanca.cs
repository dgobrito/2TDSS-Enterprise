using Fiap.Exercicio01.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }

        private readonly decimal _rendimento;

        public ContaPoupanca(decimal rend)
        {
            _rendimento = rend;
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

     

        public override void Retirar(decimal valor)
        {
            if (Saldo < Taxa + valor)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= Taxa + valor;
        }
    }
}
