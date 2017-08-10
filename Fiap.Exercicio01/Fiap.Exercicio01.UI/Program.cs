using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente()
            {
                Agencia = 1231,
                Numero = 456,
                DataAbertura = DateTime.Now,
                //Saldo = 1000,
                TipoConta = Model.TipoConta.Comum
            };
            ContaPoupanca cp = new ContaPoupanca(0.06m) //m -> decimal
            {
                Agencia = 1231,
                Numero = 444,
                DataAbertura = DateTime.Now,
                //Saldo = 500
            };
            cp.Depositar(500);
            cp.Retirar(40);
            Console.WriteLine(cp.Saldo);
            Console.WriteLine("Rendimento: " + cp.CalcularRetornoInvestimento());
            Console.ReadLine(); //Para o console...
        }
    }
}
