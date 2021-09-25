using Kitabchi.Helper;
using Kitabchi.Models;
using Kitabchi.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.Controllers
{
    public class ProductsController : Controller
    {
        public KitabchiContext _context;

        public ProductsController(KitabchiContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id, int? pageNo,decimal? from,decimal? to, int? recordSize,  int? sortBy)
        {
            recordSize = recordSize.HasValue ? recordSize.Value : 12;
            ProductWithCategoryVM vm = new ProductWithCategoryVM()
            {
                Categories = _context.Categories.ToList(),
                Products = SearchProducts(id,  pageNo, recordSize.Value, sortBy, to,from),     
                Pager = new Pager (recordSize.Value, pageNo,recordSize.Value),
                SortBy=sortBy,
                RecordSize = recordSize.Value,
                PriceTo=to,
                PriceFrom=from,
                CategoryID = id
            };
            

            return View(vm);
        }
        public IActionResult FilterProduct(int? id, int? pageNo, decimal? from, decimal? to, int? recordSize, int? sortBy) {
            recordSize = recordSize.HasValue ? recordSize.Value : 12;
            ProductWithCategoryVM vm = new ProductWithCategoryVM()
            {
                Products = SearchProducts(id, pageNo, recordSize.Value, sortBy, to, from),
                Pager = new Pager(recordSize.Value, pageNo, recordSize.Value),
                SortBy = sortBy,
                RecordSize = recordSize,
                PriceTo = to,
                PriceFrom = from,
                CategoryID = id
            };
            return PartialView("_priceFilter",vm);
        }
        public List<Product> SearchProducts(int? id, int? pageNo, int? recordSize,  int? sortBy,decimal? to,decimal? from)
        {
            recordSize = recordSize.HasValue ? recordSize.Value : 12;
            var products = _context.Products.AsQueryable();
            if (id.HasValue)
            {
                products = products.Where(x => x.CategoryID == id);
            }
            if (from.HasValue && from.Value > 0.0M)
            {
                products = products.Where(x => x.Price >= from.Value);
            }

            if (to.HasValue && to.Value > 0.0M)
            {
                products = products.Where(x => x.Price <= to.Value && x.Price >= from.Value);
            }

            if (sortBy.HasValue)
            {
                switch (sortBy)
                {
                    case 1:
                        products= products.OrderBy(x => x.Price);
                        break;
                    case 2:
                        products = products.OrderByDescending(x => x.Price);
                        break;
                    default:
                        products = products.OrderByDescending(x => x.ID);
                        break;
                }
            }
            pageNo = pageNo ?? 1;
            var skipCount = (pageNo.Value - 1) * recordSize.Value;
           int count = products.Count();
           
            return products.Skip(skipCount).Take(recordSize.Value).ToList();
        }

    }
}
