using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
