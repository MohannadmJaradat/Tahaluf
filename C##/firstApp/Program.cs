///////////////////////////////////////////////////////////////////////////////////
//Write a program that enters the diameter of a circle from the keyboard and prints the circumference of the circle
Console.WriteLine("#######################################################################");

Console.WriteLine("Enter the diameter: ");
int diameter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The Circumference of the circle that has a diameter of "+diameter+" is "+Math.PI*diameter);
Console.WriteLine("#######################################################################");
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
//Write a program that inputs time and distance from the keyboard and prints the speed in meters per hour and kilometers per hour
Console.WriteLine("#######################################################################");
Console.WriteLine("Time in hours: ");
int time = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Distance in meters: ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The speed in meters per hour is " + (distance/time));
Console.WriteLine("The speed in kilometers per hour is " + (distance / 1000 / time));
Console.WriteLine("#######################################################################");
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
/*
 The difference between post and pre increment is that pre increment increases the value by 1 before assigning
it to the variable, on the other hand, the post increment increases the value by 1 after assigning it to a variable
 */
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
//Use Math.round to round a double number to the nearest integer
Console.WriteLine("#######################################################################");
Console.WriteLine("Enter a decimal number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{num1} after using Math.round becomes {Math.Round(num1)}");
Console.WriteLine("#######################################################################");
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
//Use Math.Pow to calculate teh result of baseNumber raised to the power of exponent
Console.WriteLine("#######################################################################");
Console.WriteLine("Enter the base number: ");
int baseNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{baseNum} to the power of {exponent} is {Math.Pow(baseNum, exponent)}");
Console.WriteLine("#######################################################################");
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
//Write a program to check whether a year is leap or not
Console.WriteLine("#######################################################################");
Console.WriteLine("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 400 == 0) Console.WriteLine($"{year} is a leap year.");
else if (year % 100 == 0) Console.WriteLine($"{year} is not a leap year."); 
else if (year % 4 == 0) Console.WriteLine($"{year} is a leap year.");
else Console.WriteLine($"{year} is not a leap year.");
Console.WriteLine("#######################################################################");
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
//Write a program to check whether an alphabet is lowercase or uppercase
Console.WriteLine("#######################################################################");
Console.WriteLine("Enter a letter: ");
char alpha  = Convert.ToChar(Console.ReadLine());
if (alpha >= 'A' && alpha <= 'Z') Console.WriteLine($"{alpha} is uppercase");
else if (alpha >= 'a' && alpha <= 'z') Console.WriteLine($"{alpha} is lowercase");
else Console.WriteLine($"{alpha} is not a letter.");
Console.WriteLine("#######################################################################");
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
//Write a program to create a simple calculator usign switch statement
Console.WriteLine("#######################################################################");
Console.WriteLine("Enter an operator: ");
char op = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Enter two operands: ");
double operand1 = Convert.ToDouble(Console.ReadLine());
double operand2 = Convert.ToDouble(Console.ReadLine());
switch (op)
{
    case '+':
        Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
        break;
    case '-':
        Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
        break;
    case '*':
        Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
        break;
    case '/':
        Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
        break;
    default:
        Console.WriteLine("Operator is not correct.");
        break;
}
Console.WriteLine("#######################################################################");
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
//Write a program to take 3 numbers from the keyboard and find the maximum umber using ternary operator
Console.WriteLine("#######################################################################");
Console.Write("Enter the first number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int num4 = Convert.ToInt32(Console.ReadLine());
int max = (num2 > num3) ? (num2 > num4 ? num2 : num4) : (num3 > num4 ? num3 : num4);
Console.WriteLine("The maximum number is: " + max);
Console.WriteLine("#######################################################################");
//////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////
//Write a program to take a number from the keyboard and check if the number is odd or even using ternary operator
Console.WriteLine("#######################################################################");
Console.Write("Enter a number: ");
int num5 = Convert.ToInt32(Console.ReadLine());
string result = (num5 % 2 == 0) ? "even" : "odd";
Console.WriteLine($"The number {num5} is {result}.");
Console.WriteLine("#######################################################################");
