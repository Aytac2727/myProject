using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.Models
{
    public class OfferToImage
    {
        public int ID { get; set; }

        public int OfferID { get; set; }

        public int ImageUrl { get; set; }

        public virtual Image Image { get; set; }
    }
}
