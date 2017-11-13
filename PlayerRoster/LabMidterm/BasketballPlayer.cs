using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMidterm
{
    class BasketballPlayer : Person
    {
        //instance variables
        private String position;
        private int heightIn;
        private int heightFt;
        
        //constructor with call to base class constructor
        public BasketballPlayer(String name, String position, int heightFt, int heightIn)
            : base(name)
        {
            this.heightFt = heightFt;
            this.heightIn = heightIn;
            this.position = position;
        }

        //getters and setters
        public String Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        public int HeightIn
        {
            get
            {
                return heightIn;
            }
            set
            {
                heightIn = value;
            }
        }
        public int HeightFt
        {
            get
            {
                return heightFt;
            }
            set
            {
                heightFt = value;
            }
        }

 
    }

}
