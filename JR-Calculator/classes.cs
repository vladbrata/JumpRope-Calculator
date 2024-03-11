using System.Diagnostics.Contracts;
using System.Globalization;

public class JRCalculator
{
    int numberOfSets;
    int[] time;
    double jumpTime;
    public JRCalculator() 
    {
    }

    public void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("\tJump Rope Calculator");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine("1. Caclulate workout time.");
        Console.WriteLine("\tMore soon");
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
    public double SelectFunctionality()
    {
        int input = 0;
        double output = 0;
        // int sets = 0;
        do {
            input = GetValidInput();
            switch (input) {
            case 1:
                numberOfSets = GetNumOfSets();
                output = GetSetsTime(ref numberOfSets);
                PrintJumpTime();
                break;
            case > 1:
                Console.WriteLine("Coming soon!");
                Console.WriteLine("Please select other functionalities");
                break;
            }
        } while (input > 1);
        
        return output;
    } 
    private static int GetNumOfSets()
    {
        Console.Clear();
        Console.WriteLine("How many sets?");
        int sets = GetValidInput();
        return sets;
    }
    public static double GetSetsTime(ref int sets)
    {
        int setCount = 1;
        double jumpTime = 0;

        for(int i = 0; i < sets; i++) {
            Console.WriteLine($"How long did set number {setCount} set last?");
            double input = Convert.ToDouble(Console.ReadLine());
            jumpTime += input;
            setCount++;
        }
        return jumpTime;
    }
    private void PrintJumpTime()
    {
        Console.WriteLine($"Your total jump time is {GetSetsTime(ref numberOfSets)} seconds");
    }
}