
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
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please insert string first!");
            }
            else
            {
                string[] wordCount = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\Untitled.txt").Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int totalWords = wordCount.Count();
                String[] wordList = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\Untitled.txt").Split();
                String inputString = textBox1.Text;
                List<string> matchedWordsListFinal = new List<string>();

                char[] wrdArray1 = inputString.ToUpper().ToCharArray();
                Array.Sort(wrdArray1);
                String newWord1 = new string(wrdArray1);
                
                for (int m=0; m<wordCount.Length - 1; m++)
                {
                    int inputStringLength = inputString.Length; // Дължина на въведения стринг
                  //  MessageBox.Show("input " + inputString + " dulug: " + inputStringLength);
                    int matchingWord = wordList[m].Length; // Дължина на m стринг от списъка (първия)
                    if (inputStringLength == matchingWord) //Ако думата е еднакво дълга с въведената 
                    {
                        char[] matchingWordArr = wordList[m].ToUpper().ToCharArray();
                        Array.Sort(matchingWordArr);
                        String matchingNewWord = new String(matchingWordArr);
                        if (newWord1 == matchingNewWord) // Ако символите са еднакви
                        {
                            matchedWordsListFinal.Add(wordList[m]); //Запис
                    //        MessageBox.Show("Zapis " + wordList[m]);
                            richTextBox2.Lines = matchedWordsListFinal.ToArray();
                        }
                    }
                    // ----------------WORKS VERY GOOD----------------------
                     else
                     {
                     //    MessageBox.Show("matchingWord " + wordList[m] + " /" + matchingWord);
                         for (int n = 0; n < wordCount.Length - 1; n++)
                         {
                             int nextWord = wordList[n].Length; // Дължина на следващият стринг 
                      //       MessageBox.Show("nextWord " + wordList[n] + " /" + nextWord);
                             int matchingWordConcat = matchingWord + nextWord; // Дължина на два поредни стринга
                        //     MessageBox.Show("concat " + matchingWordConcat);

                             if (inputStringLength == matchingWordConcat)
                             {
                                 char[] wrdArrayFirstCheck = wordList[m].ToUpper().ToCharArray();
                                 char[] wrdArrayLastCheck = wordList[n].ToUpper().ToCharArray();
                                 List<char> list = new List<char>(wrdArrayFirstCheck.Length + wrdArrayLastCheck.Length);
                                 list.AddRange(wrdArrayFirstCheck);
                                 list.AddRange(wrdArrayLastCheck);
                                 list.ToArray();
                                 char[] concated = list.ToArray();
                                 Array.Sort(concated);
                                 String concatenatedWord = new string(concated);

                                 if (newWord1 == concatenatedWord)
                                 {
                                     matchedWordsListFinal.Add(wordList[m] + " + " + wordList[n]);
                                     //matchedWordsListFinal.Add(wordList[n]);
                         //            MessageBox.Show("Zapis v cikula 1va duma " + wordList[m] + " 2ra duma " + wordList[n]);
                                     richTextBox2.Lines = matchedWordsListFinal.ToArray();
                                }  
                             }
                         }
                     }
                }

             /*   for (int j = 0; j < wordCount.Length; j++)
                {
                    char[] wrdArrayFirstCheck = wordList[j].ToUpper().ToCharArray();
                    Array.Sort(wrdArrayFirstCheck);
                    String newWordFirstCheck = new string(wrdArrayFirstCheck);
                    if (newWordFirstCheck == newWord1)
                    {
                        string matchedWord = wordList[j];
                        matchedWordsListFinal.Add(matchedWord);
                    }
                }
                 for (int i = 0; i < wordCount.Length; i++)
                 {
                     char[] wrdArray2 = wordList[i].ToUpper().ToCharArray();
                     char[] wrdArray3 = wordList[i+1].ToUpper().ToCharArray();
                     List<char> list = new List<char>(wrdArray2.Length + wrdArray3.Length);
                     list.AddRange(wrdArray2);
                     list.AddRange(wrdArray3);
                     list.ToArray();
                     char[] concated = list.ToArray();
                     Array.Sort(concated);
                     String newWord2 = new string(concated);

                     if (newWord2 == newWord1)
                     {
                         string matchedWord1 = wordList[i];
                         string matchedWord2 = wordList[i+1];
                         matchedWordsListFinal.Add(matchedWord1);
                         matchedWordsListFinal.Add(matchedWord2);
                     }

                     if (matchedWordsListFinal.Count == 0)
                     {
                         richTextBox2.Text = "There are not Anagrams with that word!";
                     }
                 }*/
              //  richTextBox2.Lines = matchedWordsListFinal.ToArray();
            }
        }
    }
}
