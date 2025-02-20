namespace part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //操作变量 +，-，*，/，x++，++x,x--,--x

            int a1 = 1;
            //在这里是a先进行赋值，在进行自增1运算
            int b1 = a1++;

            Console.WriteLine($"a1 is {a1},b1 is {b1}");

            //相反的实例

            int c = 2;
            int d = ++c;

            Console.WriteLine($"c is {c},d is {d}");


            //bool运算符  or and orx（逻辑异或，相当于!=，只要比较双方不相同，结果就为true）

            bool a = true;
            bool b = false;

            Console.WriteLine($"AND |a      |b");
            Console.WriteLine($"a   |{a & b,-5}|{a & b,-5}");
            Console.WriteLine($"a   |{b & a,-5}|{b & b,-5}");
            Console.WriteLine();
            Console.WriteLine($"OR  |a     |b");
            Console.WriteLine($"a   |{a | b,-5}|{a | b,-5}");
            Console.WriteLine($"a   |{b | a,-5}|{b | b,-5}");
            Console.WriteLine();
            Console.WriteLine($"XOR |a      |b");
            Console.WriteLine($"a   |{a ^ b,-5}|{a ^ b,-5}");
            Console.WriteLine($"a   |{b ^ a,-5}|{b ^ b,-5}");

            //类型转换，

            //从一个小的变量类型赋值到更大的数据类型，数据不会受到损失
            int c1 = 10;
            double c2 = c1;
            Console.WriteLine($"c2 is {c2}");

            //从一个更大的数据类型转换为一个更少的数据类型，数据会受到损失
            double d1 = 2.1;
            //强制转换为int
            int d2 = (int)d1;
            Console.WriteLine($"d2 is {d2}");

            //使用System.Convert类型进行转换

            double g = 9.8;
            //在这里，h是10，因为向上圆整，0.5向上进1，0.5，以下忽略。如果是0.5的话，看各位奇数向上圆整，单数向下圆整
            int h = System.Convert.ToInt32(g);
            Console.WriteLine($"h is {h}");

            int number = 12;
            Console.WriteLine(number.ToString());

            bool boolean = false;
            Console.WriteLine(boolean.ToString());

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());

            //使用Parse转换类型
            int age = 10;
            DateTime birthday = DateTime.Parse("4 july 1980");

            Console.WriteLine($"age 转换为 {age}");
            Console.WriteLine($"birthday 转换为 {birthday}");

            //但是使用Parse会引发异常,这个不能转换，会引发异常
            //int count = int.Parse("abc");

            //为了避免异常可以使用TryParse

            Console.WriteLine("How many eggs are there?");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int count))
            {
                Console.WriteLine($"There are {count}");
            }
            else
            {
                Console.WriteLine("There are something wrong!");
            }


            //处理异常
            Console.WriteLine("WHat's your age?");

            string? myAge = Console.ReadLine();
            try
            {
                int myAgeParse = int.Parse(myAge);
                Console.WriteLine($"My age is {myAgeParse}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            Console.WriteLine("End Parse");

            //使用过滤器捕获异常
            
            Console.WriteLine("Enter an amount:");
            string? amount = Console.ReadLine();

            try
            {
                decimal dc = decimal.Parse(amount);
            }
            //在catch后添加when语句，用于添加过滤条件
            catch (FormatException) when (amount.Contains("$"))
            {

                Console.WriteLine("amount cannot use $ sign!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Amount must only contain digits");
            }

            //检查溢出

            try
            {
                checked
                {
                    int intcheck = int.MaxValue - 1;
                    for (int i = 0; i < 8; i++)
                    {
                        intcheck++;
                        Console.WriteLine($"After incrementing :{intcheck}");
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The code overflowed but I caught the exception");
            }



        }
    }
}
