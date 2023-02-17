using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicoline
{
    class DiceCup
    {
        // tilstand 
        private Dice Dice1;
        private Dice Dice2; 
      
        // opretter object DiceCup som indeholder to dices.
        public DiceCup()
        {
            Dice1 = new Dice(6);
            Dice2 = new Dice(6); 

        }
        
        // metode
        public void Shake()
        {
            Dice1.Roll();
            Dice2.Roll();
        }

        public int[] Eyes()
        {
            if (Dice1.Eyes > Dice2.Eyes) return new int[] { Dice1.Eyes, Dice2.Eyes };
            return new int[] {Dice2.Eyes, Dice1.Eyes};
        }

        
        
      
    }   

}



