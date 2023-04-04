// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace Loops_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Asks the user what their favorite video game genre is and why
            Console.WriteLine("What is your favorite video game genre and why?");
            // Assigns the user input to put under the string response
            string response = Console.ReadLine();
            // Tells user the sentence response has a number of spaces in it
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it, user.");

            // Asks the user to enter a whole number
            Console.WriteLine("User, please enter a whole number.");
            // Assigns the user input to put under the string response2
            string response2 = Console.ReadLine();
            // Tells user what the sum of the individual digits in response2 are.
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}, user.");
        }
        // Declares a static integer under method CountNumberOfSpaces
        static int CountNumberOfSpaces(string sentence)
        {
            // States integer numberOfSpaces is 0
            int numberOfSpaces = 0;
            // Declares a foreach statement to determine the characters in the character in sentence
            foreach(char character in sentence)
            {
                // Creates an if statement to show that if character equals ' ', then add numberOfSpaces
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            // returns the amount for numberOfSpaces
            return numberOfSpaces;
        }
        // Declares a static integer under method SumOfDigits
        static int SumOfDigits(string number)
        {
            // States integer sum is 0
            int sum = 0;
            // Declares a foreach statement to determine the character in the digit in number
            foreach (char digit in number)
            {
                // States sum is (int)Char.GetNumericValue(digit)
                sum += (int)Char.GetNumericValue(digit);
            }
            // Returns the amount for sum
            return sum;
        }
    }
}
