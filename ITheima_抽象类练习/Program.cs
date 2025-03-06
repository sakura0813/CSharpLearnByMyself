namespace ITheima_抽象类练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //在实例化类的时候这样才有意义，才能够通过抽象方法实现多态
            Animal dog = new Dog();
            dog.SayHi();
            dog.Eat();
            Animal cat = new Cat();
            cat.SayHi();
            cat.Eat();
        }
    }

    abstract class Animal
    {
        public abstract void SayHi();
        public abstract void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("吃骨头");
        }

        public override void SayHi()
        {
            Console.WriteLine("汪汪汪~~~");
        }
    }
    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("吃鱼🐟");
        }

        public override void SayHi()
        {
            Console.WriteLine("喵喵喵~~~");
        }
    }
}
