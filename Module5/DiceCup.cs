using System;
namespace Module5
{
    public class DiceCup
    {
        private Dice d1, d2;

        public DiceCup()
        {
            d1 = new Dice(6);
            d2 = new Dice(6);

        }

        public void Shake()
        {
            d1.Roll();
            d2.Roll();

        }

        public int[] Eyes
        {
            get
            {
                if (d1.Eyes < d2.Eyes)
                    return new int[] { d1.Eyes, d2.Eyes };
                return new int[] { d2.Eyes, d1.Eyes };
            }
        }
    }
}

