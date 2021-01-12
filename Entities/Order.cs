using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Entities
{
    public class Order : BaseEntity
    {
        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual List<Book> Books { get; set; }
        public int TotalPrice { get; set; }
        public IList<OrderBooks> OrderBooks { get; set; }

    }
}
