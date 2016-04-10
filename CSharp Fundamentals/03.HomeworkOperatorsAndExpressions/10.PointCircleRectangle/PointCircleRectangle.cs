using System;

// Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y)
// if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class PointCircleRectangle
{
    static void Main()
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());

        double centreCircleX = 1d;
        double centreCircleY = 1d;
        double radiusCircle = 1.5;
        double widthRect = 6d;
        double heightRect = 2d;
        double topRectY = 1d;
        double leftRectX = -1d;

        double downLeftRectX = leftRectX;
        double downLeftRectY = topRectY - heightRect;
        double upRightRectX = leftRectX + widthRect;
        double upRightRectY = topRectY;

        double distancePointToCentreCircle = Math.Sqrt(Math.Pow((pointX - centreCircleX), 2) + Math.Pow((pointY - centreCircleY), 2));

        if (distancePointToCentreCircle <= radiusCircle)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }

        if (pointX >= downLeftRectX && pointX <= upRightRectX && pointY >= downLeftRectY && pointY <= upRightRectY)
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");

        }
    }
}
