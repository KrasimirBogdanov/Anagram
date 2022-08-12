using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anagram
{
    public class Test
    {
        [Fact]
        public void WordCount()
        {
            Anagram an = new Anagram();

            int expected = 1907;

            int actual = an.LoadWords();

            Assert.Equal(expected, actual);
        }
        /*
        public void MatchedWords()
        {
            Anagram an = new Anagram();

            int expected = 4;

            int actual = an.FillMatchedWords(an.LoadWords());

            Assert.Equal(expected, actual);
        }
        */
    }
}
