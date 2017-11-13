using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDeliveryService
{
    class TwoDayPackage : Package
    {
        private decimal flatFee;

        public TwoDayPackage(String sender, String senderAdd, String recipient, String recipientAdd, decimal packageWeight, decimal shipRate, decimal twoDayRate)
            : base(sender, senderAdd, recipient, recipientAdd, packageWeight, shipRate)
        {
            flatFee=twoDayRate;  
        }

        //get+set for flatFee
        public decimal FlatFee
        {
            get
            {
                return flatFee;
            }
            set
            {
                if (value >= 0)
                    flatFee = value;
                else
                    throw new ArgumentOutOfRangeException("Cost must be greater than zero");
            }
        }

        //override method to calculate new cost
        public override decimal CalculateCost()
        {
            return weight * costPerOunce + flatFee;
        }
    }
}
