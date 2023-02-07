using System;
namespace Opgavermodul2
{
    public class Opgave3
    {
        /* En koding af følgende algoritme:
         * 
         * 1. Fyld så mange 5'ere på du kan
         * 2. Hvis rest (det der mangler) er 0, så er du færdig
         * 3. Hvis rest = 1, så fjern 1 5'er og sæt 2 3'ere på
         * 4. Hvis rest = 2, så fjern 2 5'ere og sæt 4 3'ere på
         * 5. Hvis rest = 3, så sæt 1 3'er på
         * 6. Hvis rest = 4, så fjern 1 5'er og sæt 3 3'ere på.
        */

        public static void Run() {
            Console.Write("Indtast beløb: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int a5 = Stamps5(amount);
            int a3 = Stamps3(amount);

            Console.WriteLine("3: " + a3 + " stk");
            Console.WriteLine("5: " + a5 + " stk");

            if (amount == 3 * a3 + 5 * a5)
                Console.WriteLine("Det passer!!!");
            else
                Console.WriteLine("Det stemmer ikke!!!!");


        }

        private static int Stamps5(int amount) {
            int antal5 = amount / 5;
            int rest = amount % 5;

            switch (rest) {
                case 1: antal5 -= 1;
                    break;
                case 2: antal5 -= 2;
                    break;
                case 3:
                    break;
                case 4: antal5 -= 1;
                    break;
            }
            return antal5;
        }

        private static int Stamps3(int amount)
        {
            int antal5 = amount / 5;
            int antal3 = 0;
            int rest = amount % 5;

            switch (rest)
            {
                case 1:
                    antal5 -= 1;
                    antal3 = 2;
                    break;
                case 2:
                    antal5 -= 2;
                    antal3 = 4;
                    break;
                case 3:
                    antal3 = 1;
                    break;
                case 4:
                    antal5 -= 1;
                    antal3 = 3;
                    break;
            }
            return antal3;
        }
    }
}

