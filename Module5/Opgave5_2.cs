using System;
namespace Module5
{
    public class Opgave5_2
    {
        public static void Run() {
            DiceCup dc = new DiceCup();

            dc.SetDices(new Dice(6), new MafiaDice());

            for (int i = 0; i < 10; i++)
            {
                dc.Shake();
                int[] result = dc.Eyes();
                Console.WriteLine(result[0] + " " + result[1]);

            }
        }
    }
}

