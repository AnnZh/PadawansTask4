using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            // put your code here
            // throw new NotImplementedException();
            if (str == null)
                throw new ArgumentException();

            char[] arr = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int k = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (str[i] == arr[j])
                        k++;
                }
            }

            return k;
        }
    }
}
