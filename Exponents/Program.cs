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
            while (goOn == true)
            {
                //Asks for input
                int num = int.Parse((GetInput("Enter an integer")));
                Console.WriteLine();
                            
                //Supposed to check for input validation. Can't get non-integers to work
                bool validNum = Check(num);               

                //Runs loop for operations if integer passes initial validation. Can't get formatting to work
                if (validNum == true)
                {
                    
                    for(int i = 1; i <= num; i++)
                    {                        
                        string a = Convert.ToString(i);
                        string new1 = String.Format("{0, -20}", a);
                        Console.WriteLine(new1);
                    }

                    Console.WriteLine();
                    for (int  j= 1;  j<= num; j++)
                    {
                        string b = Convert.ToString(getSquared(j));
                        string.Format($"{b, 10}");                        
                    }

                    Console.WriteLine();
                    for (int k = 1; k <= num; k++)
                    {
                        string c = Convert.ToString(getCubed(k));
                        string.Format(c, 30);                        
                    }
                }
                else
                {
                    validNum = false;
                    Console.WriteLine($"Please insert a number");                    
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
            int square = num * num;            
            Console.WriteLine(square);
            Convert.ToString(square);
            return square;
        }

        //Cubes the entered integer
        public static int getCubed(int num)
        {
            int cube = num * num * num;
            Console.WriteLine(cube);
            Convert.ToString(cube);

            return cube;
        }

        //Supposed to check the integer for validation during initial entry. Can't get it to work
        public static bool Check(int valid)
        {
            string v = Convert.ToString(valid);

            if (valid > 0)
            {
                return true;
            }
            else if (valid < 0)
            {                                
                return false;
            }
            else
            {
                Console.WriteLine("Please try again");
                return false;
            }
        }        
    }
}
