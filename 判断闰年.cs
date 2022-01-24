using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四天
{
    internal class 判断闰年
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个年份");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入一个月份");
            int month = Convert.ToInt32(Console.ReadLine());
            int day = 0;
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:day = 31;
                    break;
                case 2:
                    if((year%400==0)||(year%4==0&&year%100!=0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:day = 30;
                    break;
            }
            Console.WriteLine("{0}年{1}月{2}日",year,month,day);
            Console.ReadKey();
        }
    }
}
