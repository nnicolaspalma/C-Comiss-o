using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor atual do salario");
            double salarioAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o aumento em %");
            double aumentoEmPorcentagem = double.Parse(Console.ReadLine());

            double aumentoSalario = salarioAtual * aumentoEmPorcentagem / 100;

            double novoSalario = aumentoSalario + salarioAtual;

            Console.WriteLine(String.Format("Salario atual {0}, novo salario {1}", salarioAtual, novoSalario));
        }
    }
}
