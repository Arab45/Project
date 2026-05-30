using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 34;
            double gradePoint = 33.50;
            char grade = 'A';
            String name = "Ola David";
            bool isValid = true;
            const double PI = 3.26;
            int balance = Convert.ToInt32(PI);
            // int size;
            Console.WriteLine("What is your name\b: ");
            Console.Read();
            Console.WriteLine(balance.GetType());
            Console.WriteLine(isValid);
            Console.WriteLine("My name is " + name + " i am " + age + " years old " + " with grade point of " + gradePoint + " grade of " + grade);
            Console.WriteLine(gradePoint);
            Console.WriteLine(grade);
            Console.WriteLine(age);
            Console.WriteLine("Hello, World!");

            if (isValid)
            {
                Console.WriteLine("You can go ahead");
            } else
            {
                Console.WriteLine("Closed");
            }
        }
    };
};