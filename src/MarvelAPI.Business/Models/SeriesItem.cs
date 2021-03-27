namespace MarvelAPI.Business.Models
{
    public class SeriesItem : Item
    {
        public int SeriesId { get; set; }
        public Series Series { get; set; }
    }
}