namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }

        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public string MetaTitle { get; set; }

        public int? Quantity { get; set; }

        public string Image { get; set; }

        public long? CategoryID { get; set; }

        public decimal? Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public DateTime? TopHot { get; set; }

        public int? Status { get; set; }
    }
}
