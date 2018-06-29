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

        [TestMethod]
        public void SplitList_String2toSplit_SplitStringArray()
        {
            RepeatCounter TestCounter = new RepeatCounter();
            string testPhrase = "this is a test";
            string[] testSplit = { "this", " is ", "a", "test" };
            TestCounter.splitWord(testPhrase);
            Assert.AreEqual(testSplit, TestCounter.splitWord(testPhrase));
        }



    }
}
