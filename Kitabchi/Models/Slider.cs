namespace Kitabchi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class Slider
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Description1 { get; set; }

        [StringLength(500)]
        public string Description2 { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        public virtual List<SliderToImage> SliderToImages { get; set; }
    }
}
