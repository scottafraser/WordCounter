using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void GetSetUserWord_GetsSetsUserWord_String()
        {
            RepeatCounter TestCounter= new RepeatCounter();
            string testWord = "test";
            TestCounter.SetStringOne(testWord);
            Assert.AreEqual(testWord, TestCounter.GetStringOne());
        }

        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_String()
        {
            RepeatCounter TestCounter = new RepeatCounter();
            string testWord = "test";
            TestCounter.SetStringTwo(testWord);
            Assert.AreEqual(testWord, TestCounter.GetStringTwo());
        }

    }
}
