using System;

namespace PINValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpurandom = rnd.Next(1, 11);
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta number");
                int Userguess = Convert.ToInt32(Console.ReadLine());
                if (cpurandom == Userguess)
                {
                    Console.WriteLine("Tubli! Oled mängu võitnud");
                    break;
                }
                else
                {
                    Console.WriteLine($"Vale number, {3 - i} Proovi alles");
                    i++; //i = i + 1;

                }
            }
            if (i == 3)
            {
                Console.WriteLine("Oled mängu kaotanud");
            }
        }
    }
}
