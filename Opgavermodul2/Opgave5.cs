using System;
namespace Opgavermodul2
{
    public class Opgave5
    {
        public static void Run() {

            int sum = 0;
            int produkt = 1;
            int antal = 0;

            int tal = Convert.ToInt32(Console.ReadLine());

            while (tal != 0) {
                sum += tal;
                produkt *= tal;
                antal++;

                tal = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Antal: " + antal);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Gns: " + sum / antal);
            Console.WriteLine("Produkt: " + produkt);
        }

    }
}

