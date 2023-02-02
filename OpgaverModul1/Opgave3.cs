using System;
namespace OpgaverModul1
{
    public class Opgave3
    {
        public static void Run() {
            Console.WriteLine("Hello, kondital");
            Console.Write("Indtast distance: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast køn (Mand/Kvinde): ");
            string gender = Console.ReadLine();

            double kondi = ComputeKondi(distance, gender);

            int kondiInteger = Convert.ToInt32(kondi);
            Console.WriteLine("Dit kondital er: " + kondiInteger);      
        }

        private static double ComputeKondi(int distance, string? gender)
        {
            double kondi = 18.38 + (0.03301 * distance);

            if (gender == "k")
                kondi = kondi - 5.92;

            return kondi;
        }

        

    }
}

