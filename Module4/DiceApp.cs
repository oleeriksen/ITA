using System;
namespace Module4
{
    public class DiceApp
    {
        public static void Run() {
            Dice d = new Dice(8);
           
            for (int i = 0; i < 20; i++)
            {
                d.Roll();
                Console.WriteLine("Øjne: " + d.Eyes);
            }
        }
    }
}

