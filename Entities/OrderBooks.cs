using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Entities
{
    public class OrderBooks : BaseEntity
    {
        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int? BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
