using System;
using System.Collections.Generic;
using System.Text;

namespace Day4Demos
{
    public class InventoryItem
    {
        private static double _maxWeight;
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
        
        private int serialNumber;
        public void SetSerialNumber(int serialNumber)
        {
            this.serialNumber = serialNumber;
        }
        public int GetSerialNumber()
        {
            return serialNumber;
        }

        private string manufacturer;
        public void SetManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }
        public string GetManufacturer()
        {
            return manufacturer;
        }

        private int modelNum;
        public void SetModelNum(int modelNum)
        {
            this.modelNum = modelNum;
        }
        public int GetModelNum()
        {
            return modelNum;
        }

        private int locationId;
        public void SetLocationId(int locationId)
        {
            this.locationId = locationId;
        }
        public int GetLocationId()
        {
            return locationId;
        }

        private string condition;
        public void SetCondition(string condition)
        {
            this.condition = condition;
        }
        public string GetCondition()
        {
            return condition;
        }


        private double weight;
        public void SetWeight(double weight)
        {
            this.weight = weight;
            CalcWeightOK();
        }
        public double GetWeight()
        {
            return weight;            
        }

        private int? ordernum;
        public void SetOrderNum(int? ordernum)
        {
            this.ordernum = ordernum;
        }
        public int? GetOrderNum()
        {
            return ordernum;
        }

        //Lazy way
        //public bool WeightOK()
        //{
        //    return weight < _maxWeight;
        //}

        //Eager
        private bool weightOK;

        public bool GetWeightOK()
        {
            return weightOK;
        }

        private void CalcWeightOK()
        {
            weightOK = weight < _maxWeight;
        }

        public string GetDescription()
        {
            string info = $"Item serialNumber: {serialNumber}\n";
            info += $"Item location: {locationId}\n";
            info += "Weigh OK? " + weightOK;
            return info;
        }
    }
}
