using System;

namespace PararNumeroInformado0
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaTotal = 0;

            Console.WriteLine("Informe um numero para somar");
            double numeroInformado = Double.Parse(Console.ReadLine());

            while (numeroInformado != 0)
            {
                somaTotal += numeroInformado;

                Console.WriteLine("Informe mais um numero para somar");
                numeroInformado = Double.Parse(Console.ReadLine());

                if (numeroInformado == 0)
                {
                    Console.WriteLine("A soma total é: " + somaTotal);
                }
            }
        }
    }
}
