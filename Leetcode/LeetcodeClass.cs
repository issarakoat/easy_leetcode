using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class LeetcodeClass
    {
        public int RemoveDuplicates_26(int[] nums) //passed
        {
            if(nums.Length == 0) { return 0; }
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[count] != nums[i])
                {
                    count++;
                    nums[count] = nums[i];                
                }
            }
            return count+1;
        }

        public int RemoveElement_27(int[] nums, int val)//passed
        {
            if (nums.Length == 0) { return 0; }
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }
        public List<string> ReadBinaryWatch_401(int num)
        {
            int hour = num;
            int min = num;
            List<string> res = new List<string>();
            if(num == 0)
            {
                res.Add("0:00");
                return res;
            }
            for(int i = 1; i<=8; i *= 2)
            {
                Console.WriteLine(i);


            }
            return res;
        }
        public bool HapppyNumber_202(int n)
        {
            List<int> checks = new List<int>();
            int res = n;
            int mod = 0;
            while (res > 0)
            {
                int tem = res;
                if (res == 1) return true;
                else res = 0;
                while (tem != 0)
                {
                    mod = tem % 10;
                    res += mod * mod;
                    tem /= 10;                 
                }
                if (checks.Contains(res)) return false;
                checks.Add(res);
            }
            return false;
        }
    }
}
