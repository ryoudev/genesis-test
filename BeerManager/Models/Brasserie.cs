namespace BeerManager.Models
{
    public class Brasserie
    {
        public int BrasserieId { get; set; }
        public string Name { get; set; }
        public List<Beer> Beers { get; set; }
    }
}