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

            int actual = an.WordLoad();

            Assert.Equal(expected, actual);
        }


    }
}
