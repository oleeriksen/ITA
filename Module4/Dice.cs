using System;
namespace Module4
{
    class Dice
    {
        private int eyes;

        private int size;

        Random r = new Random();


        public Dice(int size)
        {
            this.size = size;
            Roll();
        }

        public void Roll() {
           
            eyes = r.Next(1,size + 1);
        }

        public int Eyes { get { return eyes;  } }
    }
}

