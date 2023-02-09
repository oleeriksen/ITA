namespace Module3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
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

