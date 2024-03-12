using System.Diagnostics.Contracts;
using System.Globalization;

public class JRCalculator
{
    public JRCalculator() 
    {
    }

    public void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("\tJump Rope Calculator");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine("1. Caclulate workout time.");
        Console.WriteLine("More soon");
        Console.WriteLine("--------------------------------------");
        Console.Write("Select a functionality ");
    }
    private static int GetValidInput()
    {
        bool validInput = false;
        int output = 0;
        // keeps asking for user input until the user gives a valid input
        while(!validInput) {
            string? input = Console.ReadLine();
            validInput = int.TryParse(input, out output);
            if (validInput) {
                output = Convert.ToInt32(input);
                break;
            }
            else {
                Console.WriteLine("Invalid choice!");
                Console.Write("Try again ");
            }
        }
        // return the input converted to int
        return output;
    }
    public int SelectFunctionality()
    {
        int input = 0;
        // asks the user what they want to do inside the app
        do {
            // asks the user for a valid input
            input = GetValidInput();
            if(input == 1) break;
            else {
                // only the first functionality of the app is currently implemented
                // if the user chooses other path, they will be reminded that that functionality isn't ready yet
                Console.WriteLine("Coming soon!");
                Console.Write("Please select other functionality ");
            }
        } while (input != 1);
        return input;
    }
    private int GetNumOfSets() // (1) helper method that prompts the user for the total number of sets
    {
        Console.Clear();
        Console.WriteLine("How many sets?");
        int numberOfSets = GetValidInput();
        return numberOfSets;
    }
    private int GetJumpTime(int sets) // (1) helper method that calculates the jump time in seconds
    {
        int setCount = 1;
        int input = 0;
        int jumpTime = 0;
        for(int i = 0; i < sets; i++) {
            Console.WriteLine($"How long did set number {setCount++} last? (in seconds)");
            input = GetValidInput();
            jumpTime += input;
            Console.Clear();
        }
        return jumpTime;
    }
    private double SecondsToMinutes(int jumpTimeSec) // (1) helper method that converts seconds into minutes
    {
        double finalJumpTime = Convert.ToDouble(jumpTimeSec);
        finalJumpTime /= 60;
        // returns the total jump time in minutes
        return finalJumpTime;
    }
    private void PrintJumpTime(double finalJumpTime) // (1) helper method that prints the final jumpt time
    {
        Console.WriteLine($"Your total jump time is {finalJumpTime} minutes!");
    }
    public void FirstChoice() // Code for the first functionality of the app
    {
        int numOfSets = GetNumOfSets();
        int jumpTime = GetJumpTime(numOfSets);
        double finalJumpTime = SecondsToMinutes(jumpTime);
        PrintJumpTime(finalJumpTime);
    }
}