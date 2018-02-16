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
            RepeatCounter myCounter = new RepeatCounter();
            //Assert
            Assert.AreEqual(1, myCounter.CountWords("apple"));
        }

        [TestMethod]
        public void SetDictionary_ContainsApple_True()
        {
            RepeatCounter myCounter = new RepeatCounter();
            myCounter.SetDictionary("apple");
            Assert.AreEqual(true, myCounter.GetDictionary().ContainsKey("apple"));
        }

        [TestMethod]
        public void SetDictionary_ContainsTwoApples_True()
        {
            RepeatCounter myCounter = new RepeatCounter();
            myCounter.SetDictionary("apple apple");
            Assert.AreEqual(2, myCounter.GetDictionary()["apple"]);
        }
    }
}
