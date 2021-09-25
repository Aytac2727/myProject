using Kitabchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.Areas.Dashboard.ViewModels
{
    public class SliderViewModel
    {
        public int ID { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string SliderPicture { get; set; }
        public List<SliderToImage>SliderToImages { get; set; }
    }
}
