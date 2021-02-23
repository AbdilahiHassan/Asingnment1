using System;

namespace Asingnment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deleration 3 varible and inzl by 0?
            decimal number1 = 0;
            decimal number2 = 0;
            decimal num3 = number1 + number2;
            String result = "";
            //Reuseble method
            int Res = Culculate(10, 20);
            Console.ReadLine();
        }
        public static int Culculate(int number1, int number2)

        {

            //Deleration 3 varible and inzl by 0

            decimal num3 = number1 + number2;
            String result = "";

            Console.WriteLine(" Calculator ConsoleApp\r");
            Console.WriteLine("................................\n");

            //ask the user to put first number that he she want to count
            Console.WriteLine("Type the first number and press Enter");
            //Convert a intiger variable 
            try
            {
                number1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            //Type second number that  you want countf
            Console.WriteLine("Type Second number and press Enter");
            //number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Enter to see Result");
            //Convert a intiger variable 
            try
            {
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //Ask the use to choose a  option
            Console.WriteLine("choose a option from the following list that you want to count");
            Console.WriteLine("\ta - addition");
            Console.WriteLine("\ts - Subtraction");
            Console.WriteLine("\td - Devision");
            Console.WriteLine("\tm  -Multiplay");
            Console.WriteLine("Your option");
            //Swich sats that handling what user want to count 

            Console.WriteLine("Please enter a Number from the Options above");

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
            //test
            do
            {
                Console.WriteLine("If you want count again contue to count press Enter");
                //Convert a intiger variable 
                try
                {
                    number1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
                //Type second number that  you want countf
                Console.WriteLine("Type Second number and press Enter");
                //number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press Enter to see  your Result");
                //Convert a intiger variable 
                try
                {
                    number2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                //Ask the use to choose a  option
                Console.WriteLine("choose a option from the following list that you want to count");
                Console.WriteLine("\ta - addition");
                Console.WriteLine("\ts - Subtraction");
                Console.WriteLine("\td - Devision");
                Console.WriteLine("\tm  -Multiplay");
                Console.WriteLine("Your option");
                //Swich sats that handling what user want to count 

                Console.WriteLine("Please enter a Number from the Options above");

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

                result = Console.ReadLine();
            } while (!result.Equals(number1 + number2));


            do
            {
                Console.WriteLine("you get the wron answe");
                result = Console.ReadLine();

            } while (result.Equals(number1 + number2));


            string choice = Console.ReadLine();
            Console.ReadKey();
            return number1 + number2;
        }
        
     


    }

}


