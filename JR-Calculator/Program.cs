using System.Dynamic;
using System.Globalization;

Console.Clear();
Console.WriteLine("\tJump Rope Calculator");
Console.WriteLine("--------------------------------------");

Console.WriteLine("1. Caclulate workout time.");
Console.WriteLine("\tMore soon");
Console.WriteLine("--------------------------------------");
Console.Write("Select a functionality ");

int answer = JRCalculator.GetValidInput();

switch (answer) {
    case 1:
        Console.Clear();
        Console.WriteLine("How many sets?");
        int setsNum = JRCalculator.GetValidInput();
        JRCalculator jumpRopeCalc = new JRCalculator(setsNum);
        double output = jumpRopeCalc.GetJumpTime();
        jumpRopeCalc.PrintJumpTime();
        break;
    case 2:
        break;
}
