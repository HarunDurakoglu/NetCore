using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DomainModels
{
    public class CartLine : IDomainModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set;}
    }
}
