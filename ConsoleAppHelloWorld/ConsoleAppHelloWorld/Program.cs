using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    class Program
    {
        private const string Value = "Welcome to my 1st Application";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!!");
            Console.WriteLine(Value);
            Console.ReadKey();
        }
    }
}
