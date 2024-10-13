//Ask the user to enter in width, length, and the cost per 1 unit of flooring.
//Have the program calculate how much it would cost to cover the area
//specified with the flooring.

//Added Difficulty: Calculate how much flooring would be needed for non-rectangular rooms.
//Also figure out how much labor costs would be given that
//average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr.
//Pick ONE ADDITIONAL SHAPE (triangle / circle / etc) and implement the second shape,
//making the user select wich one they want to calculate



namespace TileCa1culator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //defining constants at the beginning of the main function

            //constant for defining how much flooring can be put in
            const float FLOORING_SQUARE_FEET = 20.0F;

            //constant for defining flooring per hour
            const float FLOORING_PER_HOUR = 85.0F;

            //define area for rectangle and triangle
            float area = 0;

            //ask user for the shape
            Console.WriteLine("\nType R for Rectangle flooring or T for Triangle flooring:\n");

            string shape = Console.ReadLine().ToUpper();

            if (shape == "R")  //if user selects Rectangular tiles
            {
                //if user selected rectangle, enter width and length
                Console.WriteLine("\nEnter the width: \n");
                float rectangleWidth = float.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the length: \n");
                float rectangleLength = float.Parse(Console.ReadLine());

                //calculate the area of the rectangle
                area = rectangleWidth * rectangleLength;
            }
            else if (shape == "T")  //if user selects Triangle tiles
            {
                //if user selected triangle, enter the base and height dimensions
                Console.WriteLine("Enter the triangle's base dimension");
                float baseVal = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the triangle's height dimension");
                float heightVal = float.Parse(Console.ReadLine());

                //calculate the area of the triangle
                area = (baseVal * heightVal) / 2;

            }
            else  //if user does not enter either Triangle or Rectangle
            {
                Console.WriteLine("\nInvalid input!\n");
                return;
            }

            //Perform calculations regardless of what shape is selected

            //take user input of costPerUnit
            Console.WriteLine("\nEnter the cost per 1 unit of flooring: \n");
            string costPerUnit = Console.ReadLine();

            //convert str to float
            float costPerUnitVal = float.Parse(costPerUnit);

            //total costs of tiles
            float tileTotal = area*costPerUnitVal;

            //compute the tile cost, round to 2 digits
            Console.WriteLine("\nThe cost of the tiles is is ${0}.", Math.Round(tileTotal, 2));

            //total cost of handyMan labor
            float handyManLabor = (area / FLOORING_SQUARE_FEET) * FLOORING_PER_HOUR;

            //compute the handy man cost, round to 2 digits
            Console.WriteLine("\nThe cost of handy man labor is ${0}.", Math.Round((handyManLabor), 2));

            //get the overall total cost
            float totalCost = tileTotal + handyManLabor;

            //the total cost
            Console.WriteLine("\nThe total cost is is ${0}.", Math.Round(totalCost, 2));

        }
    }
}
