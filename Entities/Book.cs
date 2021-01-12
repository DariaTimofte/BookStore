using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public double Price { get; set; }
        public int Poits { get; set; }
        public IList<OrderBooks> OrderBooks { get; set; }

    }
}
