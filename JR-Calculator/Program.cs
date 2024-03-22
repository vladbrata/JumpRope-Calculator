using System.Dynamic;
using System.Globalization;

// prints the user menu
JRCalculator.PrintMenu();

// gets user choice about app functionality
int menu = JRCalculator.SelectFunctionality();

switch (menu) {
    // for the first functionality of the problem
    case 1:
        int numOfSets = JRCalculator.GetNumOfSets();
        JRCalculator jumpRopeCalc = new JRCalculator(numOfSets);
        break;
    // the rest will soon appear
}