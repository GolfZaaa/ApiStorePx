namespace ApiStorePx.Models
{
    public class SaleItem
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int SellPrice { get; set; }
        public int UnitCost { get; set; }
        public Sale? sale { get; set; }
        public Product? product { get; set; }
    }
}
