using System;

namespace LoopHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name : Evlyn
            //Date: 2023-09-15
            //Description : Loop Homework
            {
                int num1 = 0;
                while (num1 != 15)
                {
                    Console.WriteLine("Enter a number between 1-30");
                    try
                    {
                        num1 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("This is an illegal input Enter a number or be gone!");
                    }
                    if (num1 < 15 && num1 > 0)
                    {
                        Console.WriteLine("Bigger!");
                    }
                    else if (num1 > 15 && num1 < 30)
                    {
                        Console.WriteLine("Smaller!");
                    }
                    else if (num1 > 30 || num1 < 0)
                    {
                        Console.WriteLine("The number is out of bounds");
                    }
                }
                Console.WriteLine("You Have Entered the right number!!");
                Console.ReadLine();
            }
        }
    }
}
