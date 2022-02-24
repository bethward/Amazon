using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission7.Models
{
    public class Basket
    {
        //first part declares and second part instantiates
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public void AddItem (Book bk, int qty)
        {
            BasketLineItem line = Items
                .Where(b => b.Book.BookId == bk.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = bk,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }

        }

        //public double CalculateSubTotal()
        //{
        //    //double Total = Items.Sum(x => x.Book.Price * x.Quantity);

        //    return 50;

        //}

        //public double CalculateTotal()
        //{
        //    double Total = Items.Sum(x => x.Quantity * 1);
        //    double Total = Items.Sum(b.Book.Price * x.Quantity)

        //    return Total;

        //}
    }

    public class BasketLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

        //my edit
        //public float Price { get; set; }
    }
}
