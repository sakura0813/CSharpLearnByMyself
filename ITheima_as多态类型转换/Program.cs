namespace ITheima_as多态类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            people people = new people();
            student student = new student();

            //强制类型转换，由父类转换为子类会报错
            //

            student = (student)people;
            Console.WriteLine("转换成功！" + student.ToString());

        }
    }

    class people
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class student : people
    {
        public int Score { get; set; }
    }
}
