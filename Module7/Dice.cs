using System;
namespace Module7
{
    public class Dice
    {
     

        private int eyes;

        private int size;

        private Random r = new Random();


        public Dice(int size)
        {
            this.size = size;
            Roll();
        }

        public virtual void Roll() {
           
            eyes = r.Next(1,size + 1);
        }

        public int Eyes { get { return eyes;  } }
    }
}

