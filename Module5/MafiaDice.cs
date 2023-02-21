using System;
namespace Module5
{
    public class MafiaDice : Dice
    {
        public MafiaDice() : base(6)
        {
        }

        public override void Roll() {
           base.Roll();
            int i = 0;
            while (Eyes < 6 && i++ < 4)
                base.Roll();
        }
    }
}

