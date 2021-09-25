using Kitabchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.Areas.Dashboard.ViewModels
{
    public class OfferViewModel
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime Time { get; set; }

        public string ImageID { get; set; }
        public virtual List<OfferToImage> OfferToImages { get; set; }
    }
}
