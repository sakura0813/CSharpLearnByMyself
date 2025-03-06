namespace ITheima_as多态类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            Student student = new Student();

            //强制类型转换，由父类转换为子类会报错
            //student = (student)people;
            //可以用as关键字进行类型转换，如果转换成功，返回对应类的“命名空间.类名”,如果不成功，则返回null
            Student s = people as Student;
            //此时s为null
            Console.WriteLine(s);

        }
    }

    class People
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Student : People
    {
        public int Score { get; set; }
    }
}
