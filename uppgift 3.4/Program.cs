using System;


namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är låten?");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sekunder är låten?");
            int sekunder = int.Parse(Console.ReadLine());

            int totalaSekunder = minuter * 60 + sekunder;
            int mingräns = 2 * 60 + 45;
            int maxgräns = 4 * 60 + 20;

            if (totalaSekunder >= mingräns && totalaSekunder <= maxgräns)
            {
                Console.WriteLine("Låten får spelas");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Låten får nt spelas");
                Console.ReadKey();
            }
        }
    }
}
