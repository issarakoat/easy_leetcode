using System;
using System.Collections.Generic;

namespace Leetcode
{
  public class ListNode {
     public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }

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
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int max_sum = int.MinValue;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                int current_max = Math.Max(nums[i], nums[i] + nums[i + 1]);
                nums[i] = current_max;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                max_sum = Math.Max(nums[i], max_sum);
            }
            return max_sum;
        }
        public int MaxProfit_121(int[] prices)
        {
            int min = int.MaxValue;
            int res = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min) min = prices[i];
                else res = Math.Max(res, prices[i] - min);
            }
            return res;
        }
        public string ZigZagConversation_6(string s, int numRows)
        {
            string res = "";
            int num = 0;
            for (int i = 0; i < numRows; i++)
            {
                foreach (var item in s)
                {
                    Console.Write(item);
                }
            }
            return res;
        }
        public int[] PlusOne_66(int[] digits)
        {
            int tem = digits[digits.Length - 1];
            digits[digits.Length - 1] += 1;
            if(digits[digits.Length - 1] >= 10)
            {
                digits[digits.Length - 1] = tem;
                int carry = 1;
                for (int i = digits.Length-1; i >= 0; i--)
                {
                    digits[i] += carry;
                    if (digits[i] > 9 && i != 0)
                    {
                        carry = 1;
                        digits[i] = 0;
                    }
                    else carry = 0;
                    
                }
                if(digits[0] > 9)
                {
                    int[] res = new int[digits.Length + 1];
                    res[0] = 1;
                    res[1] = digits[0] % 10;
                    for (int i = 2; i < digits.Length + 1; i++)
                    {
                        res[i] = digits[i - 1];
                    }
                    return res;
                }
            }
            return digits;
        }
        public string AddBinary_67(string a, string b)
        {
            int len = a.Length;
            string res = "";
            char[] A = a.ToCharArray();
            Array.Reverse(A);
            char[] B = b.ToCharArray();
            Array.Reverse(B);
            if (A.Length != B.Length)
            {
                len = Math.Max(A.Length, B.Length);
            }
            int carry = 0;
            for (int i = 0; i < len; i++)
            {
                int x = 0;
                int y = 0;
                if(i < A.Length)
                {
                    if (A[i] == '1') x = 1;
                }
                if(i < B.Length)
                {
                    if (B[i] == '1' ) y = 1;
                }
                             
                int sum = x + y + carry;
                carry = 0;
                if (sum <= 1) res += sum.ToString();
                if(sum == 2)
                {
                    res += "0";
                    carry = 1;
                }
                if(sum == 3)
                {
                    res += "1";
                    carry = 1;
                }
            }
            if (carry == 1)
            {
                res += "1";
            }
            char[] array = res.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        public ListNode DeleteDuplicates_83(ListNode head)
        {
            if (head == null) return head;
            ListNode runner = new ListNode(head.val);
            ListNode res = runner;
            int a = 0;
            int b = 0;
            while(head.next != null)
            {
                a = head.val;
                head = head.next;
                b = head.val;
                if(b != a)
                {
                    runner.next = new ListNode(b);
                    runner = runner.next;
                }
            }
            return res;
        }
        public int ClimbStairs_70(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            return second;
        }
        public int LengthOfLastWord_58(string s)
        {
            int count = 0;
            if (s.Length == 0) return 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    i--;
                    count++;
                    if (i <= 0) return count;
                    while (i != 0)
                    {
                        if (s[i] != ' ') count++;
                        else return count;
                        i--;
                    }
                }
            }
            if (s[0] != ' ') count++;
            return count;
        }
    } 
}
