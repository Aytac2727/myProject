namespace Kitabchi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Image
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string ImgUrl { get; set; }
    }
}
