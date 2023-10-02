using Freelancer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Entities
{
    internal class Review : EntityBase<Guid>
    {
        public int Rating { get; set; }
        public string? Text { get; set; }

        public Freelancer? ReviewedFreelancer { get; set; }

        public Customer? ReviewedCustomer { get; set; }
    }
}
