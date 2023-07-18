using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, result;
            string choice;
            do
            {
                
                Console.WriteLine("Choose operation \n 1. Rectangle\n 2. Square \n 3. Circle \n 4. Triangle ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter length");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter breadth");
                            y = double.Parse(Console.ReadLine());
                            Rectangle rectangle = new Rectangle();
                            result = rectangle.Area(x,y);
                            Console.WriteLine("Area of rectangle with length and breadth {0} and {1} =\t {2}", x, y, result);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter side");
                            x = double.Parse(Console.ReadLine());
                            Square square = new Square();
                            
                            result = square.Area(x);
                            Console.WriteLine("Area of square with side {0}  =\t {2}", x, result);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter radius");
                            x = double.Parse(Console.ReadLine());
                            Circle circle = new Circle();   
                            result = circle.Area(x);
                            Console.WriteLine("Area of square with radius {0} =\t {2}",x , result);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter base length");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter height");
                            y = double.Parse(Console.ReadLine());
                            Triangle triangle = new Triangle();
                            result = triangle.Area(x, y);
                            Console.WriteLine("Area of triangle with base and heigth  {0} and {1} =\t {2}", x, y, result);
                            break;
                        }
                   
                    default:
                        {
                            Console.WriteLine("Invalid Operation");
                            break;
                        }

                }
                Console.WriteLine("Press y to continue");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");



        }
    }
}
