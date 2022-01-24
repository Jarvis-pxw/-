using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四天
{
    internal class switch_case结构
    {
        static void Main()
        {
            bool b = true;
            double salary = 5000;
            Console.WriteLine("请输入对李四的年终评定");
            string level=Console.ReadLine();
            switch (level)
            {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C":
                    salary -= 200;
                    break;
                default:
                    Console.WriteLine("输入有误,程序退出");
                    b= false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("李四明年的工资是{0}元", salary);
            }
            Console.ReadKey();
        }
    }
}
