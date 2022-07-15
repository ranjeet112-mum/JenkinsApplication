using System;
using MyLogicClass;

namespace JenkinsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to jenkins Application");
            Console.WriteLine("Version 2");
            MyMath m = new MyMath();
            Console.WriteLine("3 + 4 = " + m.add(3, 4));
            Console.WriteLine("3 * 4 = " + m.mul(3, 4));
            Console.ReadLine();
            //test
        }
    }
}
