using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Reflection.Modelo
{
    class Carro : ICloneable
    {
        public string marca { get; set; }
        public string modelo { get; set; }

        public object Clone()
        {
            return new Carro() { marca = this.marca, modelo = this.modelo };
        }
    }
}
