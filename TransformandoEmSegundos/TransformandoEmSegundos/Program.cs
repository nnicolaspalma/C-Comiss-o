using System;

namespace TransformandoEmSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o primeiro número em segundos");
            int secTotal = Convert.ToInt32(Console.ReadLine());

            int dias = secTotal / (60 * 60 * 24);
            int secRestantes = secTotal % (60 * 60 * 24);

            int hr = secRestantes / (60 * 60);
            secRestantes = secRestantes % (60 * 60);

            int minutos = secRestantes / 60;
            int sec = secRestantes % 60;

            Console.WriteLine(dias + "dias", "horas", +minutos + "minutos", sec + "segundos");

            Console.ReadLine();
        }
    }
}
