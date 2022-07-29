
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
            String [] wordList = System.IO.File.ReadAllText(@"C:\Users\Krasskoo\Desktop\Untitled.txt").Split();
            String inputString = "documenting";

            

            char[] wrdArray1 = inputString.ToUpper().ToCharArray();
            char[] wrdArray2 = wordList[0].ToUpper().ToCharArray();

            Array.Sort(wrdArray1);
            Array.Sort(wrdArray2);

            String newWord1 = new string(wrdArray1);
            String newWord2 = new string(wrdArray2);

//            richTextBox2.Text = newWord2;
            if (newWord1 == newWord2)
                richTextBox2.Text = inputString + " and " + wordList[0] + " are Anagrams";
            else
                richTextBox2.Text = inputString + " and " + wordList[0] + " are not Anagrams";
        }
    }
}
