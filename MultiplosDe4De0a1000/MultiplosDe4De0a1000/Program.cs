using System;

namespace MultiplosDe4De0a1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 1000;
            int multiple = 4;

            Console.WriteLine("Multiplos de 4 de 0 até 1000");

            for (int count = 0; count <= numbers; count++)
            {
                bool isMultiple = (count % multiple) == 0;

                if (isMultiple)
                {
                    Console.WriteLine(count);
                }
            }
        }
    }
}
