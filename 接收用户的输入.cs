using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三天
{
    internal class 接收用户的输入
    {
        static void Main()
        {
            Console.WriteLine("请输入你的姓名");
            string name=Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            string age = Console.ReadLine();
            Console.WriteLine("{0}你的年龄是{1}",name,age);
            Console.ReadKey();
            //Console.WriteLine("今天天气好\n朗朗好风光");
            //string name1 = "pxw";
            //string name2 = "jkahjdhka";
            //string name3 = "ahdha";
            //Console.WriteLine("{0}\t{1}", name1, name2);
            //Console.WriteLine("xuexi\byouyongma");
            //Console.ReadKey();
        }
    }
}
