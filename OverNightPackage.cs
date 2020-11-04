using System;

namespace PolymorphismTest
{
    public class OverNightPackage : Packages
    {
        private decimal shippingCost;

        public OverNightPackage(string senderAddress, string receipientAddress, decimal shippingCost) : base(senderAddress, receipientAddress)
        {
            ShippingCost = shippingCost;
        }

        public decimal ShippingCost
        {
            get { return shippingCost; }
            private set
            {
                if (value > 0)
                {
                    shippingCost = value;
                }else
                {
                    throw new ArgumentOutOfRangeException("Shipping cost",value, "must not be less than zero");
                }
            }
        }

        public override decimal CalculateCost()
        {
            return ShippingCost;
        }

        public override string ToString()
        {
            return  $"OverNightPackage\n{base.ToString()}\nShipping Cost:{CalculateCost():C}\n\n";
        }


    }
}