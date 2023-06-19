using System;

namespace NumberGuesser
{

    //Main Class
    class Program
    {

        //Entry point
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            
            while (true)
            {
                //Init correct number
                //int correctNumber = 10;

                //Create a random correct number

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess variable
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number!");

                        //Keep going 
                        continue;
                    }

                    //Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                        //Reset text color
                        ResetColour();
                    }
                }

                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!");

                //Reset text color
                ResetColour();

                //Ask to play again
                Console.WriteLine("Play again ? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper() ;

                if ( answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        //Get and display app info

        static void GetAppInfo()
        {
            //Seting app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sandile Ndimande";

            //Change text color

            Console.ForegroundColor = ConsoleColor.Magenta;

            //Write app information
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            ResetColour();
        }

        //Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name? ");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

       //print color message
       static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user it's the right number
            Console.WriteLine(message);

            //Reset text color
            ResetColour();
        }

        //Reset color
        static void ResetColour()
        {
            Console.ResetColor();
        }
    }
}
