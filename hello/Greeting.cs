using System;
namespace hello
{
	public class Greeting
	{
		public static void WriteGreeting(string name, int hour) {
            if (hour <= 10)
            {
                Console.WriteLine("Good morning " + name + ", have a nice day");
            }
            else
            if (hour <= 17)
            {
                Console.WriteLine("Good afternoon " + name + ", have a nice day");

            }
            else
            if (hour <= 22)
            {
                Console.WriteLine("Good Evening " + name + ", have a nice day");

            }
            else
            {
                Console.WriteLine("Good night " + name + ", hope you had a nice day");
            }
        }
	}
}

