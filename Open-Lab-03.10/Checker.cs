using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int a = 0;
            foreach (var item in str)
            {
                if (item == letter)
                {
                    a++;
                }
            }
            return a;
            
        }
    }
}
