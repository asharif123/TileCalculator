﻿//Ask the user to enter in width, length, and the cost per 1 unit of flooring.
//Have the program calculate how much it would cost to cover the area specified with the flooring.

//Added Difficulty: Calculate how much flooring would be needed for non-rectangular rooms.
//Also figure out how much labor costs would be given that
//average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr.
//Pick ONE ADDITIONAL SHAPE (triangle / circle / etc) and implement the second shape,
//making the user select wich one they want to calculate
//onsole.WriteLine("{0} this is an {1} is your name? {2}", aString, panela, large);
string width;
string length;
string costPerUnit;

Console.WriteLine("Enter the width: \n");
width = Console.ReadLine();

Console.WriteLine("\nEnter the length: \n");
length = Console.ReadLine();

Console.WriteLine("\nEnter the cost per 1 unit of flooring: \n");
costPerUnit = Console.ReadLine();

//convert string to float

float widthVal = float.Parse(width);
float lengthVal = float.Parse(length);

//convert str to float
float costPerUnitVal = float.Parse(costPerUnit);


float total = widthVal*lengthVal*costPerUnitVal;

//comput the total cost, round to 2 digits
Console.WriteLine("\nThe total cost is ${0}", Math.Round(total,2));

