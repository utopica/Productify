using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productify.Domain.Entities
{
    public class Product
    {
       
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        


        public Product( string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedOn = DateTimeOffset.Now;
            
        }

    }
}
