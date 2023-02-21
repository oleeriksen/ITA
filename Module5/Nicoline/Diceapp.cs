using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicoline
{
    class Diceapp
    {
        public static void Run()
        {
            DiceCup dc = new DiceCup();


            for (int i = 0; i < 20; i++)
            {
                dc.Shake();
                int[] result = dc.Eyes();
                Console.WriteLine(result[0] + " " + result[1]);
            }
        }
       
    }



}


