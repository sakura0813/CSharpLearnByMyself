using Part5ClassLibrary;
using System.Runtime.Versioning;
using static Part5ClassLibrary.Car;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new()
            {
                ID = 1,
                Name = "sakura",
                Age = 80
            };

            person.SayHello();

            Console.WriteLine("------------------------------");


            Person person1 = new Person();
            person1.ID = 2;
            person1.Name = "Tom";
            person1.Age = 12;
            person1.DateOfBirth = new(1995, 08, 13);
            person1.FavoriteAncientWonder = WorldsOfTheAncientWorld.StatueOfZeusAtolympia;

            person1.Children.Add(new() { Name = "Alfred", Age = 13 });
            person1.Children.Add(new() { Name = "Smith", Age = 15 });

            Console.WriteLine($"Person1 有{person1.Children.Count}个孩子！");
            for (int i = 0; i < person1.Children.Count; i++)
            {
                Console.WriteLine($"第{i + 1}个孩子是{person1.Children[i].Name},年龄：{person1.Children[i].Age}");
            }

            person1.SayHello();
            Console.WriteLine($"我最喜欢的名胜是：{person1.FavoriteAncientWonder}");
            Console.WriteLine(format: "我的生日是：{0:yyyy,MMMM,dd}", arg0: person1.DateOfBirth);

            //调用元组
            var Fruit = person1.GetFruit();
            Console.WriteLine($"{person1.Name}喜欢{Fruit.Name},他买了{Fruit.Number}斤。");

            //调用析构元组的函数
            var (name1, age1) = person1;
            Console.WriteLine($"{name1}的年龄是{age1}。");

            var (name2,age2,fov) = person1;
            Console.WriteLine($"{name2}的年龄是{age2},我最喜欢{fov}。");

            Console.WriteLine("-----------------------------------------------");

            BankAccount.InterestRate = 0.012M;
            BankAccount TimAccount = new()
            {
                AccountName = "Mrs.Tim",
                Balance = 2400
            };
            Console.WriteLine(format: "{0} earned {1:c} interest.", arg0: TimAccount.AccountName, arg1: TimAccount.Balance * BankAccount.InterestRate);

            BankAccount sakuraAccount = new()
            {
                AccountName = "sakura",
                Balance = 100000
            };

            Console.WriteLine(format:"{0} earned {1:c} interest.",arg0:sakuraAccount.AccountName,arg1:sakuraAccount.Balance*BankAccount.InterestRate);

            Console.WriteLine("======================================");
            Vehicle v = new Car();
            v.Stop();
            Vehicle v1 = new Truck();
            v1.Stop();



        }
    }
}
