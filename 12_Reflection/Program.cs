using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12_Reflection.Modelo;

namespace _12_Reflection
{
    class Program
    {
        //Reflection - Criando log
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                nome = "Pedro Geromel",
                email = "geromel_gremio21@hotmail.com",
                senha = "506829"
            };
            //Gravar log de usuário
            Log.GravarUsuario(usuario);

            usuario.nome = "João Rafael Menezes";
            usuario.email = "joao@teleconsistemas.com.br";
            usuario.senha = "12345678bp";
            //Gravar log de usuário
            Log.GravarUsuario(usuario);

            Log.ApresentarLog();

            Console.WriteLine("Log criado com sucesso");
            Console.ReadKey();
        }
    }
}
