using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterProject;

namespace WordCounterProject.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void CountWords_ReturnNumberOfWords_Apple1()
        {
            //Arrange
            WordCounter myCounter = new WordCounter();
            //Assert
            Assert.AreEqual(1, myCounter.CountWords("apple"));
        }
    }
}
