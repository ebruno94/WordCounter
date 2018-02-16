using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterProject;

namespace WordCounterProject.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        // SIMPLE CASE
        [TestMethod]
        public void CountWords_ReturnNumberOfWords_Apple1()
        {
            //Arrange
            WordCounter myCounter = new WordCounter();
            //Assert
            Assert.AreEqual(1, myCounter.CountWords("apple"));
        }

        [TestMethod]
        public void SetDictionary_ContainsApple_True()
        {
            WordCounter myCounter = new WordCounter();
            myCounter.SetDictionary("apple");
            Assert.AreEqual(true, myCounter.GetDictionary().ContainsKey("apple"));
        }

        [TestMethod]
        public void SetDictionary_ContainsTwoApples_True()
        {
            WordCounter myCounter = new WordCounter();
            myCounter.SetDictionary("apple apple");
            Assert.AreEqual(2, myCounter.GetDictionary()["apple"]);
        }
    }
}
