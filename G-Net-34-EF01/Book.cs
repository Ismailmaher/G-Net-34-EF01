using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF01
{
    public class Book
    {
        // title, ISBN number, price, number of pages, the year 
public string? Title { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }
        public string? ISBN { get; set; }
        public int Pages { get; set; }
        public int PublishedYear { get; set; }
        public bool InStock { get; set; }
    }
}
