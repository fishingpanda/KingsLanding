using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeApp
{
    static class MatchingParenthesis
    {
        public static bool IsValid(string s)
        {
            char res = ' ';
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                stk.Push(s[i]);
                if (i == s.Length)
                    break;

                if ((s[i] == '(' && s[i + 1] == ')') ||
                    (s[i] == '{' && s[i + 1] == '}') ||
                    (s[i] == '[' && s[i + 1] == ']'))
                { stk.TryPop(out res); i = i + 2; }
                else
                    i++;

            }
            if (stk.Count != 0)
                return false;
            else
                return true;
        }
    }
}