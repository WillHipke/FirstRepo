using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutShop
{
    class Sack
    {
        private int sackSize;  // this is how many donuts a sack can hold
        private int numberDonuts;  // this is how many donuts are in the sack
        private Donut[] sackContents; // this is what is in the sack

        public Sack()
        {
            // default sack will have a size of 6
            sackSize = 6;
            numberDonuts = 0;
            sackContents = new Donut[sackSize];
        } // This is a defaut sack

        public Sack(int theSackSize)
        {
            sackSize = theSackSize;  // used the private member here as there is no setter
            numberDonuts = 0;        // there are no donuts in the sack
            // I have a reference for array of donuts but no implementation
            sackContents = new Donut[SackSize];

        }

        public Donut[] SackContents
        {
            get { return sackContents; }
            set { sackContents = value; }   // I could add an array of donuts to the sack 
                                            // but what if the array is bigger than the sack size????
                                            // BOOM!
        }
        public int SackSize
        {
            get { return sackSize; }
            // no setter for the sack size I cannot change the size of the sach during run time.

        }

        public void AddDonut(Donut aDonut)
        {
            // if the number of donuts in the sack are less than the size of the sack
            // add the donut to the sack

            if (numberDonuts < SackSize)
            {
                // now add it to the sack
                SackContents[numberDonuts] = aDonut;
                numberDonuts++;
            }
        }

        private decimal CalculateSubTotalOrder()
        {
            decimal subTotal = 0;
            // add up the price of all the donuts in the sack

            for(int x = 0; x < numberDonuts; x++)
            {
                subTotal += SackContents[x].Price;
            }

            return subTotal;

        }
        private decimal Discount(decimal subTotal)
        {
            decimal discount = 0.0m;
            // if the number of Donuts is at least 6 give discount
            if(numberDonuts >= 6)
            {
                discount = subTotal * .10m;
            }
            return discount;

        }
        private decimal CalculateTax(decimal taxableAmount)
        {
            decimal taxAmount;
            taxAmount = taxableAmount * .075m; // This would have been better as a constant
            return taxAmount;
        }

        public string PrintBill()
        {
            string theBill = "";
            // print the donuts in the sack
            for(int x = 0; x < numberDonuts; x++)
            {
                theBill += SackContents[x] + "\n";
            }
            theBill += "--------------------\n";
            decimal subTotal = CalculateSubTotalOrder();
            theBill += "    subTotal " + subTotal.ToString("c");
            //is there a discount
            decimal discountAmt = Discount(subTotal);
            theBill += "\n    discount " + discountAmt.ToString("c");
            subTotal = subTotal - discountAmt;
            decimal taxAmt;
            taxAmt = CalculateTax(subTotal);
            theBill += "\n         Tax " + taxAmt.ToString("c");
            theBill += " \n       Total " + (subTotal + taxAmt).ToString("c");


            return theBill;
        }

    }
}
