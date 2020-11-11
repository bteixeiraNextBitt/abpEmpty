using NB.Analytics.DomainShared.Book;
using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Analytics.ApplicationContracts.Dto
{
    public class CreateUpdateBookDto
    {

        public string Name { get; set; }

        public BookType Type { get; set; } = BookType.Undefined;


        public DateTime PublishDate { get; set; } = DateTime.Now;

        public float Price { get; set; }
    }
}
