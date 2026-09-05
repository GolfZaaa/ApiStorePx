namespace ApiStorePx.DTOs.Product
{
    public class CreateProductDto
    {
        public string Name { get; set; } = string.Empty;
        public int SellPrice { get; set; }
    }
}
