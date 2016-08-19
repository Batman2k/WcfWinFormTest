namespace StoreService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShippingDate { get; set; }

        [Required]
        public string PaymentOption { get; set; }

        [Required]
        public string DeliveryType { get; set; }

        public decimal TotalPrice { get; set; }

        [Required]
        public string OrdedBy { get; set; }
    }
}
