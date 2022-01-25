using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五天
{
    internal class while循环练习
    {
        static void Main()
        {
            //Console.WriteLine("请输入班级人数");
            //int count=Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int i = 1;
            //while(i<=count)
            //{
            //    Console.WriteLine("请输入第{0}个学员的考试成绩",i);
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    sum += score;
            //    i++;
            //}
            //Console.WriteLine("{0}个人的班级总成绩是{1}平均成绩是{2}", count, sum, sum / count);
            //Console.ReadKey();
            string answer = "";
            do
            {
                Console.WriteLine("laoshi?yes/no");
                answer = Console.ReadLine();
            } while (answer == "no");
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
