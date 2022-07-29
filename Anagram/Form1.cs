
namespace Anagram
{
    public partial class Anagram : Form
    {
         public Anagram()
        {
            InitializeComponent();
        }
        public string checkIfAnagrams(string input, string wordlist)
        {
            String inputString = "documenting";
            String wordList = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\WordList.txt");

            char[] wrdArray1 = inputString.ToUpper().ToCharArray();
            char[] wrdArray2 = wordList.ToUpper().ToCharArray();

            Array.Sort(wrdArray1);
            Array.Sort(wrdArray2);

            String newWord1 = new string(wrdArray1);
            String newWord2 = new string(wrdArray2);

            if (newWord1 == newWord2)
                return inputString + " and " + wordList + " are Anagrams";
            else
                return inputString + " and " + wordList + " are not Anagrams";
        }

        private void Anagrams_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = wordList;
        }
    }
}
