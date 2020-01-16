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
        private bool isPrime_204(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public int CountPrime_204(int n)
        {
            int count = 0;
            for(int i = 2; i<n; i++)
            {
                if (isPrime_204(i)) count++;
            }
            return count;
        }
        public int StrStr_28(string haystack, string needle)
        {
            int index = -1;
            index = haystack.IndexOf(needle);
            return index;
        }
        public double RootMeanSquarError(double[] predited, double[] observed)
        {
            double me_p = 0.0;
            double me_o = 0.0;
            int N = 0;
            foreach (var p in predited)
            {
                me_p += p;
                N++;
            }
            foreach (var o in observed)
            {
                me_o += o;
            }
            double res = Math.Sqrt((me_p - me_o) * (me_p - me_o)/N);
            return res;
        }
        public int SearchInsertPosition_35(int[] nums, int target)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i]) return i;
                if (target > nums[i]) index = i+1;
            }
            return index;
        }
    } 
}
