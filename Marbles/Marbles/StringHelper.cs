using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
    public static class StringHelper
    {
        public static bool IsPalindrome(String input)
        {
            string lowerCaseText = input.ToLower();
            char[] chars = lowerCaseText.ToCharArray();
            StringBuilder sb = new StringBuilder();

            foreach (char c in chars)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }

            string cleanAndLoweredString = sb.ToString();
            char[] cleanedChars = cleanAndLoweredString.ToCharArray();
            Array.Reverse(cleanedChars);
            string reversed = new string(cleanedChars);

            if (reversed == cleanAndLoweredString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
