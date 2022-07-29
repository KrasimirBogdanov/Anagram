
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
                char[] wrdArray2 = wordList[0].ToUpper().ToCharArray();
                Array.Sort(wrdArray2);
                String newWord2 = new string(wrdArray2);
                if (newWord2 == newWord1)
                {
                    richTextBox2.Text = wordList[i];
                }
                MessageBox.Show(newWord2);
            }

           // MessageBox.Show(totalWords.ToString());

           // if (newWord1 == newWord2)
             //   richTextBox2.Text = wordList[wordCount];
        }
    }
}
