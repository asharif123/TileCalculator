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

            //if user selects Rectangular tiles
            if (shape == "R")
            {
                Console.WriteLine("\nEnter the width: \n");
                //take user input of width
                string rectangleWidth = Console.ReadLine();

                Console.WriteLine("\nEnter the length: \n");
                //take user input of length
                string rectangleLength = Console.ReadLine();

                Console.WriteLine("\nEnter the cost per 1 unit of flooring: \n");
                //take user input of costPerUnit
                string rectangleCostPerUnit = Console.ReadLine();

                //convert string to float

                float rectangleWidthVal = float.Parse(rectangleWidth);
                float rectangleLengthVal = float.Parse(rectangleLength);

                //convert str to float
                float rectangleCostPerUnitVal = float.Parse(rectangleCostPerUnit);


                float rectangleTileTotal = rectangleWidthVal * rectangleLengthVal * rectangleCostPerUnitVal;

                const float rectangleHandyManCost = 20 * 86;

                float rectangleTotalCost = rectangleTileTotal + rectangleHandyManCost;

                //compute the tile cost, round to 2 digits
                Console.WriteLine("\nThe cost of the tiles is is ${0}.", Math.Round(rectangleTileTotal, 2));

                //compute the handy man cost, round to 2 digits
                Console.WriteLine("\nThe cost of handy man labor is ${0}.", Math.Round(rectangleHandyManCost, 2));

                //the total cost
                Console.WriteLine("\nThe total cost is is ${0}.", Math.Round(rectangleTotalCost, 2));
            }

                //if user selects Triangle tiles
            else if (shape == "T")
            {
                Console.WriteLine("\nEnter the width: \n");
                //take user input of length
                string triangleLength = Console.ReadLine();

                Console.WriteLine("\nEnter the height: \n");
                //take user input of height
                string triangleHeight = Console.ReadLine();

                Console.WriteLine("\nEnter the cost per 1 unit of flooring: \n");
                //take user input of costPerUnit
                string triangleCostPerUnit = Console.ReadLine();

                //convert string to float

                float triangleLengthVal = float.Parse(triangleLength);
                float triangleHeightVal = float.Parse(triangleHeight);

                //convert str to float
                float triangleCostPerUnitVal = float.Parse(triangleCostPerUnit);

                //total area of triangle is 1/2*length*height
                float triangleTileTotal = (triangleLengthVal * triangleHeightVal * triangleCostPerUnitVal)/2;

                const float triangleHandyManCost = 20 * 86;

                float triangleTotalCost = triangleTileTotal + triangleHandyManCost;

                //compute the tile cost, round to 2 digits
                Console.WriteLine("\nThe cost of the tiles is is ${0}.", Math.Round(triangleTileTotal, 2));

                //compute the handy man cost, round to 2 digits
                Console.WriteLine("\nThe cost of handy man labor is ${0}.", Math.Round(triangleHandyManCost, 2));

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
