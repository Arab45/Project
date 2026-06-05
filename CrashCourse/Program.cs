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
            int total = 34;
            int final = (int)Math.Sqrt(total);
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // bool isOdd;
            // bool isEven;

            Console.WriteLine("Welcome to the game");
            Console.WriteLine("Guess a number between 1 and 101");
            Console.WriteLine("If you guess even number you win");
            Console.WriteLine("If you guess odd number you win");
            Console.WriteLine("Good luck");

            Random random = new Random();

            bool playAgain = true;

            while (playAgain)
            {
                int randomNumber = random.Next(1, 11);

                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == randomNumber)
                {
                    Console.WriteLine("Congratulations, you guessed the number");

                    switch (randomNumber % 2)
                    {
                        case 0:
                            Console.WriteLine("You guessed an even number");
                            break;

                        case 1:
                            Console.WriteLine("You guessed an odd number");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Wrong! Correct number was {randomNumber}");
                }

                Console.Write("Try again? (yes/no): ");
                string answer = Console.ReadLine() ?? "";

                answer = answer.ToLower();

                playAgain = answer == "yes";
            }

            Console.WriteLine("Game ended.");





            Console.WriteLine(final);
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
            }
            else
            {
                Console.WriteLine("Closed");
            }
        }
    };
};