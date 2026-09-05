using System.Net.ServerSentEvents;

namespace ApiStorePx.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public PaymentMethod PaymentMethod { get; set; }
        public int Total { get; set; }
        public int Cost { get; set; }
        public int Profit { get; set; }
        public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();
    }
}
