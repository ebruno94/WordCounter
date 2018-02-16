using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterProject;
using System;

namespace WordCounterProject.Tests
{
    [TestClass]
    public class WordCounterTest : IDisposable
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
            // RepeatCounter myCounter = new RepeatCounter();
            RepeatCounter.SetDictionary("apple");
            Assert.AreEqual(true, RepeatCounter.GetDictionary().ContainsKey("apple"));
        }

        [TestMethod]
        public void SetDictionary_ContainsTwoApples_True()
        {
            // RepeatCounter myCounter = new RepeatCounter();
            RepeatCounter.SetDictionary("apple apple");
            Assert.AreEqual(2, RepeatCounter.GetDictionary()["apple"]);
        }

        [TestMethod]
        public void SetDictionary_Contains3Foos_True()
        {
            RepeatCounter.SetDictionary("foo bar baz foo bar baz foo bar");
            Assert.AreEqual(3, RepeatCounter.GetDictionary()["foo"]);
        }

        public void Dispose()
        {
            RepeatCounter.ClearAll();
        }
    }
}
