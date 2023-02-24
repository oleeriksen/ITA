using System;
namespace Module7
{
    public class Opgave7_1
    {
        public static void Run() {
            DiceCup dc = new DiceCup();

            dc.AddDice(new Dice(6));
            dc.AddDice(new MafiaDice(6));
            dc.AddDice(new Dice(6));
            dc.AddDice(new MafiaDice(6));

            // bruges til at tælle antal 6'ere for de 4 terninger
            int[] count = new int[4];

            for (int i = 0; i < 100; i++){
                dc.Shake();
                int[] result = dc.Eyes();
                Console.WriteLine($" {result[0]}  {result[1]}  {result[2]}  {result[3]}");


                for (int idx = 0; idx < 4; idx++)
                    if (result[idx] == 6) count[idx]++;
            }
            Console.WriteLine($"{count[0]} {count[1]} {count[2]} {count[3]}");



        }
    }
}

