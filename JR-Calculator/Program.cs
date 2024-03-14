using System.Dynamic;
using System.Globalization;

JRCalculator jumpRopeCalc = new JRCalculator();

// prints the user menu
jumpRopeCalc.PrintMenu();

// gets user choice about app functionality
int menu = jumpRopeCalc.SelectFunctionality();

switch (menu) {
    // for the first functionality of the problem
    case 1:
        jumpRopeCalc.FirstChoice();
        break;
    // the rest will soon appear
}