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


        //HashMap (One Pass) o(n)
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


        //HashTable (Using Array)
        //Time complexity: O(n+m)
        //Space complexity: O(1) since we have at most 26 different characters
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] counts = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                counts[s[i] - 'a']++;
                counts[t[i] - 'a']--;
            }

            foreach(var val in counts)
            {
                if (val != 0)
                {
                    return false;
                }
            }

            return true;    
        }
    }
}
