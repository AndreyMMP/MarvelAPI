namespace MarvelAPI.Business.Models
{
    public class StoriesItem : Item
    {
        public string Type { get; set; }
        public int StoriesId { get; set; }
        public Stories Stories { get; set; }        
    }
}
