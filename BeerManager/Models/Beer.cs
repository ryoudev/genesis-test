namespace BeerManager.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double AlcoholDegree { get; set; }
        public decimal Price { get; set; }
        public int BrasserieId { get; set; }
        public Brasserie Brasserie { get; set; }
    }
}