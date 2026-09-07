namespace ApiStorePx.DTOs.Stock
{
    public class CreateReStockDto
    {
        public int ProductId { get; set; } 
        public int PackCost { get; set; }
        public int UnitsPerPack { get; set; }
        public int Pack { get; set; }
    }
}
