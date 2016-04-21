using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpShapesExercise.Shapes;

namespace SharpShapesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int shapeChoice;
            double dimension;
            string[] dimensions;
            bool shapeSelected = false;


            //Console select menu
            Console.WriteLine("");
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Cylinder");
            Console.WriteLine("3. Square");
            Console.WriteLine("4. Pyramid");
            Console.WriteLine("> ");

            //Need to grab the shape choice as selected by user
            Int32.TryParse(Console.ReadLine(), out shapeChoice);

            while(shapeSelected == false)
            {
                switch (shapeChoice)
                {
                    case 1: //Instance when circle is selected
                        Console.WriteLine("");
                        Console.WriteLine("Enter circle radius:");
                        Console.WriteLine("> ");
                        dimension = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle();
                        circle.radius = dimension;
                        Console.WriteLine("");
                        Console.WriteLine("Circle with radius of {0}", circle.radius);
                        Console.WriteLine("A circle has {0} side.", circle.sides);
                        Console.WriteLine("The area of this circle is {0}.", circle.calculateArea());
                        shapeSelected = true;
                        break;
                    case 2: //Instance when cylinder is selected
                        Console.WriteLine("");
                        Console.WriteLine("Enter Height and radius of cylinder, seperated by a comma: ");
                        Console.Write("> ");
                        dimensions = Console.ReadLine().Split(',');
                        Cylinder cylinder = new Cylinder();
                        cylinder.height = Convert.ToDouble(dimensions[0]);
                        cylinder.radius = Convert.ToDouble(dimensions[1]);
                        Console.WriteLine("");
                        Console.WriteLine("Cylinder with height of {0} and radius of {1}", cylinder.height, cylinder.radius);
                        Console.WriteLine("A cylinder has {0} sides.", cylinder.sides);
                        Console.WriteLine("The volume of this cylinder is {0}.", cylinder.calculateVolume());
                        shapeSelected = true;
                        break;
                    case 3: //Instance when square is selected
                        Console.WriteLine("");
                        Console.WriteLine("Enter the width of the square:");
                        Console.Write("> ");
                        dimension = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square();
                        square.width = dimension;
                        Console.WriteLine("");
                        Console.WriteLine("Square with width of {0}", square.width);
                        Console.WriteLine("A square has {0} sides.", square.sides);
                        Console.WriteLine("The area of this square is {0}.", square.calculateArea());
                        shapeSelected = true;
                        break;
                }
            }

        }
    }
}
