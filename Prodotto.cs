using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        public string prodName;
        public string prodDescription;
        public double prodPrice;
        public int prodCode;

        public Prodotto(string input1, string input2, double input3)
        {
            prodName = input1;
            prodDescription = input2;
            prodPrice = input3;

            Random rand = new Random();
            prodCode = rand.Next(1, 100);
        }
    }
}
