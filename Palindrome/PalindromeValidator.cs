using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeValidator
    {
        public string RemovePunctuation(string originalStr)
        {
            string returnStr = string.Empty;
            for (int i = 0; i < originalStr.Length; i++)
            {
                int testChar = (int)originalStr[i];
                if ((testChar >= 65 && testChar <= 90) || (testChar >= 97 && testChar <= 122))
                {
                    returnStr += originalStr[i];
                }
            }
            return returnStr;
        }

        public bool IsPalindrome(string testStr)
        {
            bool returnVal = true;
            string noPunct;
            noPunct = RemovePunctuation(testStr);
            noPunct = noPunct.ToLower();
            for (int i = 0, j = noPunct.Length - 1; i < noPunct.Length && j >= i; i++, j--)
            {
                if (noPunct[i] != noPunct[j])
                {
                    returnVal = false;
                    break;
                }
            }
            return returnVal;
        }
    }
}
