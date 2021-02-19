using System;

namespace Asingnment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deleration 2 varible and inzl by 0
            decimal number1 = 0;
            decimal number2 = 0;

             Console.WriteLine(" Calculator ConsoleApp\r");
            Console.WriteLine("................................\n");

            //ask the user to put first number that he she want to count
            Console.WriteLine("Type a number that you want to count and then press Entr");
            //Convert a intiger variable 
            number1 = Convert.ToInt32(Console.ReadLine());
            //Type second number that  you want count
            Console.WriteLine("Type another number and press Enter");
            number2 = Convert.ToInt32(Console.ReadLine());
            //Ask the use to choose a  option
            Console.WriteLine("choose a option from the following list that you want to count");
            Console.WriteLine("\ta - addition");
            Console.WriteLine("\ts - Subtraction");
            Console.WriteLine("\td - Devision");
            Console.WriteLine("\tm  -Multiplay");
            Console.WriteLine("Your option");
            //Swich sats that handling what user want to count 
            switch (Console.ReadLine())
            {
                case "a":
                    //Here I want to add 2 number and then display to consle there I use $ to come to vari
                    //variable and then concat the varible
                    Console.WriteLine($"your result is: {number1}+ {number2} =" + (number1 + number2));
                    break;
                case "s":
                    Console.WriteLine($"your result is: {number1}- {number2} =" + (number1 - number2));
                    break;
                case "d":
                    //Here I'm using while loop to handle a zero
                    //So if a user want devide by zero the app is asking question
                    while (number2 == 0)
                    {
                        Console.WriteLine("Sorry please Enter a non Zero devision");
                        number2 = Convert.ToInt32(Console.ReadLine());

                    }
                   Console.WriteLine($"your result is: {number1}/{number2} =" + (number1 / number2));
                    break;
                case "m":
                    Console.WriteLine($"your result is: {number1}*{number2} =" + (number1 * number2));
                    break;

            }
            //The App will be waiting antill the press any key
            Console.WriteLine("Press any key to close the console");

            Console.ReadKey();
        }

    }

}

