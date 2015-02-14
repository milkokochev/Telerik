//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

    class CircleRectangle
    {
        static void Main()
        {
            //Circle parameters
            double centerCirclеX = 1;
            double centerCirclеY = 1;
            double radius = 1.5;
            //Rectangular parameters
            double upperLeftX = -1;
            double upperLeftY = 1;
            double buttomRightX = 5;
            double buttomRightY = -1;


            Console.WriteLine("Enter the coordinates of point:");
            Console.Write("X= ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Y= ");
            double pointY = double.Parse(Console.ReadLine());

            bool insideCircle = (Math.Pow(pointX - centerCirclеX, 2) + Math.Pow(pointY - centerCirclеY, 2) <= Math.Pow(radius, 2));
            bool insideRectangular = ((pointX >= upperLeftX) && (pointX <= buttomRightX)) && ((pointY <= upperLeftY) && (pointY >= buttomRightY));
            
            Console.Write("Is the point inside the Circle and outside the Rectangle? --> ");

            if (insideCircle && !insideRectangular)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }