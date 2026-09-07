using ApiStorePx.Models;

namespace ApiStorePx.DTOs.Checkout
{
    public class CheckoutDto
    {
        public PaymentMethod PaymentMethod { get; set; }

        public List<CheckoutItemDto> Items { get; set; }
            = new();
    }

    public class CheckoutItemDto
    {
        public string ProductId { get; set; }
            = string.Empty;

        public int Qty { get; set; }
    }
}
