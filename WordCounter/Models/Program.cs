using System;

namespace WordCounter
{
    public class RepeatCounter
    {

        private string _userString1;
        private string _userString2;
        private int _x;


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

        public void SetVarX(int x)
        {
            _x = x;
        }

        public int GetVarX()
        {
            _x = 0;
            return _x;
        }

        public string[] splitWord(string phrase)
        {
            string getString = phrase;
            string[] splitString = getString.Split(' ');
            Console.WriteLine(splitString[1]);
            return splitString;

        }
   
        public int CheckString(string[] array)
        {
            int x = GetVarX();
            foreach (string word in array)
            {
                if (word == GetStringOne())
                {
                    x++;
                }
            }
            return x;
        }

        static void Main()
        {
          

        }
    }
}
