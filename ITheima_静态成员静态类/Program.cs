namespace ITheima_静态成员静态类
{
    internal class Program
    {
        //静态成员不一定都在静态类里声明
        static void Main(string[] args)
        {

            Father father = new Father();
            father.Id = 1;
            father.Name = "Test";
            father.Age = 30;
            //静态成员通过“类名.属性名”赋值，且所有通过Father类实例化的成员的static属性都会改变成当前值
            Father.Description = "此类中的静态属性";

            Console.WriteLine("");

            //通过一般方式实例化一个people2
            People2 people2 = new People2();
            //在实例化一个类的时候也可以做一些“骚操作”，通过静态方法创建类的实例eg：47行
            People2 people = People2.GetOnePeople2();

        }
    }
    //声明一个静态类，与静态类相反的实例类，需要实例化的类，静态类里的成员必须也是静态的，要加static关键字
    static class People
    {

    }

    class Father
    {
        //类的实例化属性必须通过实例化后才能赋值，但是静态属性直接可以通过"类名.静态属性"的方式赋值
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        //静态属性直接可以通过"类名.静态属性"的方式赋值，且所有通过Father类实例化的成员的static属性都会改变成相同的值
        public static string Description { get; set; } = string.Empty;
    }

    class People2
    {
        //构造函数
        public People2()
        {

        }
        public static People2 GetOnePeople2()
        {
            //其他业务逻辑代码
            //...

            //在最后return一个new People2
            return new People2();
        }
    }
}
