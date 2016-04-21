using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapesExercise.Shapes
{
    public class Pyramid : Shape
    {
        public Pyramid()
        {
            this.sides = 5;
        }
        public override double calculateVolume()
        {
            return (length * width * height) / 3;
        }
    }
}
