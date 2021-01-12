using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApp.Entities
{
    public class FidelityBonus : BaseEntity
    {
        public int Points { get; set; }
        public virtual Client Client { get; set; }
    }
}
