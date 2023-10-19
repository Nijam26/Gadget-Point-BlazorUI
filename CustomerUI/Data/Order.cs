using System.ComponentModel.DataAnnotations;

namespace CustomerUI.Data
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string? CustomerEmail { get; set; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public string? PaymentIntentId { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public int DelMethId { get; set; }
        public CustomerBasket CustomerBasket { get; set; }
        public string CustomerId { get; set; }
    }
}
