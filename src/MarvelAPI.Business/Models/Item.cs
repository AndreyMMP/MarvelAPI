namespace MarvelAPI.Business.Models
{
    public abstract class Item : Entity
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
    }
}
