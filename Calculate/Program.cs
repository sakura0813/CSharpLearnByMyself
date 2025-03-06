using CalculatorDll;

namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入一个数字");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入要进行什么计算：");
            string operators = Console.ReadLine();


            Calculator? cal = GetComputeObject(operators, d1, d2);


            double result = cal.Calculate();
            Console.WriteLine($"计算结果为：{result}");

        }
        //简单工厂模式，根据输入的运算符返回对应的计算类
        private static Calculator? GetComputeObject(string? operators, double d1, double d2)
        {

            Calculator result = null;
            switch (operators)
            {

                case "+":
                    result = new Add(d1, d2);
                    break;
                case "-":
                    result = new Sub(d1, d2);
                    break;
            }
            return result;
        }
    }
    //加法类
    class Add : Calculator
    {

        //带参数的构造函数，在实例化的时候调用
        //在这里需要继承父类的构造函数
        public Add(double num1, double num2) : base(num1, num2)
        {
            num1 = this.num1;
            num2 = this.num2;
        }
        //重写父类的计算函数为加法
        public override double Calculate()
        {
            return num1 + num2;
        }
    }
    //减法类
    class Sub : Calculator
    {
        //带参数的构造函数，在实例化的时候调用
        //在这里需要继承父类的构造函数
        public Sub(double num1, double num2) : base(num1, num2)
        {
            num1 = this.num1;
            num2 = this.num2;
        }
        //重写父类的计算函数为减法
        public override double Calculate()
        {
            return num1 - num2;
        }
    }
}
