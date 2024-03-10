using System.Diagnostics.Contracts;
using System.Globalization;

public class JRCalculator
{
    int numberOfSets;
    int[] time;
    public JRCalculator(int numberOfSets) 
    {
        time = new int[numberOfSets];
    }

    public static void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("\tJump Rope Calculator");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine("1. Caclulate workout time.");
        Console.WriteLine("\tMore soon");
        Console.WriteLine("--------------------------------------");
        Console.Write("Select a functionality ");
    }
    public static int GetValidInput()
    {
        bool validInput = false;
        int output = 0;
        while(!validInput) {
            string? input = Console.ReadLine();
            validInput = int.TryParse(input, out output);
            if(validInput) validInput = true;
            else {
                Console.WriteLine("Invalid choice!");
                Console.Write("Try again ");
                
            }
        }
        return output;
    }
    public void GetSetsTime(ref int[] time)
    {
        time = new int[numberOfSets];
        for(int i = 0; i < time.Length; i++) {
            int setCount = 1;
            Console.WriteLine($"How long did set number {setCount} set last?");
            int input = Convert.ToInt32(Console.ReadLine());
            time[i] = input;
            setCount++;
        }
    }
    public double GetJumpTime()
    {
        GetSetsTime(ref time);
        int finalTime = 0;
        for(int i = 0; i < time.Length; i++) {
            finalTime += time[i];
        }
        return finalTime;
    }
    public void PrintJumpTime()
    {
        Console.WriteLine($"Your total jump time is {GetJumpTime()} seconds");
    }
}