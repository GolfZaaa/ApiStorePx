namespace ApiStorePx.DTOs.Stock
{
    public class CreateReStockDto
    {
        public int ProductId { get; set; } 
        public decimal PackCost { get; set; }
        public int UnitsPerPack { get; set; }
        public int Packs { get; set; }
    }
}
