using System;

namespace RecebeNumeroOrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1;
            int meio = 0;
            int maior = 0;
            int menor = 0;
            int i;


            i = 0;
            while (i <= 2)
            {

                Console.Write("Digite seu " + (i + 1) + "º número");
                n1 = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maior = n1;
                    meio = n1;
                    menor = n1;
                }


                if (n1 > maior)
                {
                    maior = n1;
                }
                if (n1 < menor)
                {
                    menor = n1;
                }
                if (n1 > menor && n1 < maior)
                {
                    meio = n1;
                }
                i++;
            }
            Console.WriteLine(menor + ", " + meio + ", " + maior);

            Console.ReadKey();
        }
    }
}
