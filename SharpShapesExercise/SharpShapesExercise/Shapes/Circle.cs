using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapesExercise.Shapes
{
   public class Circle : Shape
    {
        public Circle()
        {
            this.sides = 1;
        }

        public override double calculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
