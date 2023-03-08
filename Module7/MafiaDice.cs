using System;
namespace Module7
{
    public class MafiaDice : Dice
    {
        public MafiaDice(int size) : base(size)
        { }

        public override void Roll() {
            for (int i = 0; i < 2; i++)
            {
                base.Roll();
                if (Eyes == 6)
                    return;

            }
        }
    }
}

