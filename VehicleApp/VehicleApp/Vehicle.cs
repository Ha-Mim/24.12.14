using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    class Vehicle
    {
        public string Name { private get; set; }
        public string RegNo { private get;  set; }
        private double speed;

        public double Speed
    {
            set { speed = value; }
            get { return speed; }
    }

       
        public double Max
        {
            set { max = value; }
        }


        private double min;
        private double max ;
       
        
        public double Min
        {
            set { min = value; }
            get {return min;}
        }
        public double GetMinSpeed()
        {
            if (Min == 0)
            {
                return Speed;
            }
            else if (Speed < Min)
            {
                Min = Speed;
                return  Min;
            }
            else 
            {
                return Min;
            }
            
        }

        public double GetMaxSpeed()
        {
            if (Speed > max)
            {
                return Speed;
            }
            else
            {
                return max;
            }
        }

        public double GetAverageSpeed()
        {
            
            return (GetMaxSpeed() + GetMinSpeed())/2;
        }
    }
}
