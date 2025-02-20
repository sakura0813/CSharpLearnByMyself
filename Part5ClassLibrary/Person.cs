

namespace Part5ClassLibrary
{
    //显示的继承object
    public class Person: object
    {
        public WorldsOfTheAncientWorld FavoriteAncientWonder;
        public int ID { get; set; }
        public string Name { get; set; }
        //如果要通过属性里的set限制赋值范围，则要在建立这个属性之前建立一个私有的字段，通过私有的字段进行赋值和取值，不然会循环调用属性而出现溢出！
        private int age;
        public int Age 
        {
            get { return age; }
            set 
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("请输入正确的年龄！");
                }
                else
                {
                    age = value;
                }
            } 
        }
        public DateTime DateOfBirth { get; set; }
        public List<Person> Children = new List<Person>();




        public void SayHello() 
        {
            Console.WriteLine($"你好，我是{this.Name},我的ID是{this.ID},我今年{this.age}岁了！");
        }

        //定义一个返回元组的方法

        public (string Name, int Number) GetFruit()
        {
            return (Name:"apple",Number: 5);
        }

        //结构类型

        public void Deconstruct(out string name, out int dob)
        {
            name = this.Name;
            dob = this.Age;
            

        }
        public void Deconstruct(out string name, out int dob,out WorldsOfTheAncientWorld fov)
        {
            name = Name;
            dob = Age;
            fov = FavoriteAncientWonder;

        }
    }
}
