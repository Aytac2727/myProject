namespace Kitabchi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class SliderToImage
    {
        public int ID { get; set; }

        public int SliderID { get; set; }
        public int ImageID { get; set; }
        public virtual Image Image { get; set; }
    }
}
