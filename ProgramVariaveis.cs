using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Lain_year_release = 1998;
            string Lain_month_release = "July";
            float IMDB_rating = 8.1f;
            bool All_love_Lain = true;

            Console.WriteLine(Lain_year_release);
            Console.WriteLine(Lain_month_release);
            Console.WriteLine(IMDB_rating);
            Console.WriteLine(All_love_Lain);
            
          //Modificando variavel 
            IMDB_rating = 10.00f;
            Console.WriteLine(IMDB_rating);

            Console.ReadLine();
        }
    }
}
