using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class LeetcodeClass
    {
        public int RemoveDuplicates_26(int[] nums) //passed
        {
            if (nums.Length == 0) { return 0; }
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[count] != nums[i])
                {
                    count++;
                    nums[count] = nums[i];
                }
            }
            return count + 1;
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
            if (num == 0)
            {
                res.Add("0:00");
                return res;
            }
            for (int i = 1; i <= 8; i *= 2)
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
            for (int i = 2; i < n; i++)
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
            double res = Math.Sqrt((me_p - me_o) * (me_p - me_o) / N);
            return res;
        }
        public int SearchInsertPosition_35(int[] nums, int target)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i]) return i;
                if (target > nums[i]) index = i + 1;
            }
            return index;
        }
        public int MaxSubArray_53(int[] nums)
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
        public int MaxSumOfTwoElements(int[] nums)
        {
            int maxNum = int.MinValue;
            int maxSum = int.MinValue;
            if (nums.Length == 1) return nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (maxNum != nums[i + 1])
                {
                    maxNum = Math.Max(maxNum, nums[i]);
                    maxSum = Math.Max(maxSum, maxNum + nums[i + 1]);
                }
            }
            return maxSum;
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
        //couldn't do this
        public string ZigZagConversation_6(string s, int numRows)
        {
            string res = "";
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
            if (digits[digits.Length - 1] >= 10)
            {
                digits[digits.Length - 1] = tem;
                int carry = 1;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    digits[i] += carry;
                    if (digits[i] > 9 && i != 0)
                    {
                        carry = 1;
                        digits[i] = 0;
                    }
                    else carry = 0;

                }
                if (digits[0] > 9)
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
                if (i < A.Length)
                {
                    if (A[i] == '1') x = 1;
                }
                if (i < B.Length)
                {
                    if (B[i] == '1') y = 1;
                }

                int sum = x + y + carry;
                carry = 0;
                if (sum <= 1) res += sum.ToString();
                if (sum == 2)
                {
                    res += "0";
                    carry = 1;
                }
                if (sum == 3)
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
            while (head.next != null)
            {
                a = head.val;
                head = head.next;
                b = head.val;
                if (b != a)
                {
                    runner.next = new ListNode(b);
                    runner = runner.next;
                }
            }
            return res;
        }
        //Fibonacci Number
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
        //this one is so dumb
        public void Merge_88(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }
        public bool IsSameTree_100(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;
            return IsSameTree_100(p.left, q.left) && IsSameTree_100(p.right, q.right);
        }
        public bool IsSymmetric_101(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(root);
            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();
                TreeNode node1 = q.Dequeue();
                if (node == null && node1 == null) continue;
                if (node == null || node1 == null) return false;
                if (node.val != node1.val) return false;
                q.Enqueue(node.left);
                q.Enqueue(node1.right);
                q.Enqueue(node.right);
                q.Enqueue(node1.left);
            }
            return true;
        }
        public int MaxDepth_104(TreeNode root)
        {
            if (root == null) return 0;
            int count = 1;
            int countLeft = MaxDepth_104(root.left);
            int countRight = MaxDepth_104(root.right);
            return countLeft > countRight ? count + countLeft : count + countRight;
        }
        public int MaxDepth_104_v2(TreeNode root)
        {
            if (root == null) return 0;
            int count = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(null);
            while (q.Count > 0)
            {
                TreeNode t = q.Dequeue();
                if (t == null)
                {
                    count++;
                    if (q.Count == 0) break;
                    else
                    {
                        q.Enqueue(null); //separate the level by Enque
                        continue;
                    }
                }
                if (t.left != null) q.Enqueue(t.left);
                if (t.right != null) q.Enqueue(t.right);
            }
            return count;
        }
        public int[] TwoSum_1(int[] nums, int target)
        {
            int[] res = new int[2];
            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = j + 1; i < nums.Length; i++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = j;
                        res[1] = i;
                        return res;
                    }
                }
            }

            return res;
        }
        public int[] TwoSum_1_v2(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int index = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                dic.Add(j, nums[j]);
                int complement = target - dic[j];
                if (dic.ContainsValue(complement))
                {
                    int key = dic.FirstOrDefault(x => x.Value == complement).Key;
                    if (key != j)
                        return new int[] { key, j };
                }
                index++;
            }
            return null;
        }
        public int[] TwoSum_1_v3(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int compliment = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                compliment = target - nums[i];
                if (dic.ContainsValue(compliment))
                {
                    index = i;
                    break;
                }
                dic.Add(i, nums[i]);
            }
            foreach (var item in dic)
            {
                if (item.Value == compliment) return new int[] { item.Key, i };
            }
            return null;
        }
        public int[] two_sum_v4(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int first = 0;
            int succ = 0;
            int val = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(i, target - nums[i]);
            }
            for (int j = 0; j < nums.Length; j++)
            {
                succ = target - nums[j];
                
                if(dic.TryGetValue(succ, out val) & nums[j] != succ) first = j; 
            }
            foreach (var item in dic)
            {
                if (item.Value == val) return new int[] { first, item.Key };
            }
            return null;
        }
        public int SingleNumber_136(int[] nums)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!res.Contains(nums[i])) res.Add(nums[i]);
                else res.Remove(nums[i]);
            }
            return res[0];
        }
        //Runtime: 88 ms, faster than 99.63% of C# online submissions for Single Number.
        public int SingleNumber_136_v2(int[] nums)
        {
            int res = 0;
            foreach (var item in nums)
            {
                res ^= item;
            }
            return res;
        }
    }
}
