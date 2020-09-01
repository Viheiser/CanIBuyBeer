using System;

namespace CanIBuyBeer
{
    class Program
    {

        static bool CanIBuyBeer(int age, string location, string legg, decimal promille)
        {
            if (legg.ToLower() != "j" || promille > 1.0m)
                return false;
            if (age > 15 && location.ToLower() == "skola")
                return true;
            if (age > 17 && location.ToLower() == "krogen")
                return true;
            if (age > 19 && location.ToLower() == "systemet")
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Beer calculator 1.01");
            Console.Write("Hur gammal är du: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Location (systemet eller krogen): ");
            string location = Console.ReadLine();
            Console.Write("Har du legg med dig (J/N)");
            string legg = Console.ReadLine();
            Console.Write("Vilken promillehalt: ");
            decimal promille = Convert.ToDecimal(Console.ReadLine());

            if (CanIBuyBeer(age, location, legg, promille)) Console.WriteLine("Du får köpa öl.");
            else Console.WriteLine("Du får INTE köpa öl.");
        }


    }
}
