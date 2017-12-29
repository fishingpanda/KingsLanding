using System;

namespace LeetCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ReverseNumber7.Reverse(1211456789));


            //Console.WriteLine(ReverseNumber7.IsPalindrome1(1234567812));

            //Console.WriteLine(ReverseNumber7.IsPalindrome2(12344321));

            //int p= RemoveDuplicatesSortedArray.RemoveDuplicates(new int[]{1,1,2,3,4,4,7});
            Console.WriteLine(MatchingParenthesis.IsValid("{}{}"));

            Console.WriteLine(MatchingParenthesis.IsValid("{}{]"));
            Console.WriteLine(MatchingParenthesis.IsValid("{}{()}"));

            Console.ReadLine();
        }
    }
}
