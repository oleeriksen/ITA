using System;
namespace Module7
{
    public class DiceCup
    {
        // state
        private List<Dice> mineTerninger;

        public DiceCup()
        {
            mineTerninger = new List<Dice>();
         
        }
        // metoder

        public void AddDice(Dice d) {
            mineTerninger.Add(d);

        }
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

    
    }
}

