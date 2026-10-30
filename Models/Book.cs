using System;
using System.Collections.Generic;
using System.Text;

namespace EF01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string ISBN{  get; set; }
        public string Title {  get; set; }
        public decimal Price {  get; set; }
        public int NumberOfPages { get; set; }
        public int PublishYear { get; set; }
        public bool InStock { get; set; }

        public Categoey categoey { get; set;  }

    }
}
