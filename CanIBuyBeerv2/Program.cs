
/*
 * om ålder > 17 OCH location == "krogen" OCH leg == "J" OCH promille < 1.0 JA
 * om ålder > 19 OCH location == "systemet" OCH leg == "J" OCH promille < 1.0 JA
*/
using System;

namespace CanIBuyBeerv2
{
    class Program
    {

        static bool CanIBuyBear(int age, string location, string legg, decimal promille)
        {
            if (legg.ToLower() != "j" || promille > 1.0m)
                return false;
            if (age > 17 && location.ToLower() == "krogen")
                return true;
            if (age > 19 && location.ToLower() == "systemet")
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Beer calculator 1.0");
            Console.Write("Hur gammal är du: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Location (systemet eller krogen): ");
            string location = Console.ReadLine();
            Console.Write("Har du legg med dig (J/N)");
            string legg = Console.ReadLine();
            Console.Write("Vilken promillehalt: ");
            decimal promille = Convert.ToDecimal(Console.ReadLine());

            if (CanIBuyBear(age, location, legg, promille)) Console.WriteLine("Du får köpa öl.");
            else Console.WriteLine("Du får inte köpa öl.");
        }


    }
}
