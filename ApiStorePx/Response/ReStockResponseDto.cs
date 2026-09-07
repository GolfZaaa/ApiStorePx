namespace ApiStorePx.Response
{
    public class ReStockResponseDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal PackCost { get; set; }
        public int UnitPerPack { get; set; }
        public int Packs { get; set; }
        public decimal UnitCost { get; set; }
        public int TotalUnits { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
