using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.ViewModel
{
    public class PriceRangeFilterVM
    {
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
        public decimal MaxPrice { get; set; }
    }
}
