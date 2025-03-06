namespace ITheima_抽象类练习U盘案例
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Computer computer = new Computer();
            MobileStorageDevice usbDevice = new USBDrive();
            MobileStorageDevice mp3 = new MP3();

            computer.Dev = usbDevice;
            computer.ComputerWrite();
            computer.ComputerRead();

            computer.Dev = mp3;
            computer.ComputerWrite();
            computer.ComputerRead();

        }
    }

    /// <summary>
    /// 抽象移动储存设备
    /// </summary>
    abstract class MobileStorageDevice
    {
        public abstract void write();
        public abstract void read();
    }
    /// <summary>
    /// U盘继承移动储存设备。实现具体的读写操作
    /// </summary>
    class USBDrive : MobileStorageDevice
    {
        public override void read()
        {
            Console.WriteLine("u盘的读操作完成！");
        }

        public override void write()
        {
            Console.WriteLine("u盘的写操作完成！");
        }
    }
    /// <summary>
    /// MP3继承移动储存设备。实现具体的读写操作
    /// </summary>
    class MP3 : MobileStorageDevice
    {
        public override void read()
        {
            Console.WriteLine("MP3的读操作完成！");
        }

        public override void write()
        {
            Console.WriteLine("MP3的写操作完成！");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3的播放操作完成！");
        }
    }

    /// <summary>
    /// 电脑类
    /// </summary>
    class Computer
    {
        //通过添加抽象方法类型的属性，让实例后的属性值等于实现抽象方法的具体类的实例，可以实现USB设备插入电脑的操作。
        public MobileStorageDevice Dev { get; set; }

        public void ComputerWrite()
        {
            Dev.write();
        }
        public void ComputerRead()
        {
            Dev.read();
        }
        public void PlayGame()
        {
            Console.WriteLine("电脑玩游戏！");
        }
    }
}
