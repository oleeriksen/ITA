using System;
namespace Module4
{
    public class Opgave1
    {
        public static void Run() {
            int N = 6000000;
            int[] data = new int[N];

            Dice d = new Dice(6);

            for (int i = 0; i < N; i++)
            {
                d.Roll();
                data[i] = d.Eyes;
            }

            for (int eyes = 1; eyes <= 6; eyes++)
            {
                int antal = Count(data, eyes);
                Console.WriteLine("Eyes: " + eyes + ", antal: " + antal);
            }

        }

        static int Count(int[] data, int key)
        {
            int result = 0;
            foreach (int value in data)
            {
                if (value == key)
                    result++;
            }
            return result;
        }
    }
}

