namespace ITheima_抽象类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abclass ab = new myclass();
            ab.SayHello();
        }
    }
    //4.抽象类不能够被实例化
    abstract class Abclass
    {
        //1.抽象类里可以有实例成员也可以有抽象成员
        //实例成员
        public int ID { get; set; }
        //抽象成员
        public abstract string Name { get; set; }

        //2.抽象成员不能有具体的实现
        //3.抽象成员必须包含在抽象类中
        public abstract void SayHello();

    }
    //5.继承抽象类的子类必须实现抽象类里的抽象成员，使用override重写，除非子类也是抽象类
    class myclass : Abclass
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void SayHello()
        {
            Console.WriteLine("子类中重写的！");
        }
    }
}
