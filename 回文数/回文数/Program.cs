using System;
using System.Collections.Generic;
using System.Linq;

namespace 回文数
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            if (IsReturnNum(a))
            {
                Console.WriteLine("是回文数");
            }
            else
            {
                Console.WriteLine("不是回文数");
            }
            Console.ReadKey();


        }
        public static bool IsReturnNum(int x)
        {
            string x_new = string.Empty;
            string x_nums = x.ToString();
            char[] arr = x_nums.Reverse().ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                x_new += arr[i];
            }

            if (x_new == x_nums)
            {
                return true;
            }
            return false;
        }
    }
}
