namespace MarvelAPI.Business.Models
{
    public abstract class Collection : Entity
    {
        public string Available { get; set; }
        public string CollectionURI { get; set; }
    }
}
