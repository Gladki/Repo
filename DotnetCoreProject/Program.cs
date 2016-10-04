using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var val = new TestClass();
            val.Val1 = 2;
            val.Val2 = 3;

            Console.Write($"aaa{0}",val.Val1);


        }
    }
}
