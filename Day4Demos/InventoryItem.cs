using System;
using System.Collections.Generic;
using System.Text;

namespace Day4Demos
{
    public class InventoryItem
    {
        private static double _maxWeight;

        /// <summary>
        /// Maximum weight shelves can handle in pounds.
        /// </summary>
        /// <param name="maxWeight">Maximum weight to set in pounds.</param>
        public static void SetMaxWeight(double maxWeight)
        {
            _maxWeight = maxWeight;
        }
        public static double GetMaxWeight()
        {
            return _maxWeight;
        }
       

        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Id value must be greater than 0.");
                }
            }
        }
        
        public int SerialNumber { get; set; }

        public string Manufacturer { get; set; }

        public string ModelNum { get; set; }

        private int LocationId { get; set; }

        private string Condition { get; set; }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; CalcWeightOK(); }
        }

        public int? OrderNum { get; set; }

        //Eager
        public bool WeightOK { get; private set; }

        private void CalcWeightOK()
        {
            WeightOK = weight < _maxWeight;
        }

        public string GetDescription()
        {
            string info = $"Item serialNumber: {SerialNumber}\n";
            info += $"Item location: {LocationId}\n";
            info += "Weigh OK? " + WeightOK;
            return info;
        }
    }
}
