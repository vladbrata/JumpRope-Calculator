using System.Dynamic;
using System.Globalization;

JRCalculator.PrintMenu();
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
