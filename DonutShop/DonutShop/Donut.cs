using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutShop
{
    class Donut
    {
        private string type;        // Donuts can be either glazed or Cake
        private decimal price;      // The price of the donut glazed are .75 and cake are .50

        public Donut() { }
        public Donut(string donutType)
        {
            Type = donutType;
            CalculatePrice();
        }

        public string Type
        {
            get { return type; }
            set { type = value.ToUpper(); }
        }

        public decimal Price
        {
            get { return price; }
        }
           

            private void CalculatePrice()
            {
            switch (Type)
                {
                case "GLAZED":
                    price = .75m;
                    break;
                case "CAKE":
                    price = .50m;
                    break;
                default:        // if type is not glazed or cake it is a special
                    price = 1.0m;
                    break;
                }

            }

        public override string ToString()
        {
            return string.Format("{0,12} {1:C}", Type, Price);
        }
    }
}
