using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDeliveryService
{
    class OvernightPackage : Package
    {
        private decimal addFeePerOunce;

        public OvernightPackage(String sender, String senderAdd, String recipient, String recipientAdd, decimal packageWeight, decimal shipRate, decimal addRate)
            : base(sender, senderAdd, recipient, recipientAdd, packageWeight, shipRate)
        {
            addFeePerOunce = addRate;
        }

        //get+set for additionalFeePerOunce
        public decimal AddFeePerOunce
        {
            get
            {
                return addFeePerOunce;
            }
            set
            {
                if (value >= 0)
                    addFeePerOunce = value;
                else
                    throw new ArgumentOutOfRangeException("Cost must be greater than zero");
            }
        }

        //override method to calculate new cost
        public override decimal CalculateCost()
        {
            return weight * (costPerOunce + addFeePerOunce);
            
        }
     }
}
