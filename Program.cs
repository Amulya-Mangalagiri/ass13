using System.Threading.Tasks;
using System;

Task 1: Hello World

using System;

namespace BasicCSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}



Task 2: Variables and User Input

using System;

namespace BasicCSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
    }
}


Task 3: Basic Arithmetic

using System;

namespace BasicCSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");

            if (num2 != 0)
            {
                double division = (double)num1 / num2;
                double modulus = num1 % num2;

                Console.WriteLine($"Division: {division}");
                Console.WriteLine($"Modulus: {modulus}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
}


Task 4: Control Structures

using System;

namespace BasicCSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
    }
}


Task 5: Loops

using System;

namespace BasicCSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}



Task 6: Arrays

using System;

namespace BasicCSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }
    }
}


Task 7: Methods

using System;

namespace BasicCSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * CalculateFactorial(n - 1);
        }
    }
}





Task 8: Exception Handling

using System;

namespace AgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    if (age >= 0)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Age cannot be negative.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age (an integer).");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
        }
    }
}
