using NB.Analytics.DomainShared.Book;
using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Analytics.Domain
{
    public class Book 
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
