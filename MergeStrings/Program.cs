using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la primera palabra");
            string s1 = Console.ReadLine();
            Console.WriteLine("Digite la segunda palabra");
            string s2 = Console.ReadLine();
            Console.WriteLine("las dos palabras son {0} y {1}", s1, s2);
            StringHandler stringHandler = new StringHandler(s1, s2);
            Console.WriteLine("El resultado es: ");
            Console.WriteLine(stringHandler.GetMergedString());
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }
    }
}
