using System;
namespace Module4
{
    public class DiceApp
    {
        public static void Run() {
        
           
            for (int i = 0; i < 20; i++)
            {
                Dice d = new Dice(6);
                d.Roll();
                Console.WriteLine("Øjne: " + d.Eyes);
            }
            Console.WriteLine("Antal terninger: " + Dice.countDice);
        }
    }
}

