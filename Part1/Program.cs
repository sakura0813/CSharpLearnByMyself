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

            #endregion
        }
    }
}
