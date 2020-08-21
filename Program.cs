using System;

namespace VariableConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            int age;
            string name;
            bool hasPet;
            char letter;
            double gpa;
            decimal mathGrade;

            // Variable initalizations
            age = 26;
            name = "Dani";
            hasPet = true;
            letter = 'A';
            gpa = 3.95;
            mathGrade = 98.99m;

            Console.WriteLine($"{name} is {age} years old. \n" + $"Does {name} have a pet? {hasPet}.");
            Console.WriteLine($"{name} has a gpa of {gpa} \n" + $"She has the grad {letter} in math. Her math grade is {mathGrade}.");
        }
    }
}
