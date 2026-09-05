namespace ApiStorePx.Models
{
    public class Restock
    {
        public int Id { get; set; }
        public int ProductId { get; set; } = 0;
        public int PackCost { get; set; }
        public int UnitPerPack { get; set; }
        public int Packs { get; set; }
        public int UnitCost { get; set; }
        public int TotalUnits { get; set; }
        public int TotalCost { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Product? product { get; set; }
    }
}
