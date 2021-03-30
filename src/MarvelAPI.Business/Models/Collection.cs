namespace MarvelAPI.Business.Models
{
    public abstract class Collection : Entity
    {
        public int Available { get; set; }
        public string CollectionURI { get; set; }
    }
}
