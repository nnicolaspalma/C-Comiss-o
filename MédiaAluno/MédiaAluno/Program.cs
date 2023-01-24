using System;

namespace MédiaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media = 0;

            // exibiir no console
            Console.Write("Entre com a nota 1 : ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 2 : ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 3 : ");
            nota1 = double.Parse(Console.ReadLine());

            // processamento
            media = (nota1 + nota2 + nota3) / 3;

            // saida
            Console.Write("A media ponderada é: " + media);

            // espera entrada do teclado para encerrar
            Console.ReadKey();
        }

    }
}
