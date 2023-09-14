using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 移除元素
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======移除元素=======");
            int length = RemoveVal();
            Console.WriteLine("length:" + length);
            Console.ReadKey();
        }
        static int RemoveVal()
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            List<int> l1 = new List<int>();
            foreach (var item in nums)
            {
                if (item != val)
                {
                    l1.Add(item);
                }
            }
            foreach (var item in l1)
            {
                Console.WriteLine(item + "\t");
            }
            return l1.ToArray().Length;
        }
    }
}
