using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{
    public class Customer: BaseEntitiy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
