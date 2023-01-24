using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numero_par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("\n\tDigite um número inteiro:");
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("\nO número é par");
            }
            else
            {
                Console.WriteLine("\nO número é impar");
            }
        }
    }
}