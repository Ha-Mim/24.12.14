using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    internal class Circle
    {
        
        private double radius;

        public double Radius
        {
            set { radius = value; }
        }

        public double GetDiameter()
        {
            return radius*2;
        }

        public double GetPerimeter()
        {
            return GetDiameter()*Math.PI;
        }

        public double GetArea()
        {
            return Math.PI*radius*radius;
        }

    }
}
