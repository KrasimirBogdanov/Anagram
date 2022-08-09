﻿
namespace Anagram
{
    public partial class Anagram : Form
    {
        public Anagram()
        {
            InitializeComponent();
        }
        private void Anagrams_Click(object sender, EventArgs e)
        { 
                if (inputStringBox.Text == "")
                {
                    MessageBox.Show("Please input string first!");
                }

                String[] wordList = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\WordList.txt").Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int totalWords = wordList.Length;

                String inputString = inputStringBox.Text;
 
                List<string> matchedWordsListFinal = new List<string>();

                char[] inputStringChars= inputString.ToUpper().ToCharArray();
                Array.Sort(inputStringChars);
                String sortedInputString = new string(inputStringChars);

                for (int m=0; m<totalWords; m++)
                {
                    int inputStringLength = inputString.Length;
                    int comparedWordLength = wordList[m].Length;

                    if (inputStringLength == comparedWordLength)
                    {
                        char[] comparedWordChars = wordList[m].ToUpper().ToCharArray();
                        Array.Sort(comparedWordChars);
                        String sortedComparedWord = new String(comparedWordChars);
                        if (sortedInputString == sortedComparedWord) 
                        {
                            matchedWordsListFinal.Add(wordList[m]);
                            richTextBox2.Lines = matchedWordsListFinal.ToArray();
                        }
                    }
                     else
                     {
                        for (int n = 0; n < totalWords; n++)
                        {
                            int nextWordOfListLength = wordList[n].Length;
                            int concatenatedWordsLength = comparedWordLength + nextWordOfListLength;

                            if (nextWordOfListLength > 0 && comparedWordLength > 0)
                            {
                                if (inputStringLength == concatenatedWordsLength)
                                {
                                    char[] comparedWord = wordList[m].ToUpper().ToCharArray();
                                    char[] nextWordOfList = wordList[n].ToUpper().ToCharArray();
                                    List<char> concatenatedLengths = new List<char>(comparedWord.Length + nextWordOfList.Length);
                                    concatenatedLengths.AddRange(comparedWord);
                                    concatenatedLengths.AddRange(nextWordOfList);
                                    concatenatedLengths.ToArray();
                                    char[] concatenatedChars = concatenatedLengths.ToArray();
                                    Array.Sort(concatenatedChars);
                                    String concatenatedComparedWord = new string(concatenatedChars);

                                    if (sortedInputString == concatenatedComparedWord)
                                    {
                                        matchedWordsListFinal.Add(wordList[m] + " + " + wordList[n]);
                                        richTextBox2.Lines = matchedWordsListFinal.ToArray();
                                    }
                                }
                            }
                        }
                     }
                }
        }
    }
}
