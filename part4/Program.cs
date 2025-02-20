using System.Security.Cryptography.X509Certificates;

namespace part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //变成很重要的一点就是“不要重复自己”

            for (int i = 1; i <10; i++) 
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i >= j) 
                    {
                        Console.Write($"{i}*{j}={i*j}\t");
                    }
                }
                Console.WriteLine();
            }

            //编写带有返回值的函数

            decimal result = CalculateTax(50,"CH");
            Console.WriteLine($"You should pay {result:c};");

            //调用斐波那契数列函数

            Console.WriteLine("请输入要计算斐波那契数列的截止数：");
            
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"第{i}个斐波那契是{FibImperative(i)}");
                
            }

        }


        /// <summary>
        /// 计算交税的金额,主方法体外的方法
        /// </summary>
        /// <param name="amount">花销</param>
        /// <param name="twoLetterRegionCode">税率</param>
        /// <returns></returns>
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0;
            switch (twoLetterRegionCode)
            {
                case "CH":
                    rate = 0.08M;
                    break;
                case "DK":
                case "FR":
                    rate = 0.25M;
                    break;
            }
            return amount * rate;
        }


        /// <summary>
        /// 计算斐波那契数列
        /// </summary>
        /// <param name="num">该参数为数列结束的位置</param>
        /// <returns></returns>
        static int FibImperative(int num)
        {
            if (num == 1)
            {
                return 0;
            }
            else if (num == 2)
            {
                return 1;
            }
            {
                return FibImperative(num-1)+FibImperative(num-2);
            }
        }
    }
}
