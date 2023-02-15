using System;
namespace Module4
{
    class Dice
    {
        private int eyes;

        private int size;

       

        public Dice(int size)
        {
            this.size = size;
            Roll();
        }

        public void Roll() {
            Random r = new Random();
            eyes = r.Next(1,size + 1);
        }

        public int Eyes { get { return eyes;  } }
    }
}

