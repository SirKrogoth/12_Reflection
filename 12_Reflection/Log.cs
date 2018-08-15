using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12_Reflection.Modelo;

namespace _12_Reflection
{
    class Log
    {
        public static List<Usuario> usuarios = new List<Usuario>();        
        public static void GravarUsuario(Usuario usuario)
        {
            usuarios.Add((Usuario)usuario.Clone());
        }

        public static List<Carro> carros = new List<Carro>();
        public static void GravarCarro(Carro carro)
        {
            carros.Add((Carro)carro.Clone());
        }

        public static void ApresentarLog()
        {
            foreach(Usuario usuario in usuarios)
            {
                Console.WriteLine("Nome: {0}, Email: {1}, Senha: {2};\n", usuario.nome, usuario.email, usuario.senha);
            }

            foreach (Carro carro in carros)
            {
                Console.WriteLine("Marca: {0}, Modelo: {1};\n", carro.marca, carro.modelo);
            }
        }
    }
}
