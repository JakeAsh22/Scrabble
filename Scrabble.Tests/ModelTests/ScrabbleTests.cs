using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabbin;

namespace ScrabbinTests
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void ScrabbleCalc_GetScore_ScoreOfWord()
        {
            Scrabble word = new Scrabble ("hello");
            string result =word.ScrabbleScore();
            Assert.AreEqual("8",result);
        }

        [TestMethod]
        public void ScrabbleCalc_GetScore_NotALetter()
        {
            Scrabble word = new Scrabble ("hello1");
            string result =word.ScrabbleScore();
            Assert.AreEqual("Please only use one word, with letters only.",result);
        }
    }
}