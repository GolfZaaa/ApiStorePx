namespace ApiStorePx.Models
{
    public class Restock
    {
        public int Id { get; set; }
        public int ProductId { get; set; } = 0;
        public decimal PackCost { get; set; }
        public int UnitPerPack { get; set; }
        public int Packs { get; set; }
        public decimal UnitCost { get; set; }
        public int TotalUnits { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Product? product { get; set; }
    }
}
