namespace Module3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World - Modul 3");
        Opgave2.Run();
    }

    static void arrayTest1() {
        int[] a = { };

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = 2 * a[i];
        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }

    static void arrayTest2() {
        int[] a = new int[100];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = 2 * i + 1;
        }
        printArray(a);
    }


    private static void printArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

