using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDeliveryService
{
    class Package
    {
        private String senderName;
        private String senderAddress;
        private String recipName;
        private String recipAddress;

        protected decimal weight;
        protected decimal costPerOunce;

        public Package(String sender, String senderAdd, String recipient, String recipientAdd, decimal packageWeight, decimal shipRate)
        {
            senderName = sender;
            senderAddress = senderAdd;
            recipName = recipient;
            recipAddress = recipientAdd;
            weight = packageWeight;
            costPerOunce = shipRate;
        }
        //getters+setters
        public String SenderName
        {
        get
        {
        return senderName;
    }
    }
        public String RecipName
        {
            get
            {
                return recipName;
            }
        }
        public String SenderAddress
        {
            get
            {
                return senderAddress;
            }
        }
        public String RecipAddress
        {
            get
            {
                return recipAddress;
            }
        }
        //check weight and cost for negative values
        public decimal Weight
        {
            get 
            {
                return weight;
            }
            set 
            {
                if (value >= 0)
                    weight = value;
                else
                    throw new ArgumentOutOfRangeException("Package weight must be greater than zero");
            }
        }
        public decimal CostPerOunce
        {
            get
            {
                return costPerOunce;
            }
            set
            {
                if (value >= 0)
                    costPerOunce = value;
                else
                    throw new ArgumentOutOfRangeException("Cost must be greater than zero");
            }
        }

        public virtual decimal CalculateCost()
        {
            return costPerOunce * weight;
            
        }
    }
}
