using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    abstract class Veiculo
    {
        //Construtor
        public Veiculo(string modelo)
        {
            _modelo = modelo;
        }

        //Field (Atributo)
        private string _modelo;

        //Gets e Sets
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        //Propriedades
        public Cambio Cambio { get; set; }

        //Métodos
        public abstract void Frear();

        //virtual -> permite a sobrescrita do método
        public virtual void Acelerar()
        {
            Console.WriteLine("Veiculo acelerando");
        }
    }
}
