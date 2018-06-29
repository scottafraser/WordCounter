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
        public void GetSetVarX_GetsSetsVarX_Int()
        {
            RepeatCounter TestCounter = new RepeatCounter();
            int testInt = 0;
            TestCounter.SetVarX(testInt);
            Assert.AreEqual(testInt, TestCounter.GetVarX());
        }

        [TestMethod]
        public void SplitList_String2toSplit_SplitStringArray()
        {
            RepeatCounter TestCounter = new RepeatCounter();
            string testPhrase = "this is a test";
            string[] testSplit = { "this", "is", "a", "test" };
            CollectionAssert.AreEqual(testSplit, TestCounter.splitWord(testPhrase));
        }

        [TestMethod]
        public void CompareWithInput_IfForEachArray_CompareSplitString()
        {
            RepeatCounter TestCounter = new RepeatCounter();
            string test = "test";
            TestCounter.SetStringOne(test);
            TestCounter.GetStringOne();
            string[] testSplit = { "this", "test", "is", "a", "test" };
            int testInt = 2;
            Assert.AreEqual(testInt, TestCounter.CheckString(testSplit));
        }


    }
}
