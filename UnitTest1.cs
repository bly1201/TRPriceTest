using NUnit.Framework;
using System;

namespace NUnitTestTRPrice
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLongestWord()
        {
            // The cow jumped over the moon.
            string strWords = "The cow jumped over the moon.";
            string varWord;
            int expectedLength = "jumped".Length;
            varWord = LongestString(strWords);

            Assert.AreEqual("jumped", varWord);
            Assert.AreEqual(expectedLength, varWord.Length);
           
        }
        [Test]
        public void TestShortestWord()
        {
            // The cow jumped over the moon.
            string strWords = "The cow jumped over the moon.";
            string varActualWord;
            string expectedWord = "cow";

            varActualWord = ShortTestString(strWords);
            //Negative Testing
            Assert.AreEqual(expectedWord, varActualWord);
            //Positive testing
            Assert.AreEqual("The".Length, varActualWord.Length);

            
        }

        private string LongestString( string strIn)
        {

            string strsentence = strIn;

            string[] arraywords = strsentence.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int varLength = 0;
            foreach (String s in arraywords)
            {
                if (s.Length > varLength)
                {
                    word = s;
                    varLength = s.Length;
                }
            }

            Console.WriteLine(word);

            return word;

        }
        private string ShortTestString(string strIn)
        {

            string strsentence = strIn; 
            string[] arraywords = strsentence.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            string varLength = arraywords[0];
            foreach (String s in arraywords)
            {
                if (s.Length <= varLength.Length)
                {
                    word = s;
                }               

            }

            Console.WriteLine(word);

            return word;

        }

    }
}