namespace StoreService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        public int Articleid { get; set; }

        public decimal Price { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public string Information { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }
    }
}
