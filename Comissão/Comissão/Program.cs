using System;

namespace Comissão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do produto 1");
            double produto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do produto 2");
            double produto2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da comissão em %");
            double valorcomissão = double.Parse(Console.ReadLine());

            double valortotal = produto1 + produto2;

            double valorganho = valortotal * valorcomissão / 100;

            double valordesconto = valortotal;

            Console.WriteLine(String.Format("Valor total {0}, valor ganho na comissão {1}", valordesconto, valorganho));
        }
    }
}
