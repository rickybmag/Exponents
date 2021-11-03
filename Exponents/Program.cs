using System;

namespace Exponents
{
    class Program
    {

        /* App prompts user to input an integer - Check!
         * Application displays a table os squares and cubes from 1 to integer entered
         * App promps the user to cotinue - Check!
         * 
         * -BONUS-         
         * Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number
         * Research formatted strings and right-align the numbers in columns instead of left-aligning them
         * Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less
         */

        static void Main(string[] args)
        {
            //Continues loop of whole operation
            bool goOn = true;
            int num;
            bool validNum = false;
            while (goOn == true)
            {
                //Asks for input
                //**Rearranged code here to check for a positive number input
                while (true)
                {
                    if (int.TryParse(GetInput("Enter an integer"), out num))
                    {
                        if (Check(num))
                        {
                            validNum = true;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n~INVALID INPUT: Please enter a non-negative whole number~");
                    }
                }
                //Runs loop for operations if integer passes initial validation. Can't get formatting to work
                if (validNum)
                {

                    for (int i = 1; i <= num; i++)
                    {
                        string a = Convert.ToString(i);
                        string new1 = String.Format("{0, -20}", a);
                        Console.WriteLine(new1);
                    }

                    Console.WriteLine();
                    for (int j = 1; j <= num; j++)
                    {
                        string b = Convert.ToString(getSquared(j));
                        string.Format($"{b,10}");
                    }

                    Console.WriteLine();
                    for (int k = 1; k <= num; k++)
                    {
                        string c = Convert.ToString(getCubed(k));
                        string.Format(c, 30);
                    }
                }
                goOn = Continue();
            }
        }

        //Promps user to input integer
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        //Ask if user wants to continue after entering integer
        public static bool Continue()
        {
            string answer = GetInput("Would you like to enter another number? (Y/N)");
            Console.WriteLine();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Deuces!");
                return false;
            }
            else
            {
                Console.WriteLine("Please Try again");
                Console.WriteLine();
                return Continue();
            }
        }

        //Squares the entered integer
        public static int getSquared(int num)
        {
            //Added check call here to validate num within method
            if (Check(num))
            {
                int square = num * num;
                Console.WriteLine(square);
                Convert.ToString(square);
                return square;
            }
            return 0;
        }

        //Cubes the entered integer
        public static int getCubed(int num)
        {
            //Added check call here to validate num within method
            if (Check(num))
            {
                int cube = num * num * num;
                Console.WriteLine(cube);
                Convert.ToString(cube);
                return cube;
            }
            return 0;

        }

        //Supposed to check the integer for validation during initial entry. Can't get it to work
        public static bool Check(int valid)
        {
            if (valid > 0)
            {
                return true;
            }
            //Removed extra if statement to check for negatives. 
            Console.WriteLine("Please try again");
            return false;

        }
    }
}
