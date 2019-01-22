using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_program
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6


            Console.WriteLine("enter three sides of triangle a b c");


            string X = Console.ReadLine();
            string Y = Console.ReadLine();
            string Z = Console.ReadLine();
           

            double a = double.Parse(X);
            double b = double.Parse(Y);
            double c = double.Parse(Z);

            double s = (a + b + c) / 2; // calculation of s

            double A = (s * (s - a) * (s - b) * (s - c));

            double r = A;

            double area = Math.Sqrt(r); // give square root of A

            Console.WriteLine("Area of triangle is " + area);
            Console.ReadKey(true);





            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            // Write your code here

            Console.WriteLine("Enter the number to check if it is even or odd");

            string n = Console.ReadLine();

            int number = int.Parse(n);  

            if (number % 2 == 0)     //calculate reminder 
            {
                Console.WriteLine(n + " is even number");

            }

            else if (number % 2 != 0)
            {
                Console.WriteLine(n + " is odd number");

            }
            Console.ReadKey(true);




            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.


            Console.WriteLine("Enter three numbers which you want to compare");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            double i = double.Parse(x);
            double j = double.Parse(y);
            double k = double.Parse(z);

            if (i > j && i > k)
            {
                Console.WriteLine(i + " is the greatest number among them.");
            }

            else if (j > i && j > k)
            {
                Console.WriteLine(j + " is the greatest number among them.");
            }

            else if (k > i && k > j)
            {

                Console.WriteLine(k + " is the greatest number among them.");
            }


            else
            {
                Console.WriteLine("two or more numbers are same");
                
            }


            Console.ReadKey(true);








        }
    }
}
