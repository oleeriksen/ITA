using System;
namespace Module5
{
    public class Opgave5_2
    {
        public static void Run() {
            DiceCup dc = new DiceCup(3);
            /* Lav om i Dicecup så den kan indeholde et vilkårligt 
             * antal terninger (af str 6). Dette antal gøres til 
             * parameter i klassens konstruktør */

     

            for (int i = 0; i < 10; i++)
            {
                dc.Shake();
                int[] result = dc.Eyes();
                Console.WriteLine(result[0] + " " + result[1] + " " + result[2]);
            }
        }
    }
}

