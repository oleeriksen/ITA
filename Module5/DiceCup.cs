using System;
namespace Module5
{
    public class DiceCup
    {
        // state
        private List<Dice> mineTerninger;

        public DiceCup(int antalTerninger)
        {
            mineTerninger = new List<Dice>();
            for (int i = 0; i < antalTerninger; i++)
            {
                mineTerninger.Add(new Dice(6));
            }
        }
        // metoder
        public void Shake()
        {
            foreach (Dice dice in mineTerninger)
                dice.Roll();
        }

        public int[] Eyes()
        {
            int[] resultat = new int[mineTerninger.Count];
            for (int i = 0; i < mineTerninger.Count; i++)
            {
                resultat[i] = mineTerninger[i].Eyes;
            }
            return resultat;
        }

        public bool IsMeyer() {
            //if (Eyes()[0] == 1 && Eyes()[1] == 2)
            //    return true;
            return false;
            //return Eyes + d2.Eyes == 3;
        }
    }
}

