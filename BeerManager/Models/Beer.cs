namespace BeerManager.Models
{
    public class Beer
    {
        public int BeerId { get; set; }
        public string Name { get; set; }
        public double AlcoholDegree { get; set; }
        public decimal Price { get; set; }
        public int BrasserieId { get; set; }
        public List<Vendor> Vendors { get; set; }
        public Brasserie Brasserie { get; set; }
    }
}