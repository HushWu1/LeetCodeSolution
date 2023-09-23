using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 迭代器
{
    class Program
    {
        static void Main(string[] args)
        {
            new IEnumMath().StartContion(new IEnumMath().TestCoroutine());
            //List<int> list = new List<int>();
            //int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = { 2, 5, 6 };
            //foreach (var item in nums1)
            //{
            //    if (item != 0)
            //    {
            //        list.Add(item);
            //    }
            //}
            //list.AddRange(nums2);
            //list.Sort();
            //nums1 = list.ToArray();
            //foreach (var item in nums1)
            //{
            //    Console.WriteLine(item + "\t"); ;
            //}
            Console.ReadKey();
        }
        public class IEnumMath
        {
            public IEnumerator TestCoroutine()
            {
                yield return 1;
                Console.WriteLine("A");

                yield return 2;
                Console.WriteLine("B");

                yield return 3;
                Console.WriteLine("C");

                yield return null;

                Console.WriteLine("延迟一秒后执行");

                yield break;   //跳出，类似普通函数中的return语句由于break语句，该内容无法返回
            }


            public void StartContion(IEnumerator e)
            {
                while (e.MoveNext())
                {
                    if (e.Current == null)
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
