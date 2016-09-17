using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Product
    {
        //will assing all variables as private. They will not be used outside of the class.
        //Declare the inputs. 
        private string productName;
        private int count;
        private double unitPrice;
        private bool isFoodItem;
        

        //outputs that we want
        private double priceBeforeTax, priceAfterTax;
        private double taxPaid; //to see just the amount of tax paid (currency)
        private string taxRate; //to see the rate of tax, will be displayed as string "25%" or "12%" 
                                    //in future can use foodVATRate.ToString("p")

        //Values for what VAT factor should be applied to final price
        private const double  foodVATRate = 0.12, otherVATRate = 0.25;


        public void Start()
        {
            //1, Read Input
            ReadInput();
            //2, Calculate Tax
            CalculatePrices();
            //3, Show results; priceBeforeTax, priceAfterTex
            PrintReceipt();
        }

        private void ReadInput()
        {
            //Read a value for the name
            ReadName();
            //Read a value for unitPrice
            ReadUnitPrice();
            //Read a value for count
            ReadCount();
            //Read a value for isFoodItem
            ReadIsFoodItem();
        }

        private void ReadName()
        {
            Console.Write("Enter the name of the product>> ");
            productName = Console.ReadLine();
        }

        private void ReadUnitPrice()
        {
            Console.Write("Enter the price of the product>> ");
            string input = Console.ReadLine(); //test to be changed to a double
            unitPrice = double.Parse(input); //the price is now correctly formated
        }
        private void ReadCount()
        {
            Console.Write("Enter the quantity of the product>> ");
            string input = Console.ReadLine(); //text that needs to be changed to an int
            count = int.Parse(input);
        }
        

        private void ReadIsFoodItem() //This method is taken from the Assignment instruction
        {
            Console.Write("Is it a food item (y/n)?");

            char response = char.Parse(Console.ReadLine());
            if ((response == 'y') || (response == 'Y'))
                isFoodItem = true;

            else
                isFoodItem = false;

        }

        private void CalculatePrices()
        {
            CalculatePriceBeforeTax();
            CalculatePriceAfterTax();
            CalculateTaxPaid();
            CalculateTaxRate();
        }

        private void CalculatePriceBeforeTax()
        {
            priceBeforeTax = count * unitPrice;
        }

        private void CalculatePriceAfterTax()
        {
            if (isFoodItem == true)
                priceAfterTax = priceBeforeTax + foodVATRate*priceBeforeTax;
            
            else
                priceAfterTax = priceBeforeTax + otherVATRate*priceBeforeTax;
            
        }
        private void CalculateTaxPaid()
        {
            taxPaid = priceAfterTax - priceBeforeTax;
        }

        private void CalculateTaxRate()
        {
            if (isFoodItem == true)
                taxRate = ("12.5%");
            else
                taxRate = ("25.0%");
        }
        private void PrintReceipt()
        {
            Console.WriteLine();
            Console.WriteLine("***Welcome to Oskar's Fireworks, Liquor and Smoke Shack***");
            Console.WriteLine("          Product     : {0}  " + "Quantity:  {1}",productName, count);
            Console.WriteLine("      Net Price       : {0}  ", priceBeforeTax.ToString("00.00")); 
            Console.WriteLine("Price w/ Tax at {0} : {1}",taxRate, priceAfterTax.ToString("00.00"));
            Console.WriteLine("   Total tax paid     : " + taxPaid.ToString("00.00"));

            Console.WriteLine("********This program was developed by Oskar Enmalm********");

        }
    }//end of product class
}
          

   

