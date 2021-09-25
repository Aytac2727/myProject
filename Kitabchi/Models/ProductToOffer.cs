using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.Models
{
    public class ProductToOffer
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int OfferID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Offer Offer { get; set; }
    }
}
