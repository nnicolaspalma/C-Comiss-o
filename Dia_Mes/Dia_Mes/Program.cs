using System;

namespace Dia_Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            Console.WriteLine(date1);

            var date2 = DateTime.Now;
            var date3 = DateTime.UtcNow;
            var date4 = DateTime.Today;
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);

            var Tomorrow = date2.AddDays(1);
            Console.WriteLine(Tomorrow);

            Console.WriteLine(date2.ToLongDateString());
            Console.WriteLine(date2.ToShortDateString());
            Console.WriteLine(date2.ToLongDateString());
            Console.WriteLine(date2.ToShortDateString());

            Console.WriteLine(date2.ToString());
            Console.WriteLine(date2.ToString("yy-MM-DD"));
        }
    }
}
