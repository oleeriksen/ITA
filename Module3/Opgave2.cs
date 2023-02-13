using System;
namespace Module3
{
	public class Opgave2
	{
        public static void Run()
        {
            int amount = ReadInt("Indtast antal tal: ");
            int[] data = new int[amount];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = ReadInt("Indtast tal: ");
            }
            int[] grades = { -3, 0, 2, 4, 7, 10, 12 };
            foreach (int grade in grades) {
                int count = Count(data, grade);
                Console.WriteLine("Karakter: " + grade + ", antal: " + count);
            }
            Console.WriteLine("Gns: " + Average(data));
            

        }

        static int ReadInt(string preText)
        {
            Console.Write(preText);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Count(int[] data, int key) {
            int result = 0;
            foreach (int value in data) {
                if (value == key)
                    result++;
            }
            return result;
        }

        static double Average(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum / a.Length;
        }
    }
}

