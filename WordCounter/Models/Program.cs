using System;

namespace WordCounter
{
    public class RepeatCounter
    {

        private string _userString1;
        private string _userString2;
        public int x = 0;


        public void SetStringOne(string word)
        {
            _userString1 = word;
        }

        public string GetStringOne()
        {
            return _userString1;
        }

        public void SetStringTwo(string word)
        {
            _userString2 = word;
        }

        public string GetStringTwo()
        {
            return _userString2;
        }

        public string[] splitWord(string phrase)
        {
            string getString = phrase;
            string[] splitString = getString.Split(' ');
            return splitString;
        }


   
        static void Main()
        {
          

        }
    }
}
