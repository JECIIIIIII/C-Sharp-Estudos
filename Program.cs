using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_do_usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Confira se esta correto! Se sim, aperte enter para confirmar e encerrar o programa!");
            Console.WriteLine(nome);
            Console.ReadLine();


        }
    }
}
