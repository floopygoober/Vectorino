using System;

namespace vectorino
{
    class Program
    {
        static void Main(string[] args)
        {
            char retry;
            do
            {
                Console.Clear();
                double newX, newY;
                //sets both x and y values
                Console.WriteLine("Enter an x value for your vector");
                newX = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter an y value for your vector");
                newY = Convert.ToDouble(Console.ReadLine());

                //building our first 2d vector
                Vector2D myVector = new Vector2D(newX, newY);
                Console.WriteLine("[" + myVector.X + ", " + " " + myVector.Y + "]");
                //this will keep the console window open when the program is finished until next keystroke
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Press 1 to open simple menu");
                Console.WriteLine("Press 2 to open advanced menu");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                //switch statement to sort through all the options following the order of the printed menu above
                switch (input)
                {
                    case '1':
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("Press 1 to negate X");
                        Console.WriteLine("Press 2 to negate Y");
                        Console.WriteLine("Press 3 to add vectors");
                        Console.WriteLine("Press 4 to subtract vectors");
                        Console.WriteLine("Press 5 to perform scalar multiplication");
                        Console.WriteLine("Press 6 to get the magnitude");
                        Console.WriteLine("Press 7 to get the angle in degrees");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        char input1 = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        switch (input1)
                        {
                            case '1':
                                myVector.NegateX();
                                Console.WriteLine(newX + " is now: " + myVector.X);
                                break;

                            case '2':
                                myVector.NegateY();
                                Console.WriteLine(newY + " is now: " + myVector.Y);
                                break;

                            case '3':
                                Console.WriteLine("What would you like to add to your X value");
                                double addX = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("What would you like to add to your Y value");
                                double addY = Convert.ToDouble(Console.ReadLine());
                                myVector.AddVector(addX, addY);
                                Console.WriteLine("your x value is now: " + myVector.X + " and your y is now: " + myVector.Y);
                                break;

                            case '4':
                                Console.WriteLine("What would you like to subtract from your X value");
                                double subX = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("What would you like to subtract from your Y value");
                                double subY = Convert.ToDouble(Console.ReadLine());
                                myVector.SubtractVector(subX, subY);
                                Console.WriteLine("your x value is now: " + myVector.X + " and your y is now: " + myVector.Y);
                                break;

                            case '5':
                                Console.WriteLine("What would you like to multiply your vector by? ");
                                double mult = Convert.ToDouble(Console.ReadLine());
                                myVector.ScalerMultiplication(mult);
                                Console.WriteLine("your x value is now: " + myVector.X + " and your y is now: " + myVector.Y);
                                break;

                            case '6':
                                Console.WriteLine("The magnitude is: " + myVector.GetMagnitude());
                                break;

                            case '7':
                                Console.WriteLine("The angle of the vector is: " + myVector.GetAngleInDegrees());
                                break;
                        }
                        
                        //the end of assignment 1
                        break;

                    case '2':
                        Console.WriteLine("Enter an x value for your second vector");
                        double otherX = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter an y value for your second vector");
                        double otherY = Convert.ToDouble(Console.ReadLine());
                        //creats second vector to maths with
                        Vector2D otherVector = new Vector2D(otherX, otherY);

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("Press 1 to normalize the vector");
                        Console.WriteLine("Press 2 to get the dot product of the vector");
                        Console.WriteLine("Press 3 to get the angle between the vectors");
                        Console.WriteLine("Press 4 to get the LERP of the vector");
                        Console.WriteLine("Press 5 to rotate the vectore");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        //The new menu for the second assignment
                        //now for the case section to sort out which opporation is carried out. 
                        char input2 = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        switch (input2)
                        {
                            case '1':
                                Console.WriteLine("The vector is normalized");
                                break;

                            case '2':
                                Console.WriteLine("The result of your DOT product is: " + myVector.GetDotProduct(otherVector));
                                break;

                            case '3':
                                Console.WriteLine("The angle between your vectors is: " + myVector.GetAngleBetween(otherVector));
                                break;

                            case '4':
                                myVector.Lerp(otherVector);
                                Console.WriteLine("your new vector is: [" + myVector.X + ", " + myVector.Y + "]");
                                break;

                            case '5':
                                Console.WriteLine("how many degrees would you like to rotate this vector?");
                                double angle = Convert.ToDouble(Console.ReadLine());
                                myVector.RotateVector(angle);
                                Console.WriteLine("The vector after the rotation is: [" + myVector.X + ", " + myVector.Y + "]");
                                break;
                        }

                        break;
                }

                Console.WriteLine("would you like to retry? (n or q to quit) ");
                retry = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

            }
            while (retry != 'q' && retry != 'n');
        }
    }
}
