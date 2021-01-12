using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Entities
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public virtual List<Client> Clients { get; set; }

    }
}
