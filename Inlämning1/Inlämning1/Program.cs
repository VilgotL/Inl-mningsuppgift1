using System;

namespace Inlämning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Tal = rnd.Next(1, 101);
            int AntalGissningar;
            int Gissning = 0;
            Console.WriteLine("Gissa talet: ");
            for (AntalGissningar = 0; Gissning != Tal; AntalGissningar++)
            {
                Gissning = int.Parse(Console.ReadLine());
                if (Gissning > Tal)
                {
                    Console.WriteLine("Du gissade för högt.");
                }
                else if (Gissning < Tal)
                {
                    Console.WriteLine("Du gissade för lågt.");
                }
            }
            Console.WriteLine("Du gissade rätt efter "+AntalGissningar+" försök.");
        }   
    }
}
