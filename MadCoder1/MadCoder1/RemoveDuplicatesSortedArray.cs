using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeApp
{
    class RemoveDuplicatesSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int len = nums.Length;
            for(int i= 1;i < nums.Length;i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[i++] = nums[i];
                    len--;
                }
            }
            return len;
        }
    }
}
