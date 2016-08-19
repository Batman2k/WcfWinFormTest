namespace StoreService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderItem
    {
        [Key]
        public int itemId { get; set; }

        public int fkOrderId { get; set; }

        public decimal Price { get; set; }

        public int ArticleId { get; set; }
    }
}
