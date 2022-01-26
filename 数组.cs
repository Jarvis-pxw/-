using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六天
{
    internal class 数组
    {
        static void Main()
        {
            //string[] names = { "A", "B", "C", "D", "E" };
            //string str = null;
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    str += names[i] + "|";
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();
            int[] nums = { 1, 2, 4, 5, 7, 9, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    nums[i] += 1; ;
                }
                else if(nums[i]<0)
                {
                    nums[i]-=1;
                }
                else
                {
                    nums[i] = 0;
                }
            }
            for (int i = 0; i < nums.Length - 1; i++) ;
        }
    }
}
