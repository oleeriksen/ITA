using System;
namespace Module3
{
    public class Opgave1
    {
        public static void Run() {
            int amount = ReadInt("Indtast antal tal: ");
            int[] data = new int[amount];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = ReadInt("Indtast tal: ");
            }
            Console.WriteLine("Tallenes gennemsit: " + Average(data));
        }

        static int ReadInt(string preText) {
            Console.Write(preText);
            return Convert.ToInt32(Console.ReadLine());
        }

        static double Average(int[] a) {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum/a.Length;
        }
    }
}

