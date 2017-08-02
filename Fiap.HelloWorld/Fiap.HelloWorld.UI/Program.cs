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
            Carro carro = new Carro();
            //Setar um modelo e placa
            carro.Modelo = "Fusca";
            carro.Placa = "EDS-9000";

            //Imprimir o modelo
            Console.WriteLine(carro.Modelo);
            Console.ReadLine();
        }
    }
}
