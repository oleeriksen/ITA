namespace WordguesserConsole
{
    public class App
    {
        RandomWords randomWords = new RandomWords();

        public void Run()
        {
            Console.WriteLine("Welcome to Word Guesser");
            Console.WriteLine("Hint: byer i omegnen af Aarhus");
            bool goOn = true;
            while (goOn)
            {
                OneGame(randomWords.GetNext());
                Console.WriteLine("Forsæt ? (J/N)");
                string answer = Console.ReadLine();
                goOn = answer.ToLower() == "j";
            }

        }

        /**
         * Execute one game
         * @param w - the word to guess.
         */
        private void OneGame(string w)
        {
            SecretWord sc = new SecretWord(w);
            Console.WriteLine("The length of the word is " + sc.Length);
            while ( ! sc.IsGuessed )
            {
                Console.Write(sc);
                Console.Write(" Used: [" + sc.UsedChars + "]. Enter: ");
                char input = Console.ReadLine()[0];
                sc.Guess(input);
            }

            Console.WriteLine("You guessed " + w + "! Using only " + sc.NoGuesses + " guesses!");
 
        }
    }
}

