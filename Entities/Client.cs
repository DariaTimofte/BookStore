using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Entities
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public int? RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int? FidelityBonusId { get; set; }
        public virtual FidelityBonus FidelityBonus { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
