using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetcodeClass LC = new LeetcodeClass();
            int[] a = {1, 2, 3, 0, 0, 0};
            int[] b = { 2,5,6};
            LC.Merge_88(a,6, b,3);
            Console.ReadLine();
        }
    }
}
