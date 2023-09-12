using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 合并链表排序
{

    class Program
    {

        static void Main(string[] args)
        {
            ListNode n1 = new ListNode(1);
            n1.next = new ListNode(2);
            n1.next.next = new ListNode(3);
            Console.WriteLine("n1链表：\t");
            Solution.showNode(n1);

            ListNode n2 = new ListNode(1);
            n2.next = new ListNode(3);
            n2.next.next = new ListNode(4);
            Console.WriteLine("n2链表：\t");
            Solution.showNode(n2);

            //调用方法进行合并
            ListNode n3 = Solution.MergeTwoLists(n1, n2);
            //排序完成后输出
            Console.WriteLine("排序后输出结果" + "\t");
            Solution.showNode(n3);
            Console.ReadKey();
        }


    }

}

