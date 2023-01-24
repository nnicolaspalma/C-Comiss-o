using System;

namespace Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do produto 1");
            double produto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do produto 2");
            double produto2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do desconto em %");
            double valorDescontoEmPorcentagem = double.Parse(Console.ReadLine());

            double valorSemDesconto = produto1 + produto2;

            double valorDesconto = valorSemDesconto * valorDescontoEmPorcentagem / 100;

            double valorComDesconto = valorSemDesconto - valorDesconto;

            Console.WriteLine(String.Format("Valor com desconto {0}, valor do desconto {1}", valorComDesconto, valorDesconto));
        }
    }
}
