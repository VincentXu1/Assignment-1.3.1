namespace Assignment_1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserPrompt();
            string userInput = Console.ReadLine();
            bool loop = true;

            // User menu selection input validation.
            while (loop)
            {
                switch (userInput)
                {
                    case "a":
                    case "b":
                    case "c":
                        loop = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid option:");
                        UserPrompt();
                        userInput = Console.ReadLine();
                        break;
                }
            }

            // User input error handling intentionally omitted. Just wanted to try tuples.
            Console.WriteLine("Please enter figure dimensions:");
            (double length, double width) dimensions = (Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Area is: ");
            switch (userInput)
            {
                case "a":
                    Console.WriteLine(AreaTriangle(dimensions.length, dimensions.width));
                    break;
                case "b":
                    Console.WriteLine(AreaSquare(dimensions.length));
                    break;
                case "c":
                    Console.WriteLine(AreaRectangle(dimensions.length, dimensions.width));
                    break;
            }
        }

        static void UserPrompt()
        {
            Console.WriteLine("Please select a figure:");
            Console.WriteLine("\ta) triangle");
            Console.WriteLine("\tb) square");
            Console.WriteLine("\tc) rectangle");
        }

        static double AreaSquare(double side)
        {
            return AreaRectangle(side, side);
        }

        static double AreaRectangle(double length, double width)
        {
            return length * width;
        }

        static double AreaTriangle(double triangleBase, double height)
        {
            return 0.5 * triangleBase * height;
        }
    }
}
