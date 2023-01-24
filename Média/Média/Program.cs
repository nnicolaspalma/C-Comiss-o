using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;
            Console.WriteLine("Escreva a sua 1 nota");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva a sua 2 nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2) / 2;

            double notaDeCorte = 7;

            if (media >= notaDeCorte) {
                Console.WriteLine("Voce foi aprovado, sua média é: " + media);
            } else {
                Console.WriteLine("Voce foi reprovado, sua média é: " + media);
            }
        }
    }
}
