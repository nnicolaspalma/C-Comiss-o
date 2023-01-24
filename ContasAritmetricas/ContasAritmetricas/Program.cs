using System;

namespace ContasAritmetricas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res = 0;
            string op;

            inicio:
            Console.WriteLine("Numero 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Operação: [x. /. -, +]");
            op = Console.ReadLine();

            Console.WriteLine("Numero 2: ");
            num2 = int.Parse(Console.ReadLine());

            switch (op) // interuptor
            {
                case: "x";
                    res = num1 * num2;
                    break;
                case: "/";
                    res = num1 / num2;
                    break;
                case:
                    "-";
                    res = num1 - num2;
                    break;
                case:
                    "+";
                    res = num1 + num2;
                    break;
                default:
                    Console.WriteLine(" Ocorreus um Erro!");
                    break;

                    Console.WriteLine(num1 + " " + op " " + num2 + " = " + res);

                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;
            }
        }
    }
}
