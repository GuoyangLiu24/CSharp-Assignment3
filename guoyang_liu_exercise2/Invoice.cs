using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guoyang_liu_exercise2
{
    class Invoice
    {
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quanlity { get; set; }
        public decimal Price { get; set; }

        public Invoice(int number, string des, int quanlity, decimal price)
        {
            PartNumber = number;
            PartDescription = des;
            Quanlity = quanlity;
            Price = price;
        }
    }
}
