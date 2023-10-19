using System.ComponentModel.DataAnnotations;

namespace CustomerUI.Data
{
    public class DeliveryMethod
    {
        [Key]
        public int DelMethId { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }
        public string? DeliveryTime { get; set; }
        public decimal Price { get; set; }
    }
}
