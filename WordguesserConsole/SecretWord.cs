namespace WordguesserConsole
{
    /**
 * Represent a secret word. You can guess on a secret word, and you can
 * get it with not guessed chars as *'s.
 * @author oe
 */
    public class SecretWord
    {

        private string m_content;
        private bool[] guessed;
        private int noGuess = 0;
        private List<char> m_guessedChars;

        /**
         * 
         * @param content is the string hidden in the secret word
         */
        public SecretWord(string content)
        {
            m_content = content;
            guessed = new bool[content.Length];
            m_guessedChars = new List<char>();
        }

        /**
         * Make a guess. The secret word keeps the number of guesses done
         * @param ch the char guessed
         */
        public void Guess(char ch)
        {
            noGuess++;

            if (!m_guessedChars.Contains(ch))
                m_guessedChars.Add(ch);

            for (int i = 0; i < m_content.Length; i++)
                if (m_content[i] == ch)
                    guessed[i] = true;
        }

        /**
         * 
         * @return how many guesses done 
         */
        public int NoGuesses
        { get { return noGuess; } }

        /**
         * 
         * @return true if all char are guessed 
         */
        public bool IsGuessed
        {
            get
            {
                for (int i = 0; i < guessed.Length; i++)
                    if (!guessed[i]) return false;
                return true;
            }
        }

        public int Length
        {
            get { return m_content.Length; }
        }

        /**
         * 
         * @return the hidden string with a * on all positions
         * where a not guessed char occur.
         */
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < guessed.Length; i++)
            {
                if (m_content[i] == ' ')
                    res += ' ';
                else
                {
                    if (guessed[i])
                        res += m_content[i];
                    else
                        res += '*';
                }
            }
            return res;
        }


        public string UsedChars
        {
            get { return String.Join(", ", m_guessedChars); }
        }

    }
}

