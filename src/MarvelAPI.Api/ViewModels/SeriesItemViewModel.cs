namespace MarvelAPI.Api.ViewModels
{
    public class SeriesItemViewModel
    {
        public int Id { get; set; }
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public SeriesViewModel Series { get; set; }
    }
}
