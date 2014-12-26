using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultApp
{
    class Result
    {
        public double Physics { private get;  set; }
        public double Chemistry { private get;  set; }
        public double Math { private get;  set; }

        public Result(double physics,double chemistry, double math)
        {
            this.Physics = physics;
            this.Chemistry = chemistry;
            this.Math = math;
        }

        public double GetAverage()
        {
          
            return (Physics + Chemistry + Math)/3;
        }

        public string GetGrade()
        {
            double average = GetAverage();
            if (average >= 80)
            {
                return "A+";
            }
            else if (average >= 70)
            {
                return "B+";
            }
            else if (average >= 60)
            {
                return "C+";
            }
            else if (average >= 50)
            {
                return "D+";
            }
            else 
            {
                return "F";
            }

        }
    }
}
