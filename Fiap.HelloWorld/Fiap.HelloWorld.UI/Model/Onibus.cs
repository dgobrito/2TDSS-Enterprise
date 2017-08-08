using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Onibus : Veiculo
    {
        public string Linha { get; set; }

        public Onibus(string modelo):base(modelo)
        {            
        }

        public override void Frear()
        {
            Console.WriteLine("Onibus freiando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando.... ");
        }
    }
}
