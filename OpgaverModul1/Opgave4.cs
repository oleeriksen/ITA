using System;
namespace OpgaverModul1
{
    public class Opgave4
    {
        public static void Run()
        {
            Console.WriteLine("Hello, kondital");
            Console.Write("Indtast distance: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast køn: (Mand/Kvinde");
            string gender = Console.ReadLine();
            Console.Write("Indtast alder: ");
            int age = Convert.ToInt32(Console.ReadLine());

            double kondi = ComputeKondi(distance, gender);

            Console.WriteLine("Dit kondital er: " + ((int)kondi));

            string classifier = ComputeClassifier(gender, kondi, age);

            Console.WriteLine("Det vurderer vi til at være " + classifier);
        }

        private static double ComputeKondi(int distance, string? gender)
        {
            double kondi = 18.38 + (0.03301 * distance);

            if (gender == "k")
                kondi = kondi - 5.92;

            return kondi;
        }

        static private string ComputeClassifier(string gender, double kondi, int age)
        {
            if (gender == "m")
                return ComputeClassifierForMen(kondi, age);
            else
                return ComputeClassifierForWomen(kondi, age);
        }

        private static string ComputeClassifierForWomen(double kondi, int age)
        {
            if (5 <= age && age <= 14)
            {
                if (kondi < 34) return "Meget Lavt";
                if (35 <= kondi && kondi <= 39) return "Lavt";
                if (40 <= kondi && kondi <= 47) return "Middel";
                if (48 <= kondi && kondi <= 51) return "Højt";
                if (52 <= kondi && kondi <= 52) return "Meget højt";
                return "I top";
            }

            if (15 <= age && age <= 19)
            {
                if (kondi < 29) return "Meget Lavt";
                if (29 <= kondi && kondi <= 34) return "Lavt";
                if (35 <= kondi && kondi <= 43) return "Middel";
                if (44 <= kondi && kondi <= 48) return "Højt";
                if (49 <= kondi && kondi <= 49) return "Meget højt";
                return "I top";
            }

            return "kan ikke bestemmes";
        }

        private static string ComputeClassifierForMen(double kondi, int age)
        {
            if (5 <= age && age <= 14)
            {
                if (kondi < 38) return "Meget Lavt";
                if (39 <= kondi && kondi <= 43) return "Lavt";
                if (44 <= kondi && kondi <= 51) return "Middel";
                if (52 <= kondi && kondi <= 56) return "Højt";
                if (57 <= kondi && kondi <= 59) return "Meget højt";
                return "I top";
            }

            if (15 <= age && age <= 19)
            {
                if (kondi < 43) return "Meget Lavt";
                if (44 <= kondi && kondi <= 48) return "Lavt";
                if (49 <= kondi && kondi <= 56) return "Middel";
                if (57 <= kondi && kondi <= 61) return "Højt";
                if (62 <= kondi && kondi <= 62) return "Meget højt";
                return "I top";
            }

            return "kan ikke bestemmes";
        }
    }
}

