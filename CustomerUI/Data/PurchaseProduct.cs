using System.ComponentModel.DataAnnotations;

namespace CustomerUI.Data
{
    public class PurchaseProduct
    {
        [Key]
        public int PurchaseId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; } = DateTimeOffset.Now;

        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        public int PurchaseQuantity { get; set; }
        public decimal PurchasePrice { get; set; }
        //public int CategoryId { get; set; }
        //public Product Product { get; set; }
    }
}