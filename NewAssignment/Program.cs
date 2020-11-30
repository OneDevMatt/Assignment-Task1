using System;

namespace NewAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            firstTask();
        }


        static void firstTask()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int sum = num1 + num2;
                if (num1 == 30)
                {
                    Console.WriteLine("true");
                }
                else if (num2 == 30)
                {
                    Console.WriteLine("true");
                }
                else if (sum == 30)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("None of the numbers, nor the sum of the numbers entered is 30");
                }
            }
            catch
            {
                Console.WriteLine("Wrong Value input, Enter a Number");
            }

            /*Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            if (firstNumber == 30)
            {
                Console.WriteLine("true");
            }
            else if (secondNumber == 30)
            {
                Console.WriteLine("true");
            }
            else if(sum == 30)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("None of the numbers nor the sum of the numbers entered is 30");
            }
            //Console.WriteLine("The sum of both numbers is " + sum);*/
            


        }
    }
}
