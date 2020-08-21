using System;

namespace VariableConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} /n" + "How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

        }
    }
}
