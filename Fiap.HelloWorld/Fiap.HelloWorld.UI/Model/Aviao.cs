using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Aviao : Veiculo, IAereo
    {
        public Aviao(string modelo) : base(modelo)
        {
        }

        public override void Frear()
        {
            Console.WriteLine("Acionar os flaps");
        }

        public void Voar()
        {
            Console.WriteLine("Ligar as turbinas");
        }
    }
}
