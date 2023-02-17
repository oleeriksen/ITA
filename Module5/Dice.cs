using System;
namespace Module5
{
    class Dice
    {
        public static int countDice = 0;

        private int eyes;

        private int size;

        Random r = new Random();


        public Dice(int size)
        {
            this.size = size;
            Roll();
            countDice++;
        }

        public void Roll() {
           
            eyes = r.Next(1,size + 1);
        }

        public int Eyes { get { return eyes;  } }
    }
}

