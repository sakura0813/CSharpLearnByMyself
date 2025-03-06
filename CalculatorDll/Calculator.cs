namespace CalculatorDll
{
    public abstract class Calculator
    {
        protected Calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double num1 { get; set; }
        public double num2 { get; set; }

        public abstract double Calculate();
    }
}
