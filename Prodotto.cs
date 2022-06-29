using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        private string prodName;
        private string prodDescription;
        private double prodPrice;
        private int prodCode;

        public Prodotto(string input1, string input2, double input3)
        {
            prodName = input1;
            prodDescription = input2;
            prodPrice = input3;

            Random rand = new Random();
            prodCode = rand.Next(1, 100);
        }

        public string GetName() {
            return this.prodName;
        }

        public string SetName(string value)
        {
            this.prodName = value;
            return this.prodName;
        }

        public string GetDescription()
        {
            return this.prodDescription;
        }

        public string SetDescription(string value)
        {
            this.prodDescription = value;
            return this.prodDescription;
        }


        public double GetPrice()
        {
            return prodPrice;
        }

        public double SetPrice(double value)
        {
            this.prodPrice = value;
            return prodPrice;
        }

        public int GetCode()
        {
            return this.prodCode;
        }

        public double IvaPrice()
        {
            double iva = (this.prodPrice * 22) / 100;
            double finalPrice = this.prodPrice + iva;
            return finalPrice;
        }

        public string fullName()
        {
            string fullName = this.prodName + this.prodCode.ToString();
            return fullName;
        }
    }
}
