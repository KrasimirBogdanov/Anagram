
namespace Anagram
{
    public partial class Anagram : Form
    {
        private String[] wordList;
        List<string> matchedWordsListFinal;
        public Anagram()
        {
            InitializeComponent();
            this.wordList = new String[] { };
            this.matchedWordsListFinal = new List<string>();

        }

        public int LoadWords()
        {
            this.wordList = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\WordList.txt").Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return this.wordList.Length;
        }
        public int FillMatchedWords(int totalWords)
        {
            String inputString = inputWordBox.Text;
            int inputStringLength = inputString.Length;

            char[] inputStringChars = inputString.ToUpper().ToCharArray();
            Array.Sort(inputStringChars);

            String sortedInputString = new string(inputStringChars);
            for (int m = 0; m < totalWords; m++)
            {
                String comparedWord = this.wordList[m];

                if (inputStringLength == comparedWord.Length)
                {
                    char[] comparedWordChars = comparedWord.ToUpper().ToCharArray();
                    Array.Sort(comparedWordChars);
                    String sortedComparedWord = new String(comparedWordChars);
                    if (sortedInputString != sortedComparedWord)
                        continue;
                    matchedWordsListFinal.Add(comparedWord);

                }
                else
                {
                    for (int n = 0; n < totalWords; n++)
                    {
                        int nextWordOfListLength = this.wordList[n].Length;
                        int concatenatedWordsLength = comparedWord.Length + nextWordOfListLength;

                        //if (nextWordOfListLength == 0 || comparedWord.Length == 0)
                          //  continue;
                        if (inputStringLength != concatenatedWordsLength)
                            continue;
                        char[] comparedWordChar = comparedWord.ToUpper().ToCharArray();
                        char[] nextWordOfList = this.wordList[n].ToUpper().ToCharArray();
                        List<char> concatenatedLengths = new List<char>(comparedWordChar.Length + nextWordOfList.Length);
                        concatenatedLengths.AddRange(comparedWordChar);
                        concatenatedLengths.AddRange(nextWordOfList);
                        char[] concatenatedChars = concatenatedLengths.ToArray();
                        Array.Sort(concatenatedChars);
                        String concatenatedComparedWord = new string(concatenatedChars);

                        if (sortedInputString != concatenatedComparedWord)
                            continue;
                        matchedWordsListFinal.Add(comparedWord + " + " + this.wordList[n]);
                    }
                }
            }
            return this.matchedWordsListFinal.Count;
        }
        private void Anagrams_Click(object sender, EventArgs e)
        {
            if (inputWordBox.Text == "")
            {
                MessageBox.Show("First, enter a word to be checked for anagrams!");
            }

            int totalWords = LoadWords();
            FillMatchedWords(totalWords);

            wordListBox.Lines = matchedWordsListFinal.ToArray();
        }
    }
}
