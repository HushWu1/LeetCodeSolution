using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 合并链表排序
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {

        public static void showNode(ListNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.val + " ");
                node = node.next;
            }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode temp = new ListNode(0);
            ListNode l3 = temp;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    temp.next = l1;
                    temp = temp.next;
                    l1 = l1.next;
                }
                else
                {
                    temp.next = l2;
                    temp = temp.next;
                    l2 = l2.next;
                }
            }
            if (l1 == null)
                temp.next = l2;
            else if (l2 == null)
                temp.next = l1;
            return l3.next;
        }

    }
}
