using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Reflection.Modelo
{
    class Usuario :ICloneable
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public object Clone()
        {
            return new Usuario() { nome = this.nome, email = this.email, senha = this.senha };
        }
    }
}
