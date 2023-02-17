using System;
namespace Module5
{
    public class Opgave5_2
    {
        public static void Run() {
            DiceCup dc = new DiceCup();

            for (int i = 0; i < 10; i++)
            {
                dc.Shake();
                Console.WriteLine(dc.Eyes[0] + " " + dc.Eyes[1]);

            }
        }
    }
}

