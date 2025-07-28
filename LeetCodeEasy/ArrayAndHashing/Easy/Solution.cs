using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy.Arrays.Easy
{
    public class Solution
    {
        public bool HasDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num))
                {
                    return true;
                }
                else
                {
                    set.Add(num);
                }
            }
            return false;
        }

        //Bruite Force on^2
        public int[] TwoSumBrute(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }


        //HashMap (One Pass)
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> prevMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (prevMap.ContainsKey(diff))
                {
                    return new int[] { prevMap[diff], i };
                }
                prevMap[nums[i]] = i;
            }
            return null;
        }


    }
}
