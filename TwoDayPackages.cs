using System;


namespace PolymorphismTest
{
    public class TwoDaysPackage : Packages
    {
        private decimal shippingCost;

        public TwoDaysPackage(string senderAddress, string receipientAddress, decimal shippingCost) : base(senderAddress, receipientAddress)
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
                }
                else
                {
                    throw new ArgumentOutOfRangeException("shippingCost ", value, "must be greater than zero");
                }
            }
        }

        public override decimal CalculateCost()
        {
            return ShippingCost;
        }

        public override string ToString()
        {
            return $"Two days package\n{base.ToString()}\nShipping cost: {ShippingCost}";
        }

    }
}
