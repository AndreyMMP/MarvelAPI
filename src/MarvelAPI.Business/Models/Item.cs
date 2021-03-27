namespace MarvelAPI.Business.Models
{
    public class Item : Entity
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        /* EF Relations */
        public int SeriesId { get; set; }
        public Series Series { get; set; }
        public int EventsId { get; set; }
        public Events Events { get; set; }
        public int StoriesId { get; set; }
        public Stories Stories { get; set; }
        public int ComicsId { get; set; }
        public Comics Comics { get; set; }
    }
}
