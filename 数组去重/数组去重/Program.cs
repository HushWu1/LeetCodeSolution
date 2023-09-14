using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组去重
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============去重==================");
            int[] nums = { 1, 2, 3, 2, 3, 4, 5, 2, 10, 9, 8, 9 };
            int[] nums_new = nums.Distinct().ToArray();
            foreach (var item in nums_new)
            {
                Console.WriteLine(item + "\n");
            }
            Console.ReadKey();
        }
    }
}
