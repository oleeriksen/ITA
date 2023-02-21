using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicoline
{
    class Dice
    {
        // tilstands attributter
        private int eyes;
        private int size;
        private Random r;

        public Dice(int size)
        {
            this.size = size;
            r = new Random();
            Roll();
        }

        public int Roll()
        {
            eyes = r.Next(1, size + 1);
            return eyes;
        }

        public int Eyes { get { return eyes; } }
    }
}
