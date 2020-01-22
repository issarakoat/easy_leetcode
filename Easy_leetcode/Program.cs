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
            TreeNode a = new TreeNode(1);
            a.left = new TreeNode(2);
            a.right = new TreeNode(2);
            a.left.left = new TreeNode(3);
            a.left.right = new TreeNode(4);
            a.right.left = new TreeNode(4);
            a.right.right = new TreeNode(3);
            LC.IsSymmetric_101(a);
            Console.WriteLine(LC.IsSymmetric_101(a));
            //need to do ZigZagConversation_6
            Console.ReadLine();
        }
    }
}
