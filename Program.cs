using System;

namespace Lab_2._2_Table_of_Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            //Title line to display what the program is doing
            Console.WriteLine("Learn your squares and cubes!");

            while (keepGoing)
            {



                //Prompts the user to input an intiger, converts that string into a integer the program will be able to do some math on
                Console.Write("Enter an integer:");
                string input = Console.ReadLine();
                int userInt = int.Parse(input);

                if (userInt <= 0)
                {
                    Console.WriteLine("That is not a valid input");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                else
                {


                    //Displays the number from 1 t number entered that number squared, and cubed.
                    Console.WriteLine("Number\t\t\tSquared\t\t\tCubed");
                    Console.WriteLine("=======\t\t\t=======\t\t\t=======");

                    for (int i = 1; i <= userInt; i++)
                    {
                        Console.WriteLine($"{i}\t\t\t{Math.Pow(i, 2)}\t\t\t{Math.Pow(i, 3)}");
                    }

                    Console.Write("Continue? (y/n):");
                    string exit = Console.ReadLine();
                    exit = exit.ToUpper();

                    if (exit == "N" || exit == "NO")
                    {
                        keepGoing = false;
                        Console.WriteLine("Have a great day!");
                    }
                    else if (exit != "Y" && exit != "YES")
                    {
                        Console.WriteLine("That is not a valid input. The program will now stop.");
                        Console.WriteLine("Have a great day!");
                        keepGoing = false;
                    }
                }
            }
        }
    }
}   
