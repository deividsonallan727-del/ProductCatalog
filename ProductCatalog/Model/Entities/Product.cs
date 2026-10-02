using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCatalog.Model.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        [Column("Name", TypeName = "nvarchar(100)")]
        [MinLength(3), MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Column("Description", TypeName = "nvarchar(500)")]
        [MinLength(10), MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [Column("Price", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        [Column("Stock", TypeName = "int")]
        public int Stock { get; set; }
        [Required]
        [Column("CategoryId", TypeName = "bigint")]
        public long CategoryId { get; set; }

    }
}
