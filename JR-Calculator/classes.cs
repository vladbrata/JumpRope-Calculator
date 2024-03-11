using System.Diagnostics.Contracts;
using System.Globalization;

public class JRCalculator
{
    // int[] time;
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
        return output;
    }
    public int SelectFunctionality()
    {
        int input = 0;
        do {
            input = GetValidInput();
            if(input == 1) break;
            else {
                Console.WriteLine("Coming soon!");
                Console.Write("Please select other functionality ");
            }
        } while (input != 1);
        return input;
    }
    public void FirstChoice()
    {
        int numOfSets = GetNumOfSets();
        int jumpTime = GetJumpTime(numOfSets);
        double finalJumpTime = SecondsToMinutes(jumpTime);
        PrintJumpTime(finalJumpTime);
    }
    private int GetNumOfSets()
    {
        Console.Clear();
        Console.WriteLine("How many sets?");
        int numberOfSets = GetValidInput();
        return numberOfSets;
    }
    private int GetJumpTime(int sets)
    {
        int setCount = 1;
        int input = 0;
        int jumpTime = 0;
        for(int i = 0; i < sets; i++) {
            Console.WriteLine($"How long did set number {setCount++} last?");
            input = GetValidInput();
            jumpTime += input;
            Console.Clear();
        }
        return jumpTime;
    }
    private double SecondsToMinutes(int jumpTimeSec)
    {
        double finalJumpTime = Convert.ToDouble(jumpTimeSec);
        finalJumpTime /= 60;
        return finalJumpTime;
    }
    private void PrintJumpTime(double finalJumpTime)
    {
        Console.WriteLine($"Your total jump time is {finalJumpTime} minutes!");
    }
}