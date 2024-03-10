using System.Globalization;

public class JRCalculator
{
    int numberOfSets;
    int[] time;
    public JRCalculator(int numberOfSets) 
    {
        time = new int[numberOfSets];
    }

    public static int GetValidInput()
    {
        bool validInput = false;
        int answer = 0;
        while(!validInput) {
            string? input = Console.ReadLine();
            validInput = int.TryParse(input, out answer);
            if(validInput) validInput = true;
            else {
                Console.WriteLine("Invalid choice!");
                Console.Write("Try again ");
                
            }
        }
        return answer;
    }
    public void GetSetsTime(ref int[] time)
    {
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