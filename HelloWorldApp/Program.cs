using System;
using test;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Test name = new Test("Hello World");
            Console.WriteLine(name.getString());
        }
    }
}
