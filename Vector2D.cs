using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorino
{
    class Vector2D
    {
        private double x;
        private double y;
        //lets us have access to the value of our private doubles with out changing them
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        //same here for our Y double
        public double Y 
        {
            get { return y; }
            set { y = value; }
        }

        //constructor
        public Vector2D(double xValue, double yValue)
        {//sets the private doubles to the passed in parameters
            x = xValue;
            y = yValue;
        }
        //makes X negative
        public void NegateX()
        {
            x = -x;
        }
        //makes Y negative
        public void NegateY()
        {
            y = -y;
        }
        //used to add user entered doubles with the origenal doubles
        public void AddVector(double xValue, double yValue)
        {
            x += xValue;
            y += yValue;
        }
        //user entered subtraction
        public void SubtractVector(double xValue, double yValue)
        {
            x -= xValue;
            y -= yValue;
        }
        //user entered multiplication with a scalar double
        public void ScalerMultiplication(double scalar)
        {
            x *= scalar;
            y *= scalar;
        }
        //gets the over all magnitude of the vector
        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));            
        }
        //used to get the degree of the vector
        public double GetAngleInDegrees()
        {
            return ((Math.Atan2(y, x)) * (180 / Math.PI) + 360);
        }
        /*
         *THIS IS THE END  
         *OF ASSIGNMENT 2
         */
        public void Normalize()
        {//tests to see if it is normalized
            double normal = GetMagnitude();
            x /= normal;
            y /= normal;
        }

        public double GetDotProduct(Vector2D otherVector)
        {//uses quick maths to get and return the dot product
            return (x * otherVector.X) + (y * otherVector.Y);
        }

        public double GetAngleBetween(Vector2D otherVector)
        {
            //declaring doubles to store each magnitude for easier coding of the angle equation
            double mag1= Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double mag2 = Math.Sqrt(Math.Pow(otherVector.X, 2) + Math.Pow(otherVector.Y, 2));

            return (Math.Acos(((x * otherVector.X) + (y * otherVector.Y)) / (mag1 * mag2))) * (180 / Math.PI);
        }

        public Vector2D Lerp(Vector2D otherVector)
        {// specifies what the t value should be with a fail safe as an if loop to idiot proof
            Console.WriteLine("what would you like you t value to be for this lerp? (any value from: 0 -> 1) ");
            double t = Convert.ToDouble(Console.ReadLine());
            if (t < 0 || t > 1)
            {
                Console.WriteLine("The value must be between 0 and 1. Try again.");
                t = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                double tempx = otherVector.X - x;
                double tempy = otherVector.Y - y;
                //finds the difference between the vectors then it scales them by t
                X += tempx * t;
                Y += tempy * t;
            }
                return this; // returns the entire method
        }

        public void RotateVector(double angle)
        {//we change the angle before hand so we do not have to do this with each equation to get the answer in degrees
            angle /= (180 / Math.PI);
            double tempX = X;
            double tempY = Y;

            X = (tempX * Math.Cos(angle)) - (tempY * Math.Sin(angle));
            Y = (tempX * Math.Sin(angle))  + (tempY * (Math.Cos(angle)));
        }

    }
}