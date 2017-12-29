using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeApp
{
    class ReverseNumber7
    {
        public static int Reverse(int x)
        {
            long rev = 0;

            while (x != 0)
            {
                int rem = x % 10;
                rev = rev * 10 + rem;
                x = x / 10;

                if (rev >= int.MaxValue || rev <= int.MinValue)
                    return 0;
            }
            return (int)rev;

        }
        /// <summary>
        /// check palindrome by reversing number
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome1(int x)
        {
            if (x < 0) return false;

            int originalNum = x;
            long rev = 0;

            while (x != 0)
            {
                int rem = x % 10;
                rev = rev * 10 + rem;
                x = x / 10;
                if (rev > int.MaxValue) return false;
            }
            return ((int)rev == originalNum) ? true : false;

        }

        /// <summary>
        /// check palindrome by reversing number
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome2(int x)
        {
            if (x < 0) return false;

            long rev = 0;

            while (x != 0)
            {
                int rem = x % 10;
                rev = rev * 10 + rem;
                x = x / 10; 
            }

            return ((int)rev == x) ? true : false;

        }
    }

}
