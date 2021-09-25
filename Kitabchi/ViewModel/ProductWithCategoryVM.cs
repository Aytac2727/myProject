using Kitabchi.Helper;
using Kitabchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.ViewModel
{
    public class ProductWithCategoryVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public int ?CategoryID { get; set; }

        public Pager Pager { get; set; }
        public int? PageSize { get; set; }
        public int? SortBy { get; set; }
        public int? PageNo { get; set; }
        public string searchTerm { get; set; }
        public decimal? PriceTo { get; set; }
        public decimal? PriceFrom { get; set; }
        public decimal MaxPrice{ get; set; }
        public int? RecordSize { get; set; }

    }
}
