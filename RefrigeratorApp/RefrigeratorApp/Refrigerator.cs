using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        private double maxWeight;
        private double noOfItem;
        private double itemWeight;
        private double currentWeight;

        public double MaxWeight
        {
            get { return maxWeight; }
            set { maxWeight = value; }
        }

        public double NoOfItem
        {
            get { return noOfItem; }
            set { noOfItem = value; }
        }

        public double ItemWeight
        {
            get { return itemWeight; }
            set { itemWeight = value; }
        }

        public double CurrentWeight
        {
            get { return currentWeight; }
            set { currentWeight = value; }
        }

        public double GetCurrentWeight()
        {
            return CurrentWeight + NoOfItem*ItemWeight;
        }

        public double GetRemainingWeight()
        {
            return MaxWeight - GetCurrentWeight();
        }
    }
}
