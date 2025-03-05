namespace ITheima_继承和多态
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LSP里氏替换原则，为了多态才这样声明
            People Tom = new Student(1, "Tom", "男", "90");
            People MissLiu = new Teacher(2, "Liu Tiemeng", "男", "70000");
            Tom.Name = "Tom";
            MissLiu.Name = "Liu Tiemeng";
            Tom.SayHello();
            MissLiu.SayHello();
            Console.WriteLine($"He is {Tom.Name},and his teacher's name is {MissLiu.Name}");
            Console.ReadKey();
        }
    }

    class People
    {
        //因为在Student和Teacher继承People,而People的两个子类都有自己的构造函数，而一旦调用构造函数，子类会在父类中寻找一个无参的构造函数，如果没有会出错，所以需要在这里加一个无参构造函数。
        //为了不报错还有一种解决方式，就是让子类的构造函数继承父类的构造函数；详见58行
        public People()
        {

        }
        //使用这种方法相当于重载构造函数
        public People(int Id) : this(Id, "Tom", "男")
        {
            this.Id = Id;
        }
        public People(int Id, string Name) : this(Id, Name, "男")
        {
            this.Name = Name;
            this.Id = Id;
        }
        public People(int Id, string Name, string Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        public virtual void SayHello()
        {
            Console.WriteLine("People's Sayhello!");
        }
    }

    class Student : People
    {
        //让子类的构造函数继承父类的构造函数，使用:base()指定调用父类的构造函数
        //父类不能自动继承只能手动调用
        public Student(int Id, string Name, string Gender, string Score) : base(Id, Name, Gender)
        {
            this.Score = Score;
        }
        //public Student(int Id, string Name, string Gender, string Score)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Gender = Gender;
        //    this.Score = Score;
        //}
        //public int Id { get; set; }
        //public string Name { get; set; } = string.Empty;
        //public string Gender { get; set; } = string.Empty;
        public string Score { get; set; } = string.Empty;
        public override void SayHello()
        {
            Console.WriteLine("studnt's Sayhello!");
        }

    }

    class Teacher : People
    {
        public Teacher(int Id, string Name, string Gender, string Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.Salary = Salary;
        }
        //public string Name { get; set; } = string.Empty;
        //public string Gender { get; set; }
        //= string.Empty;
        public string Salary { get; set; } = string.Empty;
        public override void SayHello()
        {
            Console.WriteLine("teacher's Sayhello!");
        }
    }
}
