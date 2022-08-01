
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
            string[] wordCount = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\WordList.txt").Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int totalWords = wordCount.Count();
            String [] wordList = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\WordList.txt").Split();
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
                    string [] matchedWords;

                    //richTextBox2.Text = wordList[i];
                    MessageBox.Show(wordList[i]);
                }
            }
        }
    }
}
