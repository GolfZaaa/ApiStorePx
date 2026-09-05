using System.Net.ServerSentEvents;

namespace ApiStorePx.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SellPrice { get; set; }
        public int Stock { get; set; }
        public int AvgCost { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }
        public ICollection<Restock> restocks { get; set; } = new List<Restock>();
        public ICollection<SaleItem> saleItems { get; set; } = new List<SaleItem>();
    }
}
