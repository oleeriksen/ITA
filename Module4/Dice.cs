using System;
namespace Module4
{
    class Dice
    {
        private int eyes;

        private int size;

        private Random r;

        public Dice(int size)
        {
            this.size = size;
            r = new Random();
            Roll();
        }

        public void Roll() { 
            eyes = r.Next(1,size + 1);
        }

        public int Eyes { get { return eyes;  } }
    }
}

