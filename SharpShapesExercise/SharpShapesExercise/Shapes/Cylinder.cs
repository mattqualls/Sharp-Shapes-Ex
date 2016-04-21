using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapesExercise.Shapes
{
   public class Cylinder : Shape
    {
        public Cylinder()
        {
            this.sides = 3;
        }
        public override double calculateVolume()
        {
            return Math.PI * radius * radius * height;
        }
    }
}
