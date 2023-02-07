using System;
namespace Opgavermodul2
{
    public class Opgave6
    {
        public static void Run() {
            int tal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPowerOf2(tal));
            
        }

        private static Boolean IsPowerOf2(int n) {
            int k = 1;
            while (k < n)
            {
                k = k * 2;
            }
            if (k == n)
                return true;
            return false;
        }
    }
}

