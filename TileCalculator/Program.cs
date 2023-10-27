//Ask the user to enter in width, length, and the cost per 1 unit of flooring.
//Have the program calculate how much it would cost to cover the area specified with the flooring.

//Added Difficulty: Calculate how much flooring would be needed for non-rectangular rooms.
//Also figure out how much labor costs would be given that
//average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr.
//Pick ONE ADDITIONAL SHAPE (triangle / circle / etc) and implement the second shape,
//making the user select wich one they want to calculate


using System.ComponentModel.Design;

namespace TileCa1culator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ask user for the shape

            Console.WriteLine("Type R for Rectangle flooring or T for Triangle flooring:\n");

            string shape = Console.ReadLine().ToUpper();

            //define handyman cost for all shapes

            const float handyManCost = 86 * 20;

            Console.WriteLine("\nEnter the width: \n");
            //take user input of width regardless of shape
            string width = Console.ReadLine();



            Console.WriteLine("\nEnter the length: \n");
            //take user input of length regardless of shape
            string length = Console.ReadLine();


            Console.WriteLine("\nEnter the cost per 1 unit of flooring: \n");
            //take user input of costPerUnit
            string costPerUnit = Console.ReadLine();

            //convert string to float

            float widthVal = float.Parse(width);
            float lengthVal = float.Parse(length);

            //convert str to float
            float costPerUnitVal = float.Parse(costPerUnit);

            //if user selects Rectangular tiles
            if (shape == "R")
            {

                //rectangle area
                float rectangleArea = widthVal * lengthVal;


                float rectangleTileTotal = rectangleArea * costPerUnitVal;

                float rectangleTotalCost = rectangleTileTotal + handyManCost;

                //compute the tile cost, round to 2 digits
                Console.WriteLine("\nThe cost of the tiles is is ${0}.", Math.Round(rectangleTileTotal, 2));

                //compute the handy man cost, round to 2 digits
                Console.WriteLine("\nThe cost of handy man labor is ${0}.", Math.Round(handyManCost, 2));

                //the total cost
                Console.WriteLine("\nThe total cost is is ${0}.", Math.Round(rectangleTotalCost, 2));
            }

                //if user selects Triangle tiles
            else if (shape == "T")
            {

                //total area of triangle is 1/2*length*height
                float triangleArea = (lengthVal * widthVal) / 2;
                float triangleTileTotal = triangleArea * costPerUnitVal;

                float triangleTotalCost = triangleTileTotal + handyManCost;

                //compute the tile cost, round to 2 digits
                Console.WriteLine("\nThe cost of the tiles is is ${0}.", Math.Round(triangleTileTotal, 2));

                //compute the handy man cost, round to 2 digits
                Console.WriteLine("\nThe cost of handy man labor is ${0}.", Math.Round(handyManCost, 2));

                //the total cost
                Console.WriteLine("\nThe total cost is is ${0}.", Math.Round(triangleTotalCost, 2));


            }
            //if user does not enter either Triangle or Rectangle

            else
            {
                Console.WriteLine("\nInvalid input!\n");
            }

        }
    }
}
