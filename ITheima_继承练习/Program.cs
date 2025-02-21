namespace ITheima_继承练习
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Father
    {
        public Father(string LastName, decimal Property, string BloodType)
        {
            this.LastName = LastName;
            this.property = Property;
            this.BloodType = BloodType;
        }

        public string LastName { get; set; } = string.Empty;
        public decimal property { get; set; }
        public string BloodType { get; set; } = string.Empty;
    }

    public class Son : Father
    {
        //在调用父类的构造器的时候设默认值是在父类里设置
        public Son(string LastName, decimal Property, string BloodType, uint Score) : base("Tom", Property, "A")
        {
            this.Score = Score;
        }
        public uint Score { get; set; }


        public void PlayGame()
        {
            Console.WriteLine("Son is playing game.");
        }
    }

    public class Daughter : Father
    {
        public Daughter(string LastName, decimal Property, string BloodType, double hight) : base("Tom", Property, "A")
        {

        }
        public double hight { get; set; }
        public void Dance()
        {
            Console.WriteLine("Daughter is dancing.");
        }
    }
}
