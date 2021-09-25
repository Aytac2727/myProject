using Kitabchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.ViewModel
{
    public class ProductVM
    {
        public Product Products  { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
