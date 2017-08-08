using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.HelloWorld.UI.Model;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro
            var carro = new Carro("Fusca");

            //Instanciar um onibus
            var onibus = new Onibus("Caio")
            {
                //Modelo = "Caio",
                Linha = "Barra Funda"
            };

            //Criar uma lista de avião
            var lista = new List<Aviao>();
            lista.Add(new Aviao("A380"));
            lista.Add(new Aviao("14 Bis"));
            lista.Add(new Aviao("F18"));

            //Exibir os modelos dos aviões
            foreach (var item in lista)
            {
                Console.WriteLine(item.Modelo);
            }

            //Setar um modelo e placa
            carro.Modelo = "Fusca";
            carro.Placa = "EDS-9000";

            //Imprimir o modelo
            Console.WriteLine(carro.Modelo);
            Console.ReadLine();
        }
    }
}
