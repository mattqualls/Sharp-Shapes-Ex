using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapesExercise.Shapes
{
    public class Square : Shape
    {
        public Square()
        {
            this.sides = 4;
        }
        public override double calculateArea()
        {
            return width * width;
        }
    }
}
