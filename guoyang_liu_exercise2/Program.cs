using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guoyang_liu_exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(87, "Electric Sander", 7, 57.98m);
            Invoice invoice2 = new Invoice(24, "Power Saw", 18, 99.99m);
            Invoice invoice3 = new Invoice(7, "Sledge Hammer", 11, 21.50m);
            Invoice invoice4 = new Invoice(77, "Hammer", 76, 11.99m);
            Invoice invoice5 = new Invoice(39, "Lawn Mower", 3, 79.50m);
            Invoice invoice6 = new Invoice(68, "Screw Driver", 106, 6.99m);
            Invoice invoice7 = new Invoice(56, "Jig Saw", 21, 11.00m);

            List<Invoice> list = new List<Invoice>();
            list.Add(invoice1);
            list.Add(invoice2);
            list.Add(invoice3);
            list.Add(invoice4);
            list.Add(invoice5);
            list.Add(invoice6);
            list.Add(invoice7);

            //a) Question

            var a = from i in list
                    let value = i.Quanlity * i.Price
                    orderby value ascending
                    select new
                    {
                        partDescription = i.PartDescription,
                        InvoiceTotal = value
                    };

            foreach (var i in a)
            {
                Console.WriteLine(i.partDescription + " " + i.InvoiceTotal);
            }
            //b) Question

            var b = from i in list
                    where i.Quanlity == list.Max(q => q.Quanlity)
                    select i.PartDescription;
            foreach (var i in b)
            {
                Console.WriteLine("The highest quanlity: " + i);
            }

            //c) Question

            var c = from i in list
                    select list.Average(l => l.Price);


            Console.WriteLine("The average price is: " + "$"+c.ToList()[0].ToString("F2"));
        }
    }
}
