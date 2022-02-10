using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九天
{
    public class student
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _age;
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _chinese;
        public string Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        private string english;
        public string English
        {
            get { return english; }
            set { english = value; }
        }
        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了,我是{2}生", this.Name, this.Age, this.Gender);
        }
        public void ShowScore()
        {
            Console.WriteLine("我叫{0},我的总成绩{1},平均成绩{2}",this.Name,this.Chinese+this.English);
        }
    }
}
