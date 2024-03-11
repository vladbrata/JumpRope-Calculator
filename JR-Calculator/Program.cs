using System.Dynamic;
using System.Globalization;

JRCalculator jumpRopeCalc = new JRCalculator();

jumpRopeCalc.PrintMenu();

int menu = jumpRopeCalc.SelectFunctionality();

switch (menu) {
    case 1:
        jumpRopeCalc.FirstChoice();
        break;
}