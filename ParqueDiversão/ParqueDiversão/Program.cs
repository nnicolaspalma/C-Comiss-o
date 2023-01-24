using System;

namespace ParqueDiversao
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Qual a sua altura?");
            n1 = Convert.ToDouble(Console.ReadLine());

            double altura = 1.5;
            if (n1 >= altura) {
                Console.WriteLine("Podera ir ao brinquedo");
             } else {
                Console.WriteLine("Não podera ir ao brinquedo");
            }
        }           
    }
}
