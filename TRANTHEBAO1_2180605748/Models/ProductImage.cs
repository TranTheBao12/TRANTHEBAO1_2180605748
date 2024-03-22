namespace TRANTHEBAO1_2180605748.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductionId { get; set; }
        public Product? Product { get; set; }
    }
}
