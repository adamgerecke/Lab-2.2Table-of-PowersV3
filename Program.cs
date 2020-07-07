using System;

namespace Lab_2._2_Table_of_Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true; //Bool set for use with the program loop if true, program keeps looping.
            
            //Title line to display what the program is doing - located outside of the loop as to only display once if invalid inputs are made
            Console.WriteLine("Learn your squares and cubes!");

            while (keepGoing) // Starts the while loop to keep looping the program, unless the users requests to exit.
            {
                //Prompts the user to input an intiger, converts that string into a integer the program will be able to do some math on
                Console.Write("Enter an integer:");
                string input = Console.ReadLine();
                int userInt = int.Parse(input);

                if (userInt <= 0)  // Checks to make sure the integer entered is valid, no 0's or negitives
                {
                    Console.WriteLine("That is not a valid input");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                else if(userInt > 1290) //1290 is the cube root of the max 32bit integer (2,147,483,647)
                {
                    Console.WriteLine("Number is too large. Please use a smaller number.");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                else
                {


                    //Displays the number from 1 to number entered by the user that number squared, and cubed.
                    Console.WriteLine("Number\t\t\tSquared\t\t\tCubed");
                    Console.WriteLine("=======\t\t\t=======\t\t\t=======");

                    for (int i = 1; i <= userInt; i++)
                    {
                        Console.WriteLine(string.Format("{0,7}{1,24}{2,24}", i, Math.Pow(1,2), Math.Pow(i,3)));
                        //Console.WriteLine($"{i}\t\t\t{Math.Pow(i, 2)}\t\t\t{Math.Pow(i, 3)}");
                    }

                    Console.Write("Continue? (y/n):");
                    string exit = Console.ReadLine();
                    exit = exit.ToUpper();

                    if (exit == "N" || exit == "NO") // exits the program if the user inputs n or no when asked if they want to calculate another number
                    {
                        keepGoing = false;
                        Console.WriteLine("Have a great day!");
                    }
                    else if (exit != "Y" && exit != "YES") // exits the program with an invalid input message unless y or yes is used to restart the loop
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
