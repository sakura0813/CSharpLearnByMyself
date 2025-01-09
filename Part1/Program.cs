namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //在书中的P46提到了一种命名空间的引用：global using system，这意味着只需要在一个.cs文件中引入命名空间，其他文件都可以使用！建议单独建立一个GlobalUsings.cs文件来单独管理命名空间的引用！

            #region 2.3.3储存文本
            
            //单个的字符：char
            char letter = 'A';
            char digit = '2';
            char symbol = '$';

            //字符串
            string firstNeme = "Bob";
            string phoneNumber = "1234567890";

            //转义字符
            string fullName = "Bob\tsmith";

            //但是如果在出现文件路径时，不需要转义，只需要在字符串双引号前加“@”，添加了@符号后，双引号里的字符串中的空格也会被输出，eg：

            string filePath = @"C:\tools";

            //如果表示反斜杠，可以用“\\”

            string fileName = "C:\\windows";
            Console.WriteLine(letter);

            Console.WriteLine(firstNeme,phoneNumber,fullName,filePath,fileName);

            //储存数字

            //永远不要用“==”来比较两个double值，不然会出错
            
            Console.WriteLine("Using doubles:");
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a}+{b}=0.3");
            }
            else
            {
                Console.WriteLine($"{a}+{b}≠{0.3}");
            }
            //对double类型进行运算实验
            double c = 0.1;
            double d = 0.2;
            double e = c + d;
            //计算结果并不是0.3
            Console.WriteLine($"{c}+{d}={e}");

            //decimal的使用
            Console.WriteLine("Using decimal:");
            decimal de1 = 0.1m;
            decimal de2 = 0.2m;
            if (de1 + de2 == 0.3m)
            {
                Console.WriteLine($"{a}+{b}=0.3");
            }
            else
            {
                Console.WriteLine($"{a}+{b}≠{0.3}");
            }

            //布尔值
            bool happy = true;
            bool sad = false;

            //动态存储类型dynamic,此类型可以随意转换成其他类型变量，而不需要拆箱装箱，但是会损失性能
            dynamic something = 12;
            something = "Tom";
            something = new[] { 1, 2, 3 };

            Console.WriteLine($"Length is {something.Length}");

            //使用var来定义变量，让编译器来自主推断变量的类型
            //L:long
            //UL:ulong
            //M:decimal
            //D:double
            //F:float

            var population = 66666666;
            var weight = 1.88;
            var price = 2.99M;
            var fruit = "apples";
            var letter1 = 'z';
            var happy1 = false;


            //为各种类型的变量设置默认值
            Console.WriteLine($"default(int)={default(int)}");
            Console.WriteLine($"default(bool)={default(bool)}");
            Console.WriteLine($"default(DateTime)={default(DateTime)}");
            Console.WriteLine($"default(string)={default(string)}");
            Console.WriteLine($"default(double)={default(double)}");

            //在数组中储存多个值，eg：
            string[] names = { "Tom", "sakura", "jack" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


            //2.4向用户显示输出

            //对字符串进行格式化输出

            int numberOfApples = 12;
            decimal pricePerApple = 0.3M;

            Console.WriteLine(
                format: "{0} apples cost {1:c}",
                arg0:numberOfApples,
                arg1:pricePerApple*numberOfApples
                );

            string formatted = string.Format(
                format: "{0} apples cost {1:c}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
                );
            Console.WriteLine(formatted);

            //定义变量姓和名；
            string xing = "Tom";
            string ming = "Tony";
            string fullName1 = xing+ming;
            Console.WriteLine(fullName1);


            string applesText = "Apples";
            int applesCount = 1234;

            string bananaText = "Bananans";
            int bananaCount = 5678;

            Console.WriteLine(
                format: "{0,-10}{1,6:N0}",
                arg0:applesText,
                arg1:applesCount
                );

            Console.WriteLine(
                format: "{0,-10}{1,6:N0}",
                arg0: bananaText,
                arg1: bananaCount
                );

            //从用户哪里获取文本输入
            Console.WriteLine("Type your first name and press Enter:");
            //输入的字符串可以为空
            string? firstName = Console.ReadLine();
            Console.WriteLine("Type your first age and press Enter:");
            string? age = Console.ReadLine();

            Console.WriteLine($"{firstName},you look good for {age}");

            #endregion
        }
    }
}
