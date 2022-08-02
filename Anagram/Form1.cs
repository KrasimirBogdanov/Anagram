
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
            string[] wordCount = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\Untitled.txt").Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int totalWords = wordCount.Count();
            String [] wordList = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\Untitled.txt").Split();
            String inputString = "documenting";


            char[] wrdArray1 = inputString.ToUpper().ToCharArray();
            Array.Sort(wrdArray1);
            String newWord1 = new string(wrdArray1);

            for (int i=0; i<wordCount.Length; i++)
            {
                char[] wrdArray2 = wordList[i].ToUpper().ToCharArray();
                Array.Sort(wrdArray2);
                String newWord2 = new string(wrdArray2);
                if (newWord2 == newWord1)
                {
                    string matchedWord = wordList[i]; // MAYBE PROBLEM HERE ?
                    /* 
                      string[] matchedWords = new string[] { matchedWord }; // maybe problem here? variable is overwritten and the last written replace already stored variable in array
                      List<string> list = new List<string>(matchedWords.ToList());
                      list.Add(matchedWord);
                      matchedWords = list.ToArray();
                      string resultWords = string.Join(", ", matchedWords);
                      richTextBox2.Text = list.ToString();
                    */
                    List<string> matchedWordsListFinal = new List<string>();
                    matchedWordsListFinal.Add(matchedWord);
                    richTextBox2.Lines = matchedWordsListFinal.ToArray();
                    MessageBox.Show(matchedWord);
                }

            }
        }
    }
}
