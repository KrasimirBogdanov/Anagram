
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

                for (int j = 0; j < wordCount.Length; j++)
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
                    richTextBox2.Lines = matchedWordsListFinal.ToArray();
                    if (matchedWordsListFinal.Count == 0)
                    {
                        richTextBox2.Text = "There are not Anagrams with that word!";
                    }
                }
            }
        }
    }
}
