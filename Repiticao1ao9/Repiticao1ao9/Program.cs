using System;

namespace Repeticao1ao9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequencias = 8;
            int sequenciaMaxima = 9;

            for (int contadorSequencias = 1; contadorSequencias <= sequencias; contadorSequencias++)
            {
                string sequencia = "";
                for (int contadorSequencia = 1; contadorSequencia <= sequenciaMaxima; contadorSequencia++)
                {
                    sequencia += Convert.ToString(contadorSequencia);
                }

                Console.Write(sequencia);
            }
        }
    }
}
